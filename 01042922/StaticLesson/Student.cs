using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLesson
{
    internal class Student
    {
        public Student()
        {
            TotalCount++;
            No = TotalCount;
        }
        public static int TotalCount { get; set; }
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public int No { get; set; }
    }
}
