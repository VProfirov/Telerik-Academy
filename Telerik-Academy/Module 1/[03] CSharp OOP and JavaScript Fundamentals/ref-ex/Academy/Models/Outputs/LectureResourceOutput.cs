using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Models.Outputs
{
    class LectureResourceOutput
    {
        public static string ResourceOutput(ILectureResouce lectureResouce, params DateTime[] date)
        {
            var sb = new StringBuilder();
            sb.AppendLine("    * Resource: ");
            sb.AppendLine($"     - Name: {lectureResouce.Name}");
            sb.AppendLine($"     - Url: {lectureResouce.Url}");

            string type = lectureResouce.GetType().ToString();
            string shortType = type.Remove(type.IndexOf("Resource", StringComparison.Ordinal));
            sb.AppendLine($"     - Type: {shortType}");

            switch (type)
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
