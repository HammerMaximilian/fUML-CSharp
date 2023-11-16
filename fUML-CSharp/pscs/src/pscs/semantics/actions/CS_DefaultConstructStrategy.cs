using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using fuml.semantics.values;
using pscs.semantics.structuredclassifiers;
using uml.classification;
using uml.simpleclassifiers;
using uml.structuredclassifiers;

namespace pscs.semantics.actions
{
    public class CS_DefaultConstructStrategy : CS_ConstructStrategy
    {
        public Locus? locus = null;
        public Association? defaultAssociation = null;
        public List<Class_> generatedRealizingClasses = new();

        public Object_ Construct(Operation constructor, CS_Object context)
        { throw new NotImplementedException(); }

        public Object_ ConstructObject(CS_Object context, Class_ type)
        { throw new NotImplementedException(); }

        public void AddStructuralFeatureValue(CS_Reference context, Property feature, Value value)
        { throw new NotImplementedException(); }

        public void GenerateArrayPattern(CS_Reference context, Connector connector)
        { throw new NotImplementedException(); }

        public List<Reference> GetValuesFromConnectorEnd(CS_Reference context, ConnectorEnd end)
        { throw new NotImplementedException(); }

        public void GenerateStarPattern(CS_Reference context, Connector connector)
        { throw new NotImplementedException(); }

        public bool CanInstantiate(Property p)
        { throw new NotImplementedException(); }

        public int GetCardinality(ConnectorEnd end)
        { throw new NotImplementedException(); }

        public bool IsArrayPattern(Connector c)
        { throw new NotImplementedException(); }

        public bool IsStarPattern(Connector c)
        { throw new NotImplementedException(); }

        public Association GetDefaultAssociation()
        { throw new NotImplementedException(); }

        public Object_ InstantiateInterface(Interface interface_, Locus locus)
        { throw new NotImplementedException(); }

        public Class_ GetRealizingClass(Interface interface_)
        { throw new NotImplementedException(); }

        public Class_ GenerateRealizingClass(Interface interface_, string className)
        { throw new NotImplementedException(); }
    } // CS_DefaultConstructStrategy
}
