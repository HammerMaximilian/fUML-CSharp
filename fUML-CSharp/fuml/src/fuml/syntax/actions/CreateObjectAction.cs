﻿using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public class CreateObjectAction : Action
    {
        public OutputPin? result = null;
        public Classifier? classifier = null;

        public void setClassifier(Classifier classifier)
        {
            this.classifier = classifier ?? throw new ArgumentNullException(nameof(classifier));
        } // setClassifier

        public void setResult(OutputPin result)
        {
            addOutput(result);
            this.result = result;
        } // setResult
    } // CreateObjectAction
}