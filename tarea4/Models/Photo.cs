using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace tarea4.Models
{
    public class Photo
    {
        [PrimaryKey, AutoIncrement]
        public int code { get; set; }

        [MaxLength(100)]
        public String name { get; set; }

        [MaxLength(255)]
        public String description { get; set; }

        public String pathFile { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}