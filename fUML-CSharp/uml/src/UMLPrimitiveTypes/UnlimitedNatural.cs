namespace UMLPrimitiveTypes
{
    public class UnlimitedNatural
    {

        public int naturalValue = 0;

        /**
         * operation UnlimitedNatural
         */
        public UnlimitedNatural(int naturalValue)
        {
            this.naturalValue = naturalValue;
        } // UnlimitedNatural

        /**
         * operation UnlimitedNatural
         */
        public UnlimitedNatural()
        {
            naturalValue = 0;
        } // UnlimitedNatural

        public static bool operator==(UnlimitedNatural uN_1, UnlimitedNatural uN_2)
        {
            return uN_1.naturalValue == uN_2.naturalValue;
        }

        public static bool operator !=(UnlimitedNatural uN_1, UnlimitedNatural uN_2)
        {
            return uN_1.naturalValue != uN_2.naturalValue;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    } // UnlimitedNatural
}
