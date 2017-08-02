namespace InterfacePass
{
    using System;

    internal class Factory
    {
        private string someField;

        public Factory()
        {
        }
        
        private interface ILectureResource
        {
            string Url { get; set; }

            string Username { get; set; }
        }

        public string Type { get; set; }

        // TODO: shiiiii
        private static void Main(string[] args)
        {
            var factory = new Factory();

            var rV = factory.FactoryResource("video", "VidRes", "vr:url", DateTime.Today);
            var rD = factory.FactoryResource("demo", "demo-res", "some demo:url", DateTime.Today.AddDays(2));

            // rV.
        }

        private ILectureResource FactoryResource(string type, string username, string url, DateTime date)
        {
            switch (type)
            {
                case "video": return new VideoResource(username, url, date);
                case "demo": return new DemoResource(username, url);
                default: throw new ArgumentException();
            }

            // ILectureResource lr;
            // switch (type)
            // {
            // case "video": lr = new VideoResource(username, url, date);
            // break;
            // case "demo": lr = new DemoResource(username,url);
            // break;
            // default: throw new ArgumentException();
            // }
            // return lr;
        }

        private class DemoResource : ILectureResource
        {
            public DemoResource(string username, string url)
            {
                this.Username = username;
                this.Url = url;
            }

            public string Url { get; set; }

            public string Username { get; set; }
        }

        private class VideoResource : ILectureResource
        {
            public VideoResource(string username, string url, DateTime date)
            {
                this.Username = username;
                this.Url = url;
                this.StartingDate = date;
            }

            public DateTime StartingDate { get; }

            public string Url { get; set; }

            public string Username { get; set; }
        }
    }
}