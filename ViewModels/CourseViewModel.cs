using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vuvansang_2080600626.Models;

namespace vuvansang_2080600626.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date, Time));
        }
    }
}