﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirst.Models;

namespace CodeFirst.Data
{
    public class CodeFirstContext : DbContext
    {
        public CodeFirstContext (DbContextOptions<CodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirst.Models.Burger> Burger { get; set; } = default!;
    }
}
