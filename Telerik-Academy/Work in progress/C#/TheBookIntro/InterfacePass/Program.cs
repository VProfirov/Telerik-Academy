using System;

namespace InterfacePass
{
    class Factory
    {
        static void Main(string[] args)
        {
            var factory = new Factory();
            var rV = factory.FactoryResource("video", "VidRes", "vr:url", DateTime.Today);
            var rD = factory.FactoryResource("demo", "demo-res", "some demo:url", DateTime.Today.AddDays(2));

//            rV.
        }

        ILectureResource FactoryResource(string type, string username, string url, DateTime date)
        {
            switch (type)
            {
                case "video":
                    return new VideoResource(username, url, date);
                case "demo":
                    return new DemoResource(username, url);
                default: throw new ArgumentException();
            }
            //            ILectureResource lr;
            //            switch (type)
            //            {
            //                case "video": lr = new VideoResource(username, url, date);
            //                    break;
            //                case "demo": lr = new DemoResource(username,url);
            //                    break;
            //                default: throw new ArgumentException();
            //            }
            //
            //            return lr;
        }

        interface ILectureResource
        {
            string Username { get; set; }

            string Url { get; set; }
        }

        class VideoResource : ILectureResource
        {
            public VideoResource(string username, string url, DateTime date)
            {
                Username = username;
                Url = url;
                StartingDate = date;
            }
            public string Username { get; set; }

            public string Url { get; set; }

            public DateTime StartingDate { get; }

        }

        class DemoResource : ILectureResource
        {
            public DemoResource(string username, string url)
            {
                Username = username;
                Url = url;
            }
            public string Username { get; set; }

            public string Url { get; set; }
        }
    }
}