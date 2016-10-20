using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MvcMovie.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActor>()
                .HasKey(t => new { t.MovieId, t.ActorId });

            modelBuilder.Entity<MovieActor>()
                .HasOne(pt => pt.Movie)
                .WithMany(p => p.MovieActors)
                .HasForeignKey(pt => pt.MovieId);

            modelBuilder.Entity<MovieActor>()
                .HasOne(pt => pt.Actor)
                .WithMany(t => t.MovieActors)
                .HasForeignKey(pt => pt.ActorId);
        }

        

        public override EntityEntry<TEntity> Add<TEntity>(TEntity entity)
        {
            if (entity is BaseModel)
            {
                var baseModelEntity = entity as BaseModel;

                if (baseModelEntity != null)
                {
                    baseModelEntity.DateCreated = DateTime.UtcNow;
                    baseModelEntity.DateUpdated = DateTime.UtcNow;

                    return base.Add<TEntity>(baseModelEntity as TEntity);
                }
            }
            return base.Add<TEntity>(entity);
        }

        

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Actor> Genres { get; set; }
    }
}
