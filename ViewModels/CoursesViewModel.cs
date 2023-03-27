using System.Collections.Generic;
using vuvansang_2080600626.Models;

namespace vuvansang_2080600626.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}