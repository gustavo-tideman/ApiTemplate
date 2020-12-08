﻿using Microsoft.EntityFrameworkCore;

namespace ApiTemplate.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}