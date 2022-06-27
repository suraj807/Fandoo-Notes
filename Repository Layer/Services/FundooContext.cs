﻿using Microsoft.EntityFrameworkCore;
using Repository_Layer.Services.Entities;

namespace RepositoryLayer.Services
{
    public class FundooContext : DbContext
    {
        public FundooContext(DbContextOptions<FundooContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
