﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecurityProject.API.Data;

namespace SecurityProject.API.Migrations
{
    [DbContext(typeof(security_projectContext))]
    partial class security_projectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SecurityProject.API.Data.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_id")
                        .HasColumnType("int(11)");

                    b.Property<sbyte?>("RoleActiveDefault")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_active_default")
                        .HasColumnType("tinyint(4)")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasColumnName("role_code")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasColumnName("role_description")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime?>("RoleSysdate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("role_sysdate")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("now()");

                    b.HasKey("RoleId")
                        .HasName("PRIMARY");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleActiveDefault = (sbyte)0,
                            RoleCode = "admin",
                            RoleDescription = "System Administrator"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleActiveDefault = (sbyte)1,
                            RoleCode = "user",
                            RoleDescription = "Application User"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleActiveDefault = (sbyte)1,
                            RoleCode = "guest",
                            RoleDescription = "Guest User"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
