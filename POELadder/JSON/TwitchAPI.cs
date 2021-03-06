﻿
namespace POELadder.JSON
{
    public class Links
    {
        public string channel { get; set; }
        public string self { get; set; }
    }

    public class Preview
    {
        public string medium { get; set; }
        public string small { get; set; }
        public string large { get; set; }
        public string template { get; set; }
    }

    public class Links2
    {
        public string self { get; set; }
    }

    public class Links3
    {
        public string videos { get; set; }
        public string teams { get; set; }
        public string stream_key { get; set; }
        public string follows { get; set; }
        public string editors { get; set; }
        public string chat { get; set; }
        public string subscriptions { get; set; }
        public string self { get; set; }
        public string features { get; set; }
        public string commercial { get; set; }
    }

    public class Channel
    {
        public string url { get; set; }
        public string background { get; set; }
        public int delay { get; set; }
        public string game { get; set; }
        public string status { get; set; }
        public string display_name { get; set; }
        public Links3 _links { get; set; }
        public string updated_at { get; set; }
        public int _id { get; set; }
        public object profile_banner { get; set; }
        public string banner { get; set; }
        public string created_at { get; set; }
        public string name { get; set; }
        public object mature { get; set; }
        public string video_banner { get; set; }
        public string logo { get; set; }
    }

    public class Stream
    {
        public string game { get; set; }
        public Preview preview { get; set; }
        public Links2 _links { get; set; }
        public long _id { get; set; }
        public int viewers { get; set; }
        public Channel channel { get; set; }
    }

    public class TwitchAPI
    {
        public Links _links { get; set; }
        public Stream stream { get; set; }
    }
}
