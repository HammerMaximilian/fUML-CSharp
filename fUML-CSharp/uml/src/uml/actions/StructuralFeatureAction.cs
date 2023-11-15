using uml.classification;

namespace uml.actions
{
    public abstract class StructuralFeatureAction : Action
    {
        public StructuralFeature? structuralFeature = null;
        public InputPin? object_ = null;

        public void SetStructuralFeature(
            StructuralFeature structuralFeature)
        {
            this.structuralFeature = structuralFeature ?? throw new ArgumentNullException(nameof(structuralFeature));
        } // setStructuralFeature

        public void SetObject(InputPin object_)
        {
            AddInput(object_);
            this.object_ = object_;
        } // setObject
    } // StructuralFeatureAction
}
