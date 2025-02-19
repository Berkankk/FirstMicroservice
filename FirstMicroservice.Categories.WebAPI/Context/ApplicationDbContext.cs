﻿using FirstMicroservice.Categories.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMicroservice.Categories.WebAPI.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
