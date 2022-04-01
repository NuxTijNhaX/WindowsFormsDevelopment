using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDevelopment.Data
{
    class Lecturer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsVisiting { get; set; }

        public string FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}
