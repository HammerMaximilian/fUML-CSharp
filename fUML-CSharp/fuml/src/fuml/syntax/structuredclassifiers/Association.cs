using fuml.syntax.classification;
using fuml.syntax.commonstructure;
using System;

namespace fuml.syntax.structuredclassifiers
{
    public class Association : Classifier
    {
        public bool isDerived = false;
        public List<Property> ownedEnd = new();
        public List<commonstructure.Type> endType = new();
        public List<Property> memberEnd = new();
        public List<Property> navigableOwnedEnd = new();

        public void addOwnedEnd(Property ownedEnd)
        {
            if (ownedEnd is null)
            {
                throw new ArgumentNullException(nameof(ownedEnd));
            }

            addFeature(ownedEnd);
            addOwnedMember(ownedEnd);

            this.ownedEnd.Add(ownedEnd);
            ownedEnd._setOwningAssociation(this);

            _addMemberEnd(ownedEnd);
        } // addOwnedEnd

        public void addNavigableOwnedEnd(
                Property navigableOwnedEnd)
        {
            if (navigableOwnedEnd is null)
            {
                throw new ArgumentNullException(nameof(navigableOwnedEnd));
            }
            // Note: A navigable end must also be set as an owned end using
            // setOwnedEnd.

            this.navigableOwnedEnd.Add(navigableOwnedEnd);
        } // addNavigableOwnedEnd

        public void addMemberEnd(Property memberEnd)
        {
            if (memberEnd is null)
            {
                throw new ArgumentNullException(nameof(memberEnd));
            }
            // Note: This operation should not be used for owned ends. The
            // operation addOwnedEnd should be used instead.

            addMember(memberEnd);
            _addMemberEnd(memberEnd);
        }

        protected void _addMemberEnd(Property memberEnd)
        {
            if (memberEnd is null)
            {
                throw new ArgumentNullException(nameof(memberEnd));
            }

            this.memberEnd.Add(memberEnd);
            memberEnd._setAssociation(this);

            if (memberEnd.typedElement.type is not null)
            {
                endType.Add(memberEnd.typedElement.type);
            }

            if (this.memberEnd.Count() == 2)
            {
                Property opposite = this.memberEnd.ElementAt(0);
                memberEnd._setOpposite(opposite);
                opposite._setOpposite(memberEnd);
            }
            else if (this.memberEnd.Count() > 2)
            {
                foreach (Property end in this.memberEnd)
                {
                    end._setOpposite(null!);
                }
            }

        }
    } // Association
}
