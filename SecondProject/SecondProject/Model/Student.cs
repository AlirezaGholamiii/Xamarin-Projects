using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace SecondProject.Model
{
    //Students can have id, name and each student can have several comments
    //comments also have id, title and description
    public class Student
    {
        public int Id { get; set; }
        public object Name { get; set; }
        public string Photo { get; set; }
        public List<Comment> comments { get; set; }
    }

    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    }
}
