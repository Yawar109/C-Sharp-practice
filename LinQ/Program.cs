using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Person
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public dynamic CourseId { get; set; }
        public string CourseName { get; set; }
        public int MarksObtained { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
    internal class Program
    {

        static void Main()
        {
            List<Person> Result = new List<Person> 
            { 
            new Person { StudentID = 01, StudentName = "Ali", CourseId = "CS001", CourseName = "Computer Science", EnrollmentDate = new DateTime(2024, 1, 15), MarksObtained = 78 },
            new Person { StudentID = 02, StudentName = "Sara", CourseId = "CS002", CourseName = "Data Structures", EnrollmentDate = new DateTime(2024, 1, 16), MarksObtained = 78},
            new Person { StudentID = 04, StudentName = "Zara", CourseId = "CS004", CourseName = "Artificial Intelligence", EnrollmentDate = new DateTime(2024, 1, 18) , MarksObtained = 78},
            new Person { StudentID = 05, StudentName = "Bilal", CourseId = "CS005", CourseName = "Machine Learning", EnrollmentDate = new DateTime(2024, 1, 19) , MarksObtained = 78},
            new Person { StudentID = 06, StudentName = "Fatima", CourseId = "CS006", CourseName = "Natural Language Processing", EnrollmentDate = new DateTime(2024, 1, 20) , MarksObtained = 78},
            new Person { StudentID = 07, StudentName = "Usman", CourseId = "CS007", CourseName = "Operating Systems", EnrollmentDate = new DateTime(2024, 1, 21) , MarksObtained = 78},
            new Person { StudentID = 08, StudentName = "Noor", CourseId = "CS008", CourseName = "Networking", EnrollmentDate = new DateTime(2024, 1, 22) , MarksObtained = 78},
            new Person { StudentID = 09, StudentName = "Khan", CourseId = "CS009", CourseName = "Cybersecurity", EnrollmentDate = new DateTime(2024, 1, 23) , MarksObtained = 78},
            new Person { StudentID = 10, StudentName = "Hassan", CourseId = "CS010", CourseName = "Software Engineering", EnrollmentDate = new DateTime(2024, 1, 24) , MarksObtained = 78},
            new Person { StudentID = 11, StudentName = "Ayesha", CourseId = "CS011", CourseName = "Natural Language Processing", EnrollmentDate = new DateTime(2024, 1, 25) , MarksObtained = 78},
            new Person { StudentID = 12, StudentName = "Hamza", CourseId = "CS012", CourseName = "Web Development", EnrollmentDate = new DateTime(2024, 1, 26) , MarksObtained = 38},
            new Person { StudentID = 13, StudentName = "Laila", CourseId = "CS013", CourseName = "Natural Language Processing", EnrollmentDate = new DateTime(2024, 1, 27) , MarksObtained = 12},
            new Person { StudentID = 14, StudentName = "Aliya", CourseId = "CS014", CourseName = "Cloud Computing", EnrollmentDate = new DateTime(2024, 1, 28) , MarksObtained = 46},
            new Person { StudentID = 15, StudentName = "Arman", CourseId = "CS015", CourseName = "Big Data Analytics", EnrollmentDate = new DateTime(2024, 1, 29) , MarksObtained = 28},
            new Person { StudentID = 16, StudentName = "Maya", CourseId = "CS016", CourseName = "Natural Language Processing", EnrollmentDate = new DateTime(2024, 1, 30) , MarksObtained = 23},
            new Person { StudentID = 17, StudentName = "Raza", CourseId = "CS017", CourseName = "Natural Language Processing", EnrollmentDate = new DateTime(2024, 1, 31) , MarksObtained = 56},
            new Person { StudentID = 18, StudentName = "Anaya", CourseId = "CS018", CourseName = "Augmented Reality", EnrollmentDate = new DateTime(2024, 2, 1), MarksObtained = 39},
            new Person { StudentID = 19, StudentName = "Hiba", CourseId = "CS019", CourseName = "Virtual Reality", EnrollmentDate = new DateTime(2024, 2, 2), MarksObtained = 64 },
            new Person { StudentID = 20, StudentName = "Danish", CourseId = "CS020", CourseName = "UI/UX Design", EnrollmentDate = new DateTime(2024, 2, 3), MarksObtained = 89 },
            new Person { StudentID = 21, StudentName = "Rohan", CourseId = "CS021", CourseName = "Natural Language Processing", EnrollmentDate = new DateTime(2024, 2, 4), MarksObtained = 45},
            new Person { StudentID = 22, StudentName = "Erum", CourseId = "CS022", CourseName = "Information Security", EnrollmentDate = new DateTime(2024, 2, 5), MarksObtained = 56 },
            new Person { StudentID = 23, StudentName = "Saad", CourseId = "CS023", CourseName = "Cryptography", EnrollmentDate = new DateTime(2024, 2, 6), MarksObtained = 69 },
            new Person { StudentID = 24, StudentName = "Tariq", CourseId = "CS024", CourseName = "DevOps Engineering", EnrollmentDate = new DateTime(2024, 2, 7), MarksObtained = 79 },
            new Person { StudentID = 25, StudentName = "Uzma", CourseId = "CS025", CourseName = "Robotics", EnrollmentDate = new DateTime(2024, 2, 8), MarksObtained = 50 },
            new Person { StudentID = 26, StudentName = "Omer", CourseId = "CS026", CourseName = "Embedded Systems", EnrollmentDate = new DateTime(2024, 2, 9), MarksObtained = 79 },
            new Person { StudentID = 27, StudentName = "Meera", CourseId = "CS027", CourseName = "Digital Signal Processing", EnrollmentDate = new DateTime(2024, 2, 10) , MarksObtained = 99},
            new Person { StudentID = 28, StudentName = "Zubair", CourseId = "CS028", CourseName = "Software Testing", EnrollmentDate = new DateTime(2024, 2, 11) , MarksObtained = 39},
            new Person { StudentID = 29, StudentName = "Kamran", CourseId = "CS029", CourseName = "Computer Vision", EnrollmentDate = new DateTime(2024, 2, 12) , MarksObtained = 59},
            new Person { StudentID = 30, StudentName = "Fahad", CourseId = "CS030", CourseName = "Natural Language Processing", EnrollmentDate = new DateTime(2024, 2, 13) , MarksObtained = 50}
            };

            var students = Result.Where(i => i.CourseName == "Natural Language Processing" ).ToList();

            students.ForEach(x => Console.WriteLine($"StudentID: {x.StudentID}, StudentName: {x.StudentName}, CourseName: {x.CourseName}, Date: {x.}"));


        }

    }

    
}
