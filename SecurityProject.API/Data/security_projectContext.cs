using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SecurityProject.API.Data
{
    public partial class security_projectContext : DbContext
    {
        public security_projectContext()
        {
        }

        public security_projectContext(DbContextOptions<security_projectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Roles> Roles { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseMySql("Server=192.168.200.100;Database=security_project;User=security_usr;Password=P@ssw0rd;");
//             }
//         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    RoleId = 1,
                    RoleCode = "admin",
                    RoleDescription = "System Administrator",
                    RoleActiveDefault = 0                   
                },
                new Roles
                {
                    RoleId = 2,
                    RoleCode = "user",
                    RoleDescription = "Application User",
                    RoleActiveDefault = 1                   
                },
                new Roles
                {
                    RoleId = 3,
                    RoleCode = "guest",
                    RoleDescription = "Guest User",
                    RoleActiveDefault = 1                   
                }                
            );


            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.RoleId)
                    .HasColumnName("role_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleActiveDefault)
                    .HasColumnName("role_active_default")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasColumnName("role_code")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.RoleDescription)
                    .IsRequired()
                    .HasColumnName("role_description")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.RoleSysdate)
                    .HasColumnName("role_sysdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("now()");
            });
        }
    }
}
