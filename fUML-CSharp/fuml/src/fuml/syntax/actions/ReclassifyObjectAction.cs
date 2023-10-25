using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class ReclassifyObjectAction : Action
    {
        public bool isReplaceAll = false;
        public List<Classifier> oldClassifier = new();
        public InputPin? object_ = null;
        public List<Classifier> newClassifier = new();

        public void setIsReplaceAll(bool isReplaceAll)
        {
            this.isReplaceAll = isReplaceAll;
        } // setIsReplaceAll

        public void addOldClassifier(
                Classifier oldClassifier)
        {
            this.oldClassifier.Add(oldClassifier);
        } // addOldClassifier

        public void addNewClassifier(
                Classifier newClassifier)
        {
            this.newClassifier.Add(newClassifier);
        } // addNewClassifier

        public void setObject(InputPin object_)
        {
            addInput(object_);
            this.object_ = object_;

        } // setObject
    } // ReclassifyObjectAction
}
