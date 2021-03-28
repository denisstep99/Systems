using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DataBindingDemo
{
    public class StudentList : ObservableCollection<Student>
    {

    }

    public class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }
    }
}
