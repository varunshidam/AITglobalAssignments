
using System;

namespace PropertyRental1
{
    [Serializable]
    public class PropertyListing
    {
        private Property[] prop = new Property[100];

        public Property this[int i]
        {
            get { return prop[i]; }
            set { prop[i] = value; }
        }
    }
}