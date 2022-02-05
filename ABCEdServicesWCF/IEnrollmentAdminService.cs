using ABCEdServicesWCF.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ABCEdServicesWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEnrollmentAdminService" in both code and config file together.
    [ServiceContract]
    public interface IEnrollmentAdminService
    {
        [OperationContract]
        int InsertStudent(string id, string name, DateTime dateEnrolled);

        [OperationContract]
        int InsertCourse(string id, string name, Decimal cost);

        [OperationContract]
        List<StudentVO>ViewStudents();

        [OperationContract]
        List<CourseVO>ViewCourses();

        [OperationContract]
        int Enroll(String courseID, String studentID);

        [OperationContract]
        List<EnrollmentVO> GetEnrollmentsForStudent(string studentID);

        [OperationContract]
        List<StudentVO> GetStudentsEnrolledInCourse(String courseID);


    }
}
