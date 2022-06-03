﻿using Microsoft.EntityFrameworkCore;

namespace EFCoreAPICRUD
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();

    }
}
