using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorWorklog.Models;

    public class WorkContext : DbContext
    {
        public WorkContext (DbContextOptions<WorkContext> options)
            : base(options)
        {
        }

        public DbSet<RazorWorklog.Models.Work> Work { get; set; }
    }
