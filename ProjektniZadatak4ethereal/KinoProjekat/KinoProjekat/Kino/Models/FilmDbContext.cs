﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace KinoProjekat.Kino.Models
{
    class FilmDbContext: DbContext
    {
        public DbSet<Film> SviFilmovi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dataBaseFilePath = "BazaZaFilmove.db";
            try
            {
                dataBaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, dataBaseFilePath);
            }
            catch (InvalidOperationException) { }

            optionsBuilder.UseSqlite($"Data source={dataBaseFilePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 
        }
    }
}
