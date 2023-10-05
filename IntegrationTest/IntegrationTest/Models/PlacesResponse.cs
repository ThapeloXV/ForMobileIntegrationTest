using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTest.Models
{
   public class PlacesResponse
    {
            public string placeId { get; set; }
            public string description { get; set; }
            public string mainText { get; set; }
            public string secondaryText { get; set; }
            public List<Term> terms { get; set; }
            public List<int> types { get; set; }
    }
     public class Root
    {
        public PlacesResponse PlacesResponse { get; set; }
        public IList<PlacesResponse> Data { get; set; }
    }

     public class Term
    {
        public Root root { get; set; }
        public string value { get; set; }
        public string offset { get; set; }
    }

}
