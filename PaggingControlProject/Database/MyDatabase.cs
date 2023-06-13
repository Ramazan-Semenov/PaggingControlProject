using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaggingControlProject.Database
{
    public class MyDatabase : IPageControlContract
    {
        List<Student> studentList = new List<Student>();

        public MyDatabase()
        {
            Student studentObj;
            Random randomObj = new Random();

            for (int i = 0; i < 1000; i++)
            {
                studentObj = new Student();
                studentObj.FirstName = "First " + i;
                studentObj.MiddleName = "Middle " + i;
                studentObj.LastName = "Last " + i;
                studentObj.Age = (uint)randomObj.Next(1, 100);

                studentList.Add(studentObj);
            }
        }

        #region IPageControlContract Members

        public uint GetTotalCount()
        {
            return (uint)studentList.Count;
        }

        public ICollection<object> GetRecordsBy(uint StartingIndex, uint NumberOfRecords, object FilterTag)
        {
            if (StartingIndex >= studentList.Count)
            {
                return new List<object>();
            }

            List<Student> result = new List<Student>();

            for (int i = (int)StartingIndex; i < studentList.Count && i < StartingIndex + NumberOfRecords; i++)
            {
                result.Add(studentList[i]);
            }

            return result.ToList<object>();
        }

        #endregion
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }

        public override string ToString()
        {
            return FirstName + "." + MiddleName + "." + LastName + " (" + Age + ")";
        }
    }
}
