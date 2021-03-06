﻿using Lccs.Musicas.AcessoDados.Entity.TypeConfiguration;
using Lccs.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lccs.Musicas.AcessoDados.Entity.Context
{
    public class MusicasDbContext: DbContext
    {
        public DbSet<Album> Albuns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
        }
    }
}
