﻿// <auto-generated />
using System;
using Docker.AutoDl.Database.SqLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Docker.AutoDl.Database.SqLite.Migrations
{
    [DbContext(typeof(SqLiteContext))]
    [Migration("20180521154715_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029");

            modelBuilder.Entity("Docker.AutoDl.Database.SqLite.BlackListShowSqLite", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Season");

                    b.Property<string>("SerieName");

                    b.Property<uint>("TraktShowId");

                    b.HasKey("Id");

                    b.ToTable("BlackListShow");
                });
#pragma warning restore 612, 618
        }
    }
}
