using StudentsRepositoryApp.DAL.Repositories;
using StudentsRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudenstRepositoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<StudentModel> students = new List<StudentModel>();

            #region Adding students
            students.Add(new StudentModel(1, "Artak", "Vardanyan", 24));
            students.Add(new StudentModel(2, "Tigran", "Hakobyan", 28));
            students.Add(new StudentModel(3, "Menua", "Simonyan", 20));
            students.Add(new StudentModel(4, "Mariam", "Stepanyan", 18));
            #endregion

            #region Creating students repository
            StudentRepository studentRepository = new StudentRepository(students);
            #endregion

            #region Create()
            /*int createRes = studentRepository.Create(
                new StudentModel(1, "Adam", "Smith", 25)
            );

            int createRes1 = studentRepository.Create(
                new StudentModel(2, "Alex", "Gates", 35)
            );

            int createRes2 = studentRepository.Create(
                new StudentModel(3, "Mike", "Jameson", 20)
            );

            int createRes3 = studentRepository.Create(
                new StudentModel(4, "Stella", "Lopes", 18)
            );*/
            #endregion

            #region GetItem()
            try
            {
                Console.WriteLine("GetItem()");

                StudentModel student = studentRepository.GetItem(1);
                Console.WriteLine("Id: " + student.Id + ", FullName: " + student.FullName + ", Age: " + student.Age);

                Console.WriteLine(new string('*', 50));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

            #region Edit()
            Console.WriteLine("Edit()");

            int editRes = studentRepository.Edit(new StudentModel(2, "Manuk", "Hakobyan", 24));

            Console.WriteLine();

            Console.WriteLine(new string('*', 50));
            #endregion

            #region GetItems()
            Console.WriteLine("GetItems()");

            List<StudentModel> currentStudents = studentRepository.GetItems().ToList();

            foreach (var student in currentStudents)
            {
                Console.WriteLine("Id: " + student.Id + ", FullName: " + student.FullName + ", Age: " + student.Age);
            }

            Console.WriteLine(new string('*', 50));
            #endregion

            #region Delete()
            Console.WriteLine("Delete()");

            bool delRes = studentRepository.Delete(3);

            List<StudentModel> currentStudents1 = studentRepository.GetItems().ToList();

            foreach (var student in currentStudents1)
            {
                Console.WriteLine("Id: " + student.Id + ", FullName: " + student.FullName + ", Age: " + student.Age);
            }

            Console.WriteLine(new string('*', 50));
            #endregion



            Console.ReadKey();
        }
    }
}
