using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assertion
{
    public abstract class Student
    {
        public string Name;
        public int Mark;
    }

    public enum SortBy
    {
        ByName,
        ByMark
    }

    public abstract class ClassModel
    {
        public List<Student> ClassList = new List<Student>();

        //public abstract List<Student> GetStudentList();
        public List<Student> GetStudentList()
        {
            return ClassList;
        }


        internal class ConcreteStudent : Student
        {

        }

    }

        internal class ClassA : ClassModel
        {
            public ClassA()
            {
                ClassList.Add(new ConcreteStudent() { Name = "Narendra", Mark = 80 });
                ClassList.Add(new ConcreteStudent() { Name = "Subramanian", Mark = 50 });
            }

        }


        internal class ClassB : ClassModel
        {
            public ClassB()
            {
                ClassList.Add(new ConcreteStudent() { Name = "Salman", Mark = 60 });
                ClassList.Add(new ConcreteStudent() { Name = "Zaheer", Mark = 30 });
            }
        }

    

    class Model:IModel
    {
        public ClassModel clmModel;
        public List<Student> listStud = new List<Student>();
        public Model(ClassModel classSection)
        {
            listStud = classSection.GetStudentList();
        }
        


    }
}
