using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UniversityManagement.Models
{
    public class UniversityModifier
    {
    }



    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {


    }

    public class DepartmentMetaData
    {
        [DisplayName("Department Name")]
        public int Id { get; set; }
        [DisplayName("Department Name")]
        [Required]
        public string DepartmentName { get; set; }
        [DisplayName("Department Code")]
        [Required]
        public string DepartmentCode { get; set; }
    }
    [MetadataType(typeof(SemisterMetadata))]
    public partial class Semister
    {

    }

    public class SemisterMetadata
    {
        [DisplayName("Semister Name")]
        public int Id { get; set; }
        [DisplayName("Semister Name")]
        [Required]
        public string SemisterName { get; set; }
    }
    [MetadataType(typeof(CourseMetadata))]
    public partial class Course
    {

    }

    public class CourseMetadata
    {
        [DisplayName("Course Code")]
        [Required]
        public string CourseCode { get; set; }
        [DisplayName("Course Name")]
        [Required]
        public string CourseName { get; set; }
        [DisplayName("Course Credit")]
        [Required]
        public int CourseCredit { get; set; }
        [DisplayName("Course Details")]
        public string CourseDetails { get; set; }
        [DisplayName("Department Name")]
        [Required]
        public int DepartmentId { get; set; }
        [DisplayName("Semester Name")]
        [Required]
        public int SemisterId { get; set; }
    }
    [MetadataType(typeof(TeacherMetadata))]
    public partial class Teacher
    {

    }

    public class TeacherMetadata
    {
        [DisplayName("Teacher Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [DisplayName("Email Address")]
        [Required]
        public string email { get; set; }
        [DisplayName("Contact Number")]
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public int Credit { get; set; }
        [Required]
        public int DesignationId { get; set; }
        [Required]
        public int DepartmentId { get; set; }
    }
}