﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp.net_crud.Models;

#nullable disable

namespace asp.net_crud.Migrations
{
    [DbContext(typeof(AbcCompDBcontext))]
    partial class AbcCompDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("asp.net_crud.Models.Employee", b =>
                {
                    b.Property<int>("e_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("e_Id"));

                    b.Property<string>("e_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("e_age")
                        .HasColumnType("int");

                    b.Property<string>("e_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("e_Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
