using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Models.Outputs
{
    class LectureResourceOutput
    {
        public static string ResourceOutput(ILectureResource lectureResource, params DateTime[] date)
        {
            var sb = new StringBuilder();
            sb.AppendLine("    * Resource: ");
            sb.AppendLine($"     - Name: {lectureResource.Name}");
            sb.AppendLine($"     - Url: {lectureResource.Url}");

            //            string[] typeSequence = lectureResource.GetType().ToString().Split(new char[]{'.'},StringSplitOptions.RemoveEmptyEntries); 
            //            string type = typeSequence[typeSequence.Length - 1];
            string type = lectureResource.GetType().Name;
            string shortType = type.Remove(type.IndexOf("Resource"));
//            string shortType = type.Replace("Resource","").TrimEnd();


            sb.AppendLine($"     - Type: {shortType}");

            switch (shortType)
            {
                case "Video":
                    sb.AppendLine($"     - Uploaded on: {date[0]}");
                    break;
                case "Homework":
                    sb.AppendLine($"     - Due date: {date[0]}");
                    break;
            }

            return sb.ToString().TrimEnd();
        }
    }
}
