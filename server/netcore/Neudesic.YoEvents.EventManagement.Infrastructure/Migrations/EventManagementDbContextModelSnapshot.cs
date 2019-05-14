﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Neudesic.YoEvents.EventManagement.Infrastructure;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Neudesic.YoEvents.EventManagement.Infrastructure.Migrations
{
    [DbContext(typeof(EventManagementDbContext))]
    partial class EventManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("eventmgmt")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Neudesic.YoEvents.EventManagement.Domain.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 5, 6, 22, 19, 18, 674, DateTimeKind.Utc).AddTicks(439));

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<Guid>("OrganizationId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate")
                        .ValueGeneratedOnUpdate()
                        .HasDefaultValue(new DateTime(2019, 5, 6, 22, 19, 18, 676, DateTimeKind.Utc).AddTicks(8119));

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Neudesic.YoEvents.EventManagement.Domain.Entities.EventType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<Guid>("OrganizationId");

                    b.HasKey("Id");

                    b.ToTable("EventTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
