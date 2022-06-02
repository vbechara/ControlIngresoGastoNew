﻿using ControlIngresoGastoNew.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresoGastoNew.Data
{
    public class ApplicationDbContext:DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<IngresoGasto> IngresoGasto { get; set; }
    }
}
