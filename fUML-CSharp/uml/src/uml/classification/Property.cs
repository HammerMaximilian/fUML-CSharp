﻿using uml.values;
using uml.simpleclassifiers;
using uml.structuredclassifiers;

namespace uml.classification
{
    public class Property : StructuralFeature
    {
        public ConnectableElement connectableElement = new(); // PSCS-specific ; NOTE: class ConnectableElement can not be abstract here
        public bool isDerived = false;
        public new bool isReadOnly = false;
        public bool isDerivedUnion = false;
        public AggregationKind aggregation = AggregationKind.none;
        public bool isComposite = false;
        public Association? owningAssociation = null;
        public DataType? datatype = null;
        public Association? association = null;
        public Class_? class_ = null;
        public Property? opposite = null;
        public ValueSpecification? defaultValue = null;
        public bool isID = false;
        public Interface? interface_ = null; // PSCS-specific

        public new void SetIsReadOnly(bool isReadOnly)
        {
            this.isReadOnly = isReadOnly;
        } // setIsReadOnly

        public void SetAggregation(
                AggregationKind aggregation)
        {
            this.aggregation = aggregation;
            isComposite = aggregation == AggregationKind.composite;
        } // setAggregation

        public void _setAssociation(
                Association association)
        {
            this.association = association ?? throw new ArgumentNullException(nameof(association));
        } // _setAssociation

        public void _setClass(Class_ class_)
        {
            this.class_ = class_ ?? throw new ArgumentNullException(nameof(class_));
            _setNamespace(class_);
        } // _setClass

        public void _setDatatype(DataType datatype)
        {
            this.datatype = datatype ?? throw new ArgumentNullException(nameof(datatype));
            _setNamespace(datatype);
        } // _setDataType

        public void SetDefaultValue(ValueSpecification defaultValue)
        {
            this.defaultValue = defaultValue ?? throw new ArgumentNullException(nameof(defaultValue));
        } // SetDefaultValue

        public void SetIsID(bool isID)
        {
            this.isID = isID;
        } // setIsID

        public void _setOwningAssociation(
                Association association)
        {
            this.association = association ?? throw new ArgumentNullException(nameof(association));
        } // _setOwningAssociation

        public void _setOpposite(Property opposite)
        {
            this.opposite = opposite;
        } // _setOpposite

        public void _setInterface(Interface interface_) // PSCS-specific
        {
            this.interface_ = interface_ ?? throw new ArgumentNullException(nameof(interface_));
            _setNamespace(interface_);
        }
    } // Property
}
