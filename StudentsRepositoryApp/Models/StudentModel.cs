using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRepositoryApp.Models
{
    public partial class StudentModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    partial class StudentModel
    {
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }

    partial class StudentModel
    {
        public StudentModel(int id, string fName, string lName, int age)
        {
            Id = id;
            FirstName = fName;
            LastName = lName;
            Age = age;
        }
    }
}
