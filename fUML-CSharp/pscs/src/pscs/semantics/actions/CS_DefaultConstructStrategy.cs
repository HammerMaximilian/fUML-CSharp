using fuml.semantics.loci;
using fuml.semantics.simpleclassifiers;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using pscs.src.pscs.semantics.values;
using uml.classification;
using uml.commonstructure;
using uml.simpleclassifiers;
using uml.structuredclassifiers;
using uml.values;

namespace pscs.semantics.actions
{
    public class CS_DefaultConstructStrategy : CS_ConstructStrategy
    {
        public Locus? locus = null;
        public Association? defaultAssociation = null;
        public List<Class_> generatedRealizingClasses = new();

        public override Object_ Construct(Operation constructor, CS_Object context)
        {
            locus = context.locus;
            return ConstructObject(context, (Class_)constructor.type! ?? throw new InvalidCastException());
        }

        public Object_ ConstructObject(CS_Object context, Class_ type)
        {
            CS_Reference referenceToContext = new()
            {
                referent = context,
                compositeReferent = context
            };
            // FIXME detect infinite recursive instantiation
            List<Property> allAttributes = type.attribute;
            int i = 1;
            // Instantiate ports and parts
            while (i <= allAttributes.Count)
            {
                Property p = allAttributes.ElementAt(i - 1);
                if (p.defaultValue is not null)
                {
                    ValueSpecification defaultValueSpecification = p.defaultValue;
                    Evaluation evaluation = (Evaluation)context?.locus?.factory?.InstantiateVisitor(defaultValueSpecification)! ?? throw new InvalidCastException();
                    evaluation.specification = defaultValueSpecification;
                    evaluation.locus = context.locus;
                    if (evaluation is CS_OpaqueExpressionEvaluation cS_OpaqueExpressionEvaluation)
                    {
                        List<Value> evaluations = cS_OpaqueExpressionEvaluation.ExecuteExpressionBehavior();
                        foreach (Value _evaluation in evaluations)
                        {
                            AddStructuralFeatureValue(referenceToContext, p, _evaluation);
                        }
                    }
                    else
                    {
                        Value defaultValue = evaluation.Evaluate();
                        AddStructuralFeatureValue(referenceToContext, p, defaultValue);
                    }
                }
                else if (CanInstantiate(p))
                {
                    int j = 1;
                    while (j <= p.multiplicityElement.lower)
                    {
                        Object_ value;
                        // if p is a Port typed by an Interface
                        // creates an Object without type, but with FeatureValues corresponding to
                        // structural features of the interface.
                        if (p is Port && p.typedElement.type is Interface interface_)
                        {
                            value = InstantiateInterface(interface_, locus ?? throw new ArgumentNullException(nameof(locus)));
                            AddStructuralFeatureValue(referenceToContext, p, value);
                        }
                        else
                        {
                            value = context?.locus?.Instantiate((Class_)p.typedElement.type! ?? throw new InvalidCastException())!;
                            // TODO account for existing constructors
                            value = ConstructObject((CS_Object)value, (Class_)p.typedElement.type! ?? throw new InvalidCastException());
                            AddStructuralFeatureValue(referenceToContext, p, value);
                            if (((Class_)p.typedElement.type).isActive)
                            {
                                value.StartBehavior((Class_)p.typedElement.type, new());
                            }
                        }
                        j++;
                    }
                }
                i++;
            }
            // Instantiate connectors
            List<NamedElement> allMembers = type.Member();
            i = 1;
            while (i <= allMembers.Count)
            {
                NamedElement member = allMembers.ElementAt(i - 1);
                if (member is Connector connector)
                {
                    if (IsArrayPattern(connector))
                    {
                        GenerateArrayPattern(referenceToContext, connector);
                    }
                    else if (IsStarPattern(connector))
                    {
                        GenerateStarPattern(referenceToContext, connector);
                    }
                }
                i++;
            }
            return referenceToContext.referent;
        }

        public void AddStructuralFeatureValue(CS_Reference context, Property feature, Value value)
        {
            FeatureValue featureValue = context.GetFeatureValue(feature);
            if (featureValue != null)
            {
                List<Value> values = featureValue.values;
                if (feature is Port port)
                {
                    // insert an interaction point
                    CS_InteractionPoint interactionPoint = new()
                    {
                        definingPort = port,
                        referent = (CS_Object)value,
                        owner = context
                    };
                    values.Add(interactionPoint);
                }
                else if (value is CS_Object cS_Object)
                {
                    // insert a reference
                    CS_Reference reference = new()
                    {
                        compositeReferent = cS_Object,
                        referent = cS_Object
                    };
                    values.Add(reference);
                }
                else
                {
                    values.Add(value);
                }
            }
        }

