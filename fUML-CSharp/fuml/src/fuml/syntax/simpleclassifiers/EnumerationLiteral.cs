using fuml.syntax.classification;

namespace fuml.syntax.simpleclassifiers
{
    public class EnumerationLiteral : InstanceSpecification
    {
        public Enumeration? enumeration = null;
        public new Enumeration? classifier = null;

        public void _setEnumeration(
                Enumeration enumeration)
        {
            addClassifier(enumeration);
            classifier = enumeration;
            this.enumeration = enumeration;
        } // _setEnumeration
    } // EnumerationLiteral
}
