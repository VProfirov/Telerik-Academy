using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using Academy.Models.Utils.Contracts;
using System;

namespace Academy.Core.Factories
{
    using System.Linq;

    using Academy.Models.Curriculum;
    using Academy.Models.Resources;
    using Academy.Models.Users;
    using static Academy.Models.Utils.Validation.CurriculumValidator;

    public class AcademyFactory : IAcademyFactory
    {
        private static IAcademyFactory instanceHolder = new AcademyFactory();

        // private because of Singleton design pattern
        private AcademyFactory()
        {
        }

        public static IAcademyFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        public ISeason CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Initiative parsedInitiativeAsEnum;
            Enum.TryParse<Initiative>(initiative, out parsedInitiativeAsEnum);

            return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public IStudent CreateStudent(string username, string track)
        {
            Track parsedTrackAsEnum;
            Enum.TryParse<Track>(track, out parsedTrackAsEnum);
            
            return new Student(username, parsedTrackAsEnum);
        }

        public ITrainer CreateTrainer(string username, string technologies)
        {
            var parsedTechnologies = technologies.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            return new Trainer(username, parsedTechnologies);
        }

        public ICourse CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            var parsedLecturesPerWeek = int.Parse(lecturesPerWeek);
            var parsedStartingDate = DateTime.Parse(startingDate);

////        Validation at object lvl VS factory lvl ?
            return new Course(name, parsedLecturesPerWeek, parsedStartingDate);
        }

        public ILecture CreateLecture(string name, string date, ITrainer trainer)
        {
            var parsedDate = DateTime.Parse(date);

            return new Lecture(name, parsedDate, trainer);
        }

        public ILectureResource CreateLectureResource(string type, string name, string url)
        {
            // Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;
            ILectureResource lectureResource;
            switch (type)
            {
                case "video": lectureResource = new VideoResource(name, url, currentDate); break;
                case "presentation": lectureResource = new PresentationResource(name, url); break;
                case "demo": lectureResource = new DemoResource(name, url); break;
                case "homework": lectureResource = new HomeworkResource(name, url, currentDate.AddDays(7)); break;
                default: throw new ArgumentException("Invalid lecture resource type");
            }

            return lectureResource;
        }

        public ICourseResult CreateCourseResult(ICourse course, string examPoints, string coursePoints)
        {
            var parsedExamPoints = float.Parse(examPoints);
            var parsedCoursePoints = float.Parse(coursePoints);
            return new CourseResult(course, parsedExamPoints, parsedCoursePoints);
        }
    }
}
