using fuml.semantics.loci;
using fuml.semantics.structuredclassifiers;
using fuml.syntax.activities;

namespace fuml.semantics.activities
{
    public abstract class ActivityNodeActivation : SemanticVisitor
    {
		public ActivityNodeActivationGroup? group = null;
		public ActivityNode? node = null;
		public List<ActivityEdgeInstance> incomingEdges = new();
		public List<ActivityEdgeInstance> outgoingEdges = new();
		public bool running = false;
		public List<Token> heldTokens = new();

		public virtual void Initialize(ActivityNode node, ActivityNodeActivationGroup group)
		{
			// Initialize this node activation.

			this.node = node;
			this.group = group;
			running = false;
		}

		public virtual void Run()
		{
			// Run the activation of this node.

			Debug.println(node is null ?
				"[run] Anonymous activation of type " + GetType().Name :
				"[run] node = " + node.name);

			running = true;
		} // run

		public virtual void ReceiveOffer()
		{
			// Receive an offer from an incoming edge.
			// Check if all prerequisites have been satisfied. If so, fire.

			Debug.println("[receiveOffer] " + (node is null ? "..." : "node = " + node.name));

			_beginIsolation();

			bool ready = IsReady();

			List<Token> tokens = new();
			if (ready)
			{
				Debug.println("[receiveOffer] Firing.");
				tokens = TakeOfferedTokens();
			}

			_endIsolation();

			if (ready)
			{
				Fire(tokens);
			}

		} // receiveOffer

		public virtual List<Token> TakeOfferedTokens()
		{
			// Get tokens from all incoming edges.

			List<Token> allTokens = new();
			List<ActivityEdgeInstance> incomingEdges = this.incomingEdges;
			foreach (ActivityEdgeInstance incomingEdge in incomingEdges)
			{
				List<Token> tokens = incomingEdge.TakeOfferedTokens();
				foreach (Token token in tokens)
				{
					allTokens.Add(token);
				}
			}

			return allTokens;
		} // takeOfferedTokens

		public abstract void Fire(List<Token> incomingTokens);

		public virtual void SendOffers(List<Token> tokens)
		{
			// Send offers for the given set of tokens over all outgoing edges (if
			// there are any tokens actually being offered).

			if (tokens.Count > 0)
			{

				// *** Send all outgoing offers concurrently. ***
				List<ActivityEdgeInstance> outgoingEdges = this.outgoingEdges;
				foreach (ActivityEdgeInstance outgoingEdge in outgoingEdges)
				{
					outgoingEdge.SendOffer(tokens);
				}

			}

		} // sendOffers

		public virtual void Terminate()
		{
			// Terminate the activation of this node.

			Debug.println(running, node is null ?
					"[terminate] Anonymous activation of type " + this.GetType().Name :
					"[terminate] node = " + node.name);

			running = false;
		} // terminate

		public virtual bool IsReady()
		{
			// Check if all the prerequisites for this node have been satisfied.
			// By default, check that this node is running.

			return IsRunning();

		} // isReady

		public bool IsRunning()
		{
			// Test whether this node activation is running.

			return running;
		} // isRunning

		public virtual void AddOutgoingEdge(ActivityEdgeInstance edge)
		{
			// Add an activity edge instance as an outgoing edge of this activity
			// node activation.

			edge.source = this;
			outgoingEdges.Add(edge);
		} // addOutgoingEdge

		public void AddIncomingEdge(
				ActivityEdgeInstance edge)
		{
			// Add an activity edge instance as an incoming edge of this activity
			// node activation.

			edge.target = this;
			incomingEdges.Add(edge);
		} // addIncomingEdge

		public virtual void CreateNodeActivations()
		{
			// Create node activations for any subnodes of the node for this
			// activation.
			// For most kinds of nodes, this does nothing.

			return;

		} // createNodeActivations

		public virtual void CreateEdgeInstances()
		{
			// Create edge instances for any edge instances owned by the node for
			// this activation.
			// For most kinds of nodes, this does nothing.

			return;

		} // createEdgeInstances

		public virtual bool IsSourceFor(ActivityEdgeInstance edgeInstance)
		{
			// Check if this node activation is the effective source for the given
			// edge instance.

			return edgeInstance.source == this;
		} // isSourceFor

		public ActivityExecution GetActivityExecution()
		{
			// Return the activity execution that contains this activity node
			// activation, directly or indirectly.

			return group?.GetActivityExecution()!;
		} // getActivityExecution

		public Object_ GetExecutionContext()
		{
			// Get the context object for the containing activity execution.

			return GetActivityExecution()?.context!;
		} // getExecutionContext

		public Locus GetExecutionLocus()
		{
			// Get the locus of the containing activity execution.

			return GetActivityExecution()?.locus!;
		} // getExecutionLocus

		public virtual ActivityNodeActivation GetNodeActivation(ActivityNode node)
		{
			// Get the activity node activation corresponding to the given activity
			// node, in the context of this activity node activation.
			// By default, return this activity node activation, if it is for the
			// given node, otherwise return nothing.

			ActivityNodeActivation? activation = null;
			if (node == this.node)
			{
				activation = this;
			}

			return activation!;
		} // getNodeActivation

		public virtual void AddToken(Token token)
		{
			// Transfer the given token to be held by this node.

			Debug.println("[addToken] " + (node is null ? "..." : "node = " + node.name));

			Token transferredToken = token.Transfer(this);
			heldTokens.Add(transferredToken);
		} // addToken

		public virtual int RemoveToken(Token token)
		{
			// Remove the given token, if it is held by this node activation.
			// Return the position (counting from 1) of the removed token (0 if
			// there is none removed).

			bool notFound = true;
			int i = 1;
			while (notFound & i <= heldTokens.Count)
			{
				if (heldTokens.ElementAt(i - 1) == token)
				{
					Debug.println("[removeToken] " + (node is null ? "..." : "node = " + node.name));
					heldTokens.RemoveAt(i - 1);
					notFound = false;
				}
				i++;
			}

			if (notFound)
			{
				i = 0;
			}
			else
			{
				i--;
			}

			return i;
		} // removeToken

		public void AddTokens(List<Token> tokens)
		{
			// Transfer the given tokens to be the held tokens for this node.

			foreach (Token token in tokens)
			{
				AddToken(token);
			}
		} // addTokens

		public List<Token> TakeTokens()
		{
			// Take the tokens held by this node activation.

			List<Token> tokens = GetTokens();
			ClearTokens();

			return tokens;
		} // takeTokens

		public virtual void ClearTokens()
		{
			// Remove all held tokens.

			while (heldTokens.Count > 0)
			{
				heldTokens.ElementAt(0).Withdraw();
			}

		} // clearTokens

		public List<Token> GetTokens()
		{
			// Get the tokens held by this node activation.

			// Debug.println("[getTokens] node = " + this.node.name);

			List<Token> tokens = new();
			List<Token> heldTokens = this.heldTokens;
			foreach (Token heldToken in heldTokens)
			{
				tokens.Add(heldToken);
			}

			return tokens;
		} // getTokens

		public void Suspend()
		{
			// Suspend this activation within the activation group that contains it.

			group?.Suspend(this);
		} // suspend

		public virtual void Resume()
		{
			// Resume this activation within the activation group that contains it.

			group?.Resume(this);
		} // resume
	} // ActivityNodeActivation
}
