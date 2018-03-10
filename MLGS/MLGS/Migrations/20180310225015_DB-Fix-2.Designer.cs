﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MLGS;
using System;

namespace MLGS.Migrations
{
    [DbContext(typeof(ParcelContext))]
    [Migration("20180310225015_DB-Fix-2")]
    partial class DBFix2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MLGS.ParcelData", b =>
                {
                    b.Property<int>("ParcelDataId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Humidity_value");

                    b.Property<float>("Light_sensor_value");

                    b.Property<float>("Temperature_sensor_value");

                    b.HasKey("ParcelDataId");

                    b.ToTable("ParcelsData");
                });
#pragma warning restore 612, 618
        }
    }
}
