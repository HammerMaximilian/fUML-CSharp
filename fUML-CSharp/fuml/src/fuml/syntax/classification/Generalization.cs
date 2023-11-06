using fuml.syntax.commonstructure;
using System;

namespace fuml.syntax.classification
{
    public class Generalization : Element
    {
        public bool isSubstitutable = true;
        public Classifier? specific = null;
        public Classifier? general = null;

        public void SetIsSubstitutable(bool isSubstitutable)
        {
            this.isSubstitutable = isSubstitutable;
        } // setIsSubstitutable

        public void SetGeneral(Classifier general)
        {
            this.general = general ?? throw new ArgumentNullException(nameof(general));
        } // setGeneral

        public void _setSpecific(Classifier specific)
        {
            this.specific = specific ?? throw new ArgumentNullException(nameof(specific));
        } // _setSpecific
    }
} // Generalization
