namespace uml.simpleclassifiers
{
    public class Enumeration : DataType
    {
        public List<EnumerationLiteral> ownedLiteral = new();

        public void AddOwnedLiteral(
                EnumerationLiteral ownedLiteral)
        {
            if (ownedLiteral is null)
            {
                throw new ArgumentNullException(nameof(ownedLiteral));
            }

            AddOwnedMember(ownedLiteral);

            this.ownedLiteral.Add(ownedLiteral);
            ownedLiteral._setEnumeration(this);
        } // addOwnedLiteral
    } // Enumeration
}
