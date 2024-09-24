﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tf_api.DBContexts;

#nullable disable

namespace tf_api.Migrations
{
    [DbContext(typeof(TaskFlowDBContext))]
    [Migration("20240924091158_SecondaryMigration")]
    partial class SecondaryMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("tf_api.Models.BudgetItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BudgetListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BudgetListId");

                    b.ToTable("BudgetItems");
                });

            modelBuilder.Entity("tf_api.Models.BudgetList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DashboardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DashboardId");

                    b.ToTable("BudgetLists");
                });

            modelBuilder.Entity("tf_api.Models.Dashboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Dashboards");
                });

            modelBuilder.Entity("tf_api.Models.Todo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDone")
                        .HasColumnType("bit");

                    b.Property<int?>("TodoListId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TodoListId");

                    b.ToTable("Todos");
                });

            modelBuilder.Entity("tf_api.Models.TodoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DashboardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DashboardId");

                    b.ToTable("TodoLists");
                });

            modelBuilder.Entity("tf_api.Models.BudgetItem", b =>
                {
                    b.HasOne("tf_api.Models.BudgetList", null)
                        .WithMany("Items")
                        .HasForeignKey("BudgetListId");
                });

            modelBuilder.Entity("tf_api.Models.BudgetList", b =>
                {
                    b.HasOne("tf_api.Models.Dashboard", null)
                        .WithMany("BudgetLists")
                        .HasForeignKey("DashboardId");
                });

            modelBuilder.Entity("tf_api.Models.Todo", b =>
                {
                    b.HasOne("tf_api.Models.TodoList", null)
                        .WithMany("Todos")
                        .HasForeignKey("TodoListId");
                });

            modelBuilder.Entity("tf_api.Models.TodoList", b =>
                {
                    b.HasOne("tf_api.Models.Dashboard", null)
                        .WithMany("TodoLists")
                        .HasForeignKey("DashboardId");
                });

            modelBuilder.Entity("tf_api.Models.BudgetList", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("tf_api.Models.Dashboard", b =>
                {
                    b.Navigation("BudgetLists");

                    b.Navigation("TodoLists");
                });

            modelBuilder.Entity("tf_api.Models.TodoList", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
