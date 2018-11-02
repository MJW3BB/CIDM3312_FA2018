using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidtermExam1
{
    public class Book
    {
        public int BookID {get; set;} // Primary Key
        public string BookName {get; set;}
        public string BookPublisher {get; set;}
        public string BookPublishDate {get; set;}
        public int BookPageCount {get; set;}

        public Author AuthorID {get; set;}
        public Author AuthorFirstName {get; set;}
        public Author AuthorLastName {get; set;}
        public ICollectBookInfo<Author> Authors {get; set;} // Foreign Key

        public override string ToString() => $"{BookID} - {BookName}"; // Required override string to provide book data. 

    }
}