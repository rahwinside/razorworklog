using System;
using System.ComponentModel.DataAnnotations;

namespace RazorWorklog.Models
{
    public class Work
    {

        public int ID { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime WorkDate { get; set; }
        public decimal Hours { get; set; }

    }
}