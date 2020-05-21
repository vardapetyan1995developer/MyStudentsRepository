using StudentsRepositoryApp.Models;
using StudentsRepositoryApp.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRepositoryApp.DAL.Repositories
{
    public class StudentRepository : ICrud<StudentModel>, IReadable<StudentModel>
    {
        private IList<StudentModel> _context;

        public StudentRepository(IList<StudentModel> context)
        {
            _context = context;
        }

        //----------------------------------ICrud-------------------------------------

        public int Create(StudentModel source)
        {
            int result = 1;

            if (source != null)
            {
                _context.Add(source);
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            if (id != 0)
            {
                StudentModel currentStudent = _context.FirstOrDefault(student => student.Id == id);
                _context.Remove(currentStudent);

                result = true;
            }

            return result;
        }

        public int Edit(StudentModel source)
        {
            int result = 0;

            if (source != null)
            {
                int index = _context.IndexOf(_context.FirstOrDefault(student => student.Id == source.Id));

                _context[index].FirstName = source.FirstName;
                _context[index].LastName = source.LastName;
                _context[index].Age = source.Age;
            }

            return result;
        }

        //-----------------------------IReadable--------------------------------

        public StudentModel GetItem(int id)
        {
            return _context.FirstOrDefault(student => student.Id == id);
        }

        public IList<StudentModel> GetItems()
        {
            return _context;
        }
    }
}
