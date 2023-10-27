namespace fuml.semantics.activities
{
    public class JoinNodeActivation : ControlNodeActivation
    {
        public override bool isReady()
        {
            // Check that all incoming edges have sources that are offering tokens.

            bool ready = true;
            int i = 1;
            while (ready & i <= incomingEdges.Count)
            {
                ready = incomingEdges.ElementAt(i - 1).hasOffer();
                i++;
            }

            return ready;
        } // isReady
    } // JoinNodeActivation
}
