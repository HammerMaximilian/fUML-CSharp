using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class ReclassifyObjectAction : Action
    {
        public bool isReplaceAll = false;
        public List<Classifier> oldClassifier = new();
        public InputPin? object_ = null;
        public List<Classifier> newClassifier = new();

        public void SetIsReplaceAll(bool isReplaceAll)
        {
            this.isReplaceAll = isReplaceAll;
        } // setIsReplaceAll

        public void AddOldClassifier(
                Classifier oldClassifier)
        {
            this.oldClassifier.Add(oldClassifier);
        } // addOldClassifier

        public void AddNewClassifier(
                Classifier newClassifier)
        {
            this.newClassifier.Add(newClassifier);
        } // addNewClassifier

        public void SetObject(InputPin object_)
        {
            AddInput(object_);
            this.object_ = object_;

        } // setObject
    } // ReclassifyObjectAction
}
