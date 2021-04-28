using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAB23_DATABASE.Models
{
    public class MovieModel
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public double RunTime { get; set; }
        [MaxLength(50)]
        public string Genre  { get; set; }


      
        public MovieModel(string title, string genre, int id, double runtime)
        {
            Title = title;
            Genre = genre;
            ID = id;
            RunTime = runtime;
        }

        public MovieModel()
        {
        }
    }
}
