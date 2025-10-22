using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltinInterfaces
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public int CompareTo(Student? other)
        {
            if (this.Score > other?.Score)
            {
                return 1;
            }
            else if (this.Score < other?.Score) { 
                return -1;
            }
            return 0;
        }
    }

    public class ClassRoom : IEnumerable<Student>
    {
        public int Id { get; set; }
        private List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public void AddRange(IEnumerable<Student> studentCollection)
        {
            students.AddRange(studentCollection);
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }
        public List<Student> GetStudents()
        {
            return students;
        }

        public void SortStudents()
        {
            students.Sort();
           
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                yield return student;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
