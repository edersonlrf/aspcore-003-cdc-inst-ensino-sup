﻿using Cap02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cap02.Data
{
    public class IESContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }

        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {

        }
    }
}
