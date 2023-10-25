using fuml.syntax.activities;

namespace fuml.syntax.actions
{
    public class ExpansionNode : ObjectNode
    {
        public ExpansionRegion? regionAsOutput = null;
        public ExpansionRegion? regionAsInput = null;

        public void _setRegionAsInput(
                ExpansionRegion regionAsInput)
        {
            this.regionAsInput = regionAsInput ?? throw new ArgumentNullException(nameof(regionAsInput));
        } // _setRegionAsInput

        public void _setRegionAsOutput(
                ExpansionRegion regionAsOutput)
        {
            this.regionAsOutput = regionAsOutput ?? throw new ArgumentNullException(nameof(regionAsOutput));
        } // _setRegionAsOutput
    } // ExpansionNode
}
