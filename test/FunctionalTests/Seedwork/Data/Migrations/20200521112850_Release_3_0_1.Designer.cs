﻿// <auto-generated />
using System;
using Balea.EntityFrameworkCore.Store.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FunctionalTests.Seedwork.Data.Migrations
{
    [DbContext(typeof(BaleaDbContext))]
    [Migration("20200521112850_Release_3_0_1")]
    partial class Release_3_0_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.ApplicationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.DelegationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Selected")
                        .HasColumnType("bit");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<int>("WhoId")
                        .HasColumnType("int");

                    b.Property<int>("WhomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("WhomId");

                    b.HasIndex("WhoId", "WhomId", "ApplicationId")
                        .IsUnique();

                    b.ToTable("Delegations");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.MappingEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Mappings");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.PermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("Name", "ApplicationId")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("Name", "ApplicationId")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RoleMappingEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("MappingId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "MappingId");

                    b.HasIndex("MappingId");

                    b.ToTable("RoleMappings");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RolePermissionEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RoleSubjectEntity", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("RoleId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("RoleSubjects");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.SubjectEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Sub")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Sub")
                        .IsUnique();

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.DelegationEntity", b =>
                {
                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.ApplicationEntity", "Application")
                        .WithMany("Delegations")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.SubjectEntity", "Who")
                        .WithMany("WhoDelegations")
                        .HasForeignKey("WhoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.SubjectEntity", "Whom")
                        .WithMany("WhomDelegations")
                        .HasForeignKey("WhomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.PermissionEntity", b =>
                {
                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.ApplicationEntity", "Application")
                        .WithMany("Permissions")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RoleEntity", b =>
                {
                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.ApplicationEntity", "Application")
                        .WithMany("Roles")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RoleMappingEntity", b =>
                {
                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.MappingEntity", "Mapping")
                        .WithMany("Roles")
                        .HasForeignKey("MappingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.RoleEntity", "Role")
                        .WithMany("Mappings")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RolePermissionEntity", b =>
                {
                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.PermissionEntity", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.RoleEntity", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Balea.EntityFrameworkCore.Store.Entities.RoleSubjectEntity", b =>
                {
                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.RoleEntity", "Role")
                        .WithMany("Subjects")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Balea.EntityFrameworkCore.Store.Entities.SubjectEntity", "Subject")
                        .WithMany("Roles")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