        public void GenerateArrayPattern(CS_Reference context, Connector connector)
        {
            ConnectorEnd end1 = connector.end.ElementAt(0);
            ConnectorEnd end2 = connector.end.ElementAt(1);
            List<Reference> end1Values = GetValuesFromConnectorEnd(context, end1);
            List<Reference> end2Values = GetValuesFromConnectorEnd(context, end2);
            for (int i = 0; i < end1Values.Count; i++)
            {
                CS_Link link = new();
                if (connector.type is null)
                {
                    link.type = GetDefaultAssociation();
                }
                else
                {
                    link.type = connector.type;
                }
                List<Value> valuesForEnd1 = new()
                {
                    end1Values.ElementAt(i)
                };
                List<Value> valuesForEnd2 = new()
                {
                    end2Values.ElementAt(i)
                };
                link.SetFeatureValue(link.type.ownedEnd.ElementAt(0), valuesForEnd1, -1);
                link.SetFeatureValue(link.type.ownedEnd.ElementAt(1), valuesForEnd2, -1);
                link.AddTo(context?.referent?.locus ?? throw new ArgumentNullException(nameof(locus)));
            }
        }

        public List<Reference> GetValuesFromConnectorEnd(CS_Reference context, ConnectorEnd end)
        {
            List<Reference> endValues = new();
            if (end.partWithPort != null)
            {
                FeatureValue valueForPart = context.GetFeatureValue(end.partWithPort);
                if (valueForPart != null)
                {
                    for (int i = 0; i < valueForPart.values.Count; i++)
                    {
                        Reference reference = (Reference)valueForPart.values.ElementAt(i);
                        FeatureValue valueForPort = reference.GetFeatureValue((Port)end.role! ?? throw new InvalidCastException());
                        if (valueForPort != null)
                        {
                            for (int j = 0; j < valueForPort.values.Count; j++)
                            {
                                endValues.Add((Reference)valueForPort.values.ElementAt(j));
                            }
                        }
                    }
                }
            }
            else
            {
                FeatureValue valueForRole = context.GetFeatureValue(end.role ?? throw new InvalidCastException());
                if (valueForRole != null)
                {
                    for (int i = 0; i < valueForRole.values.Count; i++)
                    {
                        endValues.Add((Reference)valueForRole.values.ElementAt(i));
                    }
                }
            }
            return endValues;
        }

        public void GenerateStarPattern(CS_Reference context, Connector connector)
        {
            ConnectorEnd end1 = connector.end.ElementAt(0);
            ConnectorEnd end2 = connector.end.ElementAt(1);
            List<Reference> end1Values = GetValuesFromConnectorEnd(context, end1);
            List<Reference> end2Values = GetValuesFromConnectorEnd(context, end2);
            for (int i = 0; i < end1Values.Count; i++)
            {
                for (int j = 0; j < end2Values.Count; j++)
                {
                    CS_Link link = new();
                    if (connector.type is null)
                    {
                        link.type = GetDefaultAssociation();
                    }
                    else
                    {
                        link.type = connector.type;
                    }
                    List<Value> valuesForEnd1 = new()
                    {
                        end1Values.ElementAt(i)
                    };
                    List<Value> valuesForEnd2 = new()
                    {
                        end2Values.ElementAt(j)
                    };
                    link.SetFeatureValue(link.type.ownedEnd.ElementAt(0), valuesForEnd1, -1);
                    link.SetFeatureValue(link.type.ownedEnd.ElementAt(1), valuesForEnd2, -1);
                    link.AddTo(context?.referent?.locus ?? throw new ArgumentNullException(nameof(locus)));
                }
            }
        }

        public bool CanInstantiate(Property p)
        {
            // Instantiate is possible if:
            // - p is composite
            // - p is typed
            // - This type is a Class and it is not abstract
            // - Or p is a Port and the type is an Interface
            if (p.isComposite)
            {
                if (p.typedElement.type != null)
                {
                    if (p.typedElement.type is Class_ class_)
                    {
                        return !class_.isAbstract;
                    }
                    else if (p.typedElement.type is Interface)
                    {
                        return p is Port;
                    }
                }
            }
            return false;
        }

