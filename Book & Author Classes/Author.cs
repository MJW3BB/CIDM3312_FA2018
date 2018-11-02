using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidtermExam1
{
    public class Author
    {
        public string AuthorFirstName {get; set;}
        public string AuthorLastName {get; set;}


        // Override string to provide Author data
        public override string ToString() => $"{AuthorID} - {AuthorFirstName + AuthorLastName}";
    }
}