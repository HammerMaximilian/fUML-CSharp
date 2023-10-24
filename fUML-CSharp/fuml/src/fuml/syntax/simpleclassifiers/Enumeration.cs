namespace fuml.syntax.simpleclassifiers
{
    public class Enumeration : DataType
    {
        public List<EnumerationLiteral> ownedLiteral = new();

        public void addOwnedLiteral(
                EnumerationLiteral ownedLiteral)
        {
            if (ownedLiteral is null)
            {
                throw new ArgumentNullException(nameof(ownedLiteral));
            }

            addOwnedMember(ownedLiteral);

            this.ownedLiteral.Add(ownedLiteral);
            ownedLiteral._setEnumeration(this);
        } // addOwnedLiteral
    } // Enumeration
}
