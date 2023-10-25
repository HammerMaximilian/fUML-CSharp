using fuml.syntax.classification;

namespace fuml.syntax.actions
{
    public abstract class StructuralFeatureAction : Action
    {
        public StructuralFeature? structuralFeature = null;
        public InputPin? object_ = null;

        public void setStructuralFeature(
            StructuralFeature structuralFeature)
        {
            this.structuralFeature = structuralFeature ?? throw new ArgumentNullException(nameof(structuralFeature));
        } // setStructuralFeature

        public void setObject(InputPin object_)
        {
            addInput(object_);
            this.object_ = object_;
        } // setObject
    } // StructuralFeatureAction
}
