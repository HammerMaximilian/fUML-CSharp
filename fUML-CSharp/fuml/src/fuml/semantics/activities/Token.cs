using fuml.semantics.values;

namespace fuml.semantics.activities
{
    public abstract class Token : FumlObject
    {
        public ActivityNodeActivation? holder = null;

        public Token transfer( ActivityNodeActivation holder)
        {
            // if this token does not have any holder, make the given holder its
            // holder.
            // Otherwise, remove this token from its holder and return a copy of it
            // transfered to a new holder.

            Token token = this;
            if (this.holder is not null)
            {
                withdraw();
                token = copy();
            }

            token.holder = holder;
            return token;
        } // transfer

        public virtual void withdraw()
        {
            // Remove this token from its holder, withdrawing any offers for it.

            if (!isWithdrawn())
            {
                // Debug.println("[withdraw] Taking token with value = " +
                // this.getValue());
                holder?.removeToken(this);
                holder = null;
            }
        } // withdraw

        public abstract bool equals(Token other);

        public abstract Token copy();

        public bool isWithdrawn()
        {
            // Test if this token has been withdrawn.

            return holder is null;
        } // isWithdrawn

        public abstract bool isControl();

        public abstract Value getValue();
    } // Token
}
