using System;
using GothamCares.Entity;
using Microsoft.EntityFrameworkCore;

namespace entities.models
{
    public class Gothamcaresdemo1Context : DbContext
    {
        public Gothamcaresdemo1Context(DbContextOptions<Gothamcaresdemo1Context> options) : base(options) { }


        public DbSet<Outlet> users { get; set; }


    }
}
