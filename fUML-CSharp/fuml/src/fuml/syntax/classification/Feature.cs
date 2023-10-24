namespace fuml.syntax.classification
{
    public abstract class Feature : RedefinableElement
    {
        public bool isStatic = false;
        public List<Classifier> featuringClassifier = new();

        public void _addFeaturingClassifier(
                Classifier featuringClassifier)
        {
            if (featuringClassifier is null)
            {
                throw new ArgumentNullException(nameof(featuringClassifier));
            }

            this.featuringClassifier.Add(featuringClassifier);
        } // _addFeaturingClassifier
    } // Feature
}
