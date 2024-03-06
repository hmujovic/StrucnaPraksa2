﻿using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Database
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
