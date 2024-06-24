﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProTask.Helper;

#nullable disable

namespace ProTask.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ProTask.Entity.Programmer", b =>
                {
                    b.Property<int>("ProgrammerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("programmer_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProgrammerId"));

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nickname");

                    b.HasKey("ProgrammerId")
                        .HasName("pk_programmers");

                    b.ToTable("programmers", (string)null);
                });

            modelBuilder.Entity("ProTask.Entity.Specialization", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("specialization_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SpecializationId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<int>("Seniority")
                        .HasColumnType("int")
                        .HasColumnName("seniority");

                    b.HasKey("SpecializationId")
                        .HasName("pk_specializations");

                    b.ToTable("specializations", (string)null);
                });

            modelBuilder.Entity("ProTask.Entity.Todo", b =>
                {
                    b.Property<int>("TodoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("todo_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TodoId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_on");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(65535)
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<int>("Priority")
                        .HasColumnType("int")
                        .HasColumnName("priority");

                    b.Property<int?>("ProgrammerId")
                        .HasColumnType("int")
                        .HasColumnName("programmer_id");

                    b.HasKey("TodoId")
                        .HasName("pk_todos");

                    b.HasIndex("ProgrammerId")
                        .HasDatabaseName("ix_todos_programmer_id");

                    b.ToTable("todos", (string)null);
                });

            modelBuilder.Entity("ProgrammerSpecialization", b =>
                {
                    b.Property<int>("ProgrammersProgrammerId")
                        .HasColumnType("int")
                        .HasColumnName("programmers_programmer_id");

                    b.Property<int>("SpecializationsSpecializationId")
                        .HasColumnType("int")
                        .HasColumnName("specializations_specialization_id");

                    b.HasKey("ProgrammersProgrammerId", "SpecializationsSpecializationId")
                        .HasName("pk_programmer_specialization");

                    b.HasIndex("SpecializationsSpecializationId")
                        .HasDatabaseName("ix_programmer_specialization_specializations_specialization_id");

                    b.ToTable("programmer_specialization", (string)null);
                });

            modelBuilder.Entity("ProTask.Entity.Todo", b =>
                {
                    b.HasOne("ProTask.Entity.Programmer", "Programmer")
                        .WithMany("Todos")
                        .HasForeignKey("ProgrammerId")
                        .HasConstraintName("fk_todos_programmers_programmer_id");

                    b.Navigation("Programmer");
                });

            modelBuilder.Entity("ProgrammerSpecialization", b =>
                {
                    b.HasOne("ProTask.Entity.Programmer", null)
                        .WithMany()
                        .HasForeignKey("ProgrammersProgrammerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_programmer_specialization_programmers_programmers_programmer");

                    b.HasOne("ProTask.Entity.Specialization", null)
                        .WithMany()
                        .HasForeignKey("SpecializationsSpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_programmer_specialization_specializations_specializations_sp");
                });

            modelBuilder.Entity("ProTask.Entity.Programmer", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
