using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ResortBookingApp.Models;

namespace ResortBookingApp.Migrations
{
    [DbContext(typeof(BookingsContext))]
    [Migration("20180124224544_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ResortBookingApp.Bookings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BookingDate");

                    b.Property<string>("Name");

                    b.Property<int>("NumOfppl");

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.ToTable("Bookings");
                });
        }
    }
}
