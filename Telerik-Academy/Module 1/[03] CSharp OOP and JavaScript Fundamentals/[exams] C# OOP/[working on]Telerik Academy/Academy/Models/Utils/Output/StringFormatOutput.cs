using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models.Utils.Output
{
    using Academy.Models.Contracts;
    using Academy.Models.Utils.Contracts;

    class StringFormatOutput
    {

        public static string CourseOutput(ICourse course)
        {
            var sb = new StringBuilder();
            sb.AppendLine("* Course:");
            sb.AppendLine($" - Name: {course.Name}");
            sb.AppendLine($" - Lectures per week: {course.LecturesPerWeek}");
            sb.AppendLine($" - Starting date: {course.StartingDate}");
            sb.AppendLine($" - Ending date: {course.EndingDate}");
            sb.AppendLine($" - Onsite students: {course.OnsiteStudents.Count}");
            sb.AppendLine($" - Online students: {course.OnlineStudents.Count}");
            sb.AppendLine(" - Lectures:");

            if (course.Lectures.Count == 0)
            {
                sb.AppendLine("  * There are no lectures in this course!");
            }
            else
            {
                foreach (var lecture in course.Lectures)
                {
                    sb.AppendLine(lecture.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static string CourseResultOutput(ICourseResult courseResult)
        {
            var sb = new StringBuilder();
            sb.AppendLine($" * {courseResult.Course.Name}: Points - {courseResult.CoursePoints}, Grade - {courseResult.Grade}");

            return sb.ToString().TrimEnd();
        }

        public static string LectureOutput(ILecture lecture)
        {
            var sb = new StringBuilder();
            sb.AppendLine("  * Lecture: ");
            sb.AppendLine($"   - Name: {lecture.Name}");
            sb.AppendLine($"   - Date: {lecture.Date}");
            sb.AppendLine($"   - Trainer username: {lecture.Trainer.Username}");
            sb.AppendLine("   - Resources:");

            if (lecture.Resources.Count == 0)
            {
                sb.AppendLine("    * There are no resources in this lecture.");
            }
            else
            {
                foreach (var lectureResource in lecture.Resources)
                {
                    sb.AppendLine(lectureResource.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string StudentOutput(IStudent student)
        {
            var sb = new StringBuilder();
            sb.AppendLine("* Student:");
            sb.AppendLine($" - Username: {student.Username}");
            sb.AppendLine($" - Track: {student.Track}");

            if (student.CourseResults.Count == 0)
            {
                sb.AppendLine("  * User has no course results!");
            }
            else
            {
                foreach (var courseResult in student.CourseResults)
                {
                    sb.AppendLine(courseResult.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public static string TrainerOutput(ITrainer trainer)
        {
            var sb = new StringBuilder();
            sb.AppendLine("* Trainer:");
            sb.AppendLine($" - Username: {trainer.Username}");

            sb.Append(" - Technologies:");
            foreach (var technology in trainer.Technologies)
            {
                sb.Append($" {technology};");
            }
            return sb.ToString().TrimEnd();
        }

        public static string ResourceOutput(ILectureResource lectureResource, params DateTime[] date)
        {
            var sb = new StringBuilder();
            sb.AppendLine("    * Resource: ");
            sb.AppendLine($"     - Name: {lectureResource.Name}");
            sb.AppendLine($"     - Url: {lectureResource.Url}");

            ////            string[] typeSequence = lectureResource.GetType().ToString().Split(new char[]{'.'},StringSplitOptions.RemoveEmptyEntries); 
            ////            string type = typeSequence[typeSequence.Length - 1];
            string type = lectureResource.GetType().Name;
            string shortType = type.Remove(type.IndexOf("Resource"));
            ////            string shortType = type.Replace("Resource","").TrimEnd();


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

