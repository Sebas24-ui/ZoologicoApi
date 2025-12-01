using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZoologicoApi.Modelos;

    public class _ZoologicoApiContext : DbContext
    {
        public _ZoologicoApiContext (DbContextOptions<_ZoologicoApiContext> options)
            : base(options)
        {
        }

        public DbSet<Raza> Razas { get; set; } = default!;

public DbSet<Especie> Especies { get; set; } = default!;

public DbSet<Animal> Animals { get; set; } = default!;
    }
