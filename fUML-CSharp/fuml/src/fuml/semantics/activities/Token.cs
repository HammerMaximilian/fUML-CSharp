using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public abstract class Token : FumlObject
    {
        public ActivityNodeActivation? holder = null;

        public Token Transfer( ActivityNodeActivation holder)
        {
            // if this token does not have any holder, make the given holder its
            // holder.
            // Otherwise, remove this token from its holder and return a copy of it
            // transfered to a new holder.

            Token token = this;
            if (this.holder is not null)
            {
                Withdraw();
                token = Copy();
            }

            token.holder = holder;
            return token;
        } // transfer

        public virtual void Withdraw()
        {
            // Remove this token from its holder, withdrawing any offers for it.

            if (!IsWithdrawn())
            {
                // Debug.println("[withdraw] Taking token with value = " +
                // this.getValue());
                holder?.RemoveToken(this);
                holder = null;
            }
        } // withdraw

        public abstract bool Equals(Token other);

        public abstract Token Copy();

        public bool IsWithdrawn()
        {
            // Test if this token has been withdrawn.

            return holder is null;
        } // isWithdrawn

        public abstract bool IsControl();

        public abstract Value GetValue();
    } // Token
}
