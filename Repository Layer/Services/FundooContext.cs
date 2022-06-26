﻿using Microsoft.EntityFrameworkCore;
using Repository_Layer.Services.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository_Layer.Services
{
    public class FundooContext : DbContext
    {
        public FundooContext(DbContextOptions<FundooContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
