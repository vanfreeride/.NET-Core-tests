﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.infrastructure.Db;

namespace webapi.infrastructure.Migrations
{
    [DbContext(typeof(MyDb))]
    [Migration("20190106200701_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity("webapi.infrastructure.DbObjects.BookRow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}