﻿using fuml.syntax.values;
using fuml.syntax.simpleclassifiers;
using fuml.syntax.structuredclassifiers;

namespace fuml.syntax.classification
{
    public class Property : StructuralFeature
    {
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

        public new void setIsReadOnly(bool isReadOnly)
        {
            this.isReadOnly = isReadOnly;
        } // setIsReadOnly

        public void setAggregation(
                AggregationKind aggregation)
        {
            this.aggregation = aggregation;
            isComposite = (aggregation == AggregationKind.composite);
        } // setAggregation

        public void _setAssociation(
                Association association)
        {
            this.association = association ?? throw new ArgumentNullException(nameof(association));
        } // _setAssociation

        public void _setClass(Class_ class_)
        {
            this.class_ = class_ ?? throw new ArgumentNullException(nameof(class_));
        } // _setClass

        public void _setDatatype(DataType datatype)
        {
            this.datatype = datatype ?? throw new ArgumentNullException(nameof(datatype));
        } // _setDataType

        public void setIsID(bool isID)
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
            this.opposite = opposite ?? throw new ArgumentNullException(nameof(opposite));
        } // _setOpposite
    } // Property
}
