using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.StudentManagement.Models;

namespace Ex04.StudentManagement.Services
{
    public  class StudentService
    {
        private readonly List<Student> _students = new();
        private object student;

        public bool Add(Student student)
        {
            // Kiểm tra mã trùng 
            bool exist = _students.Any(
                s => s.StudentID.Equals(student.StudentID,
                StringComparison.OrdinalIgnoreCase));
            if (exist) return false;
            // Thêm sinh viên
            _students.Add(student);
            return true;
        }
        public IReadOnlyList<Student> GetAll()
        {
            return _students;
        }
        public Student? GetByID(string studentID)
        {
            //Tìm theo mã sv
            return _students.FirstOrDefault(
                s=>s.StudentID.Equals(studentID,StringComparison.OrdinalIgnoreCase)
                );
        }
        public List<Student> SearchByName(string keyword)
        {
            return _students
                .Where(x => x.FullName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public bool Delete(string studentID)
        {
            var studentToDelete = _students.FirstOrDefault(
            s => s.StudentID.Equals(studentID, StringComparison.OrdinalIgnoreCase));
            // xoá sinh viên 
            if (studentToDelete == null)
            {
                return false;
            }
            _students.Remove(studentToDelete);
            return true;
        }

    }
}