        public int GetCardinality(ConnectorEnd end)
        {
            int lowerOfRole = end.role?.multiplicityElement.lower ?? throw new NullReferenceException();
            if (lowerOfRole == 0)
            {
                return 0;
            }
            else if (end.partWithPort is null)
            {
                return lowerOfRole;
            }
            else
            {
                int lowerOfPart = end.partWithPort.multiplicityElement.lower;
                return lowerOfRole * lowerOfPart;
            }
        }

        public bool IsArrayPattern(Connector c)
        {
            // This is an array pattern if:
            // - c is binary
            // - lower bound of the two connector ends is 1
            // - Cardinality of ends are equals
            if (c.end.Count == 2)
            {
                if (c.end.ElementAt(0).lower == 1)
                {
                    if (c.end.ElementAt(1).lower == 1)
                    {
                        if (CanInstantiate(c.end.ElementAt(0).role ?? throw new ArgumentNullException(nameof(locus))) && CanInstantiate(c.end.ElementAt(1).role ?? throw new ArgumentNullException("")))
                        {
                            int cardinality1 = GetCardinality(c.end.ElementAt(0));
                            int cardinality2 = GetCardinality(c.end.ElementAt(1));
                            return cardinality1 == cardinality2;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsStarPattern(Connector c)
        {
            // This is an array pattern if:
            // - c is binary
            // - lower bound of end1 equals cardinality of end1
            // - lower bound of end2 equals cardinality of end2
            if (c.end.Count == 2)
            {
                if (CanInstantiate(c.end.ElementAt(0).role ?? throw new ArgumentNullException("Property p")) && CanInstantiate(c.end.ElementAt(1).role ?? throw new ArgumentNullException("Property p")))
                {
                    int cardinalityOfEnd1 = GetCardinality(c.end.ElementAt(0));
                    int lowerBoundofEnd1 = c.end.ElementAt(0).lower;
                    if (cardinalityOfEnd1 == lowerBoundofEnd1)
                    {
                        int cardinalityOfEnd2 = GetCardinality(c.end.ElementAt(1));
                        int lowerBoundofEnd2 = c.end.ElementAt(1).lower;
                        return cardinalityOfEnd2 == lowerBoundofEnd2;
                    }
                }
            }
            return false;
        }

        public Association GetDefaultAssociation()
        {
            // Computes an returns an Association with two untyped owned ends,
            // with multiplicity [*].
            // This association can be used to type links instantiated from untyped connectors
            if (defaultAssociation == null)
            {
                defaultAssociation = new();
                defaultAssociation.SetName("DefaultGeneratedAssociation");
                Property end1 = new();
                end1.SetName("x");
                end1.SetLower(0);
                end1.SetUpper(-1);
                end1.SetIsOrdered(true);
                end1.SetIsUnique(true);
                defaultAssociation.AddOwnedEnd(end1);
                Property end2 = new();
                end2.SetName("y");
                end2.SetLower(0);
                end2.SetUpper(-1);
                end2.SetIsOrdered(true);
                end2.SetIsUnique(true);
                defaultAssociation.AddOwnedEnd(end2);
            }
            return defaultAssociation;
        }

        public Object_ InstantiateInterface(Interface interface_, Locus locus)
        {
            Class_ realizingClass = GetRealizingClass(interface_);
            Object_ object_ = locus.Instantiate(realizingClass);
            return object_;
        }

        public Class_ GetRealizingClass(Interface interface_)
        {
            Class_? realizingClass = null;
            // TODO For cached RealizingClasses, search based on InterfaceRealizations rather than name
            string realizingClassName = interface_.qualifiedName + "GeneratedRealizingClass";
            int i = 1;
            while (i <= generatedRealizingClasses.Count && realizingClass == null)
            {
                Class_ cddRealizingClass = generatedRealizingClasses.ElementAt(i - 1);
                if (cddRealizingClass.name.Equals(realizingClassName))
                {
                    realizingClass = cddRealizingClass;
                }
                i++;
            }
            if (realizingClass is null)
            {
                realizingClass = GenerateRealizingClass(interface_, realizingClassName);
                generatedRealizingClasses.Add(realizingClass);
            }
            return realizingClass;
        }

        public Class_ GenerateRealizingClass(Interface interface_, string className)
        {
            Class_ realizingClass = new();
            realizingClass.SetName(className);

            InterfaceRealization realization = new()
            {
                contract = interface_,
                implementingClassifier = realizingClass
            };
            realizingClass.AddInterfaceRealization(realization);
            // TODO Deal with structural features of the interface
            // TODO Make a test case for reading/writing structural features of an interface
            return realizingClass;
        }
    } // CS_DefaultConstructStrategy
}
