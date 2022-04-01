using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDevelopment.Data
{
    class DesktopAppDevDbContext : DbContext
    {
        public DesktopAppDevDbContext() : base()
        {

        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Major> Majors { get; set; }

    }
}
