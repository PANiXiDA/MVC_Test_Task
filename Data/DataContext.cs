﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Status> Statuses { get; set; } = null!;
        public DbSet<Task_> Tasks { get; set; } = null!; 
    }
}
