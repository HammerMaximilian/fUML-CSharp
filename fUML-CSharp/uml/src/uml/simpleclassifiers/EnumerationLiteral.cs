using uml.classification;

namespace uml.simpleclassifiers
{
    public class EnumerationLiteral : InstanceSpecification
    {
        public Enumeration? enumeration = null;
        public new Enumeration? classifier = null;

        public void _setEnumeration(
                Enumeration enumeration)
        {
            AddClassifier(enumeration);
            classifier = enumeration;
            this.enumeration = enumeration;
        } // _setEnumeration
    } // EnumerationLiteral
}
