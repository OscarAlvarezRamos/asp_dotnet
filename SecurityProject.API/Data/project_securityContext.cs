using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SecurityProject.API.Data
{
    public partial class project_securityContext : DbContext
    {
        public project_securityContext()
        {
        }

        public project_securityContext(DbContextOptions<project_securityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Roles> Roles { get; set; }

//         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//         {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseMySql("Server=192.168.200.100;Database=project_security;User=security_usr;Password=P@ssw0rd;");
//             }
//         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");
            });
        }
    }
}
