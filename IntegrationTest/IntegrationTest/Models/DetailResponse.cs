using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTest.Models
{
    public class DetailResponse
    {
        public string shortName { get; set; }
        public string longName { get; set; }
        public IList<int> types { get; set; }
    }

    public class DetailRoot
    {
        public IList<DetailResponse> addressComponents { get; set; }
        public string formattedAddress { get; set; }
        public string url { get; set; }
        public int utcOffset { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string name { get; set; }
        public List<Photo> photos { get; set; }
        public string placeId { get; set; }
        public List<int> types { get; set; }
        public string vicinity { get; set; }
    }

    public class Meta
    {
        public string message { get; set; }
    }

    public class Photo
    {
        public string photoId { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Root2
    {
        public DetailRoot data { get; set; }
        public Meta meta { get; set; }
    }
}
