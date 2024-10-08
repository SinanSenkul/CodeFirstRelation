using CodeFirstRelation.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace CodeFirstRelation.Context
{
    public class CodeFirstRelationDbContext : DbContext
    {
        //üç büyüklerin birincisi
        public CodeFirstRelationDbContext(DbContextOptions<CodeFirstRelationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PostEntity> Posts => Set<PostEntity>();
        public DbSet<UserEntity> Users => Set<UserEntity>();
    }
}
