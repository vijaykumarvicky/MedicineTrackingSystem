using MedicineTrackingSystem.BusinessModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicineTrackingSystem.WebAPI
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

  
        public DbSet<Medicine> Medicines { get; set; }
    }
}
