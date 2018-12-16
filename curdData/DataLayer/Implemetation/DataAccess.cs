using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using curdData.DataLayer.Declaration;
using curdData.DataValue;

namespace curdData.DataLayer.Implemetation
{
    class DataAccess : IDataAccess
    {
        static List<Student> students = new List<Student>();


        public int delStudent(int id)
        {
            
            try
            {
                students.Remove(students.Where(x => x.ID == id).FirstOrDefault());
            }
            catch (Exception)
            {

                return -1;
            }
            return 1;
        }

        public Student GetStudent(int id)
        {
            return students.Where(x => x.ID == id).FirstOrDefault();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public int pushStudent(Student val)
        {
            try
            {
                students.Add(val);
            }
            catch (Exception)
            {

                return -1;
            }
            return 1;
        }

        public int putStudent(int id, Student val)
        {
            
            try
            {
                var stuRow = students.FirstOrDefault(x => x.ID == id);
                stuRow.Name = val.Name;
                stuRow.Marks = val.Marks;
                stuRow.state = val.state;
            }
            catch (Exception)
            {

                return -1;
            }
            return 1;
        }
    }
}
