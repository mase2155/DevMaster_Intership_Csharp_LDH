using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.StudentManagement.Enums;

namespace Ex04.StudentManagement.Models
{
    public class Student
    {
        public string StudentID { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;
        public double GPA { get; set; }
        public StudentStatus Status { get; set; }
    }
}
