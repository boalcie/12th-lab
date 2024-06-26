﻿using Microsoft.EntityFrameworkCore;
using WebApiASPNET.Models;

namespace WebApiASPNET.Data
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext(DbContextOptions<AssignmentContext> options) : base(options) { }
        public DbSet<Assignment> Assignments { get; set; } = null!; 
    }
}
