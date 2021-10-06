using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1.Models
{
    public class Student
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string YearOfBirth { get; set; }
    }

    public class StudentManager
    {
        public static List<Student> GetStudents()
        {
            var students = new List<Student>();

            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Nam", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Hung", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Thach", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Quan", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Thang", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Long", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Huy", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Hieu", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Tuong", YearOfBirth = "29/5/2002" });
            students.Add(new Student { Image = "Assets/1.jpg", Name = "Nguyen Manh Hoang", YearOfBirth = "29/5/2002" });

            return students;
        }
    }
}
