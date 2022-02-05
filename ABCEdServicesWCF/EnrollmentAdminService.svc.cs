using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ABCEdServicesWCF.model;

namespace ABCEdServicesWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EnrollmentAdminService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EnrollmentAdminService.svc or EnrollmentAdminService.svc.cs at the Solution Explorer and start debugging.
    public class EnrollmentAdminService : IEnrollmentAdminService
    {
        public TafeDBEntities2 db = new TafeDBEntities2();

        public string StudentID { get; set; }
        [DataMember]
        public string CourseID { get; set; }
        [DataMember]
        public string Grade { get; set; }

        // Enrol Student from the Web Service --------------------------------------------------------------------------------------
        public int Enroll(string courseID, string studentID)
        {
            Enrollment e = new Enrollment { StudentID = studentID, CourseID = courseID };
            db.Enrollments.Add(e);
            return db.SaveChanges();
        }

        // Get Enrollments from Web Service --------------------------------------------------------------------------------------
        public List<EnrollmentVO> GetEnrollmentsForStudent(string studentID)
        {
            List<EnrollmentVO> enrollments_VO = new List<EnrollmentVO>();
            var enrollments = db.Enrollments.Where( e => e.StudentID == studentID).ToList();
            
            foreach (var student in enrollments)
            {
                enrollments_VO.Add(new EnrollmentVO {StudentID = student.StudentID, CourseID = student.CourseID, Grade = student.Grade });
            }
            return enrollments_VO;
        }

        // Get Students Enrolled from a Particular Course from Web Service --------------------------------------------------------------------------------------
        public List<StudentVO> GetStudentsEnrolledInCourse(string courseID)
        {
            List<StudentVO> students_vo = new List<StudentVO>();
            var enrollments = db.Enrollments.Where(e => e.CourseID == courseID).ToList();

            foreach (var e in enrollments)
            {
                var student = db.Students.First(s => s.StudentID == e.StudentID);
                students_vo.Add(new StudentVO { StudentID = student.StudentID, StudentName = student.StduentName, DateEnrolled = student.DateEnrolled });
            }
            return students_vo;
        }


        public int InsertCourse(string id, string name, decimal cost)
        {
            Course c = new Course { CourseID = id, CourseName = name, Cost = cost };
            db.Courses.Add(c);
            return db.SaveChanges();
        }

        public int InsertStudent(string id, string name, DateTime dateEnrolled)
        {
            Student s = new Student { StudentID = id, StduentName = name, DateEnrolled = dateEnrolled };
            db.Students.Add(s);
            return db.SaveChanges();
        }

        public List<CourseVO> ViewCourses()
        {
            var course_vo_list = new List<CourseVO>();
            var courses = db.Courses.ToList();
            foreach (var c in courses)
            {
                course_vo_list.Add(new CourseVO
                {
                    CourseID = c.CourseID,
                    CourseName = c.CourseName,
                    Cost = c.Cost
                });
            }
            return course_vo_list;
        }

        public List<StudentVO> ViewStudents()
        {
            var student_vo_list = new List<StudentVO>();
            var students = db.Students.ToList();
            foreach (var s in students)
            {
                student_vo_list.Add(new StudentVO
                {
                    StudentID = s.StudentID,
                    StudentName = s.StduentName,
                    DateEnrolled = s.DateEnrolled
                });
            }
            return student_vo_list;

        }

    }
}
