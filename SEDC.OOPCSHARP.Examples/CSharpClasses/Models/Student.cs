﻿namespace CSharpClasses.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public string Academy { get; set; }
        public Student(string name, string group, string academy)
        {
            Name = name;
            Group = group;
            Academy = academy;
        }
    }
}
