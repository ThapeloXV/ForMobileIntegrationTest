using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTest.Assets.Helpers
{
    class Constants
    {
        //Search url
        public const string PLACES_SEARCH = "https://staging.api.eos.kerridgecs.online/location/api/v1/locations/places?criteria={0}";
        public const string PLACES_DETAIL_SEARCH = "https://staging.api.eos.kerridgecs.online/location/api/v1/locations/places/{0}";

        //Authentcation url
        public const string AUTH_URL = "https://staging.identity.eos.kerridgecs.online/connect/token";
        public const string CLIENT_ID = "94eb850d-448f-48ef-a085-5fee4807606e.apps.kerridgecs.com";
        public const string CLIENT_SECRET = "b609f130-2d13-43d4-93df-f8ab9f1cafde";
    }
}
