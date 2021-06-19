using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab2.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string cover;

        public Book()
        {
        }
        public Book (int id, string title, string author, string cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.cover = cover;
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [Required(ErrorMessage="Tieu De Ko Dc Trong")]
        [StringLength(250,ErrorMessage ="Tieu De ko dc vuot qua 250")]
        [Display(Name ="Tieu De")]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Cover
        {
            get { return cover; }
            set { cover = value; }
        }
    }
}