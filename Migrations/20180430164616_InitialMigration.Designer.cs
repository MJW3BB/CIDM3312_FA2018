﻿// <auto-generated />
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace FinalProject.Migrations
{
    [DbContext(typeof(FinalProjectContext))]
    [Migration("20180430164616_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("FinalProject.Models.Project", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProjectDescription");

                    b.Property<string>("ProjectName");

                    b.HasKey("ID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("FinalProject.Models.ProjectParticipant", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("ID");

                    b.ToTable("ProjectParticipant");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ProjectParticipant");
                });

            modelBuilder.Entity("FinalProject.Models.ProjectRoster", b =>
                {
                    b.Property<string>("ProjectID");

                    b.Property<string>("ProjectParticipantID");

                    b.HasKey("ProjectID", "ProjectParticipantID");

                    b.HasIndex("ProjectParticipantID");

                    b.ToTable("ProjectRoster");
                });

            modelBuilder.Entity("FinalProject.Models.Client", b =>
                {
                    b.HasBaseType("FinalProject.Models.ProjectParticipant");

                    b.Property<string>("CompanyName");

                    b.ToTable("Client");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("FinalProject.Models.Member", b =>
                {
                    b.HasBaseType("FinalProject.Models.ProjectParticipant");

                    b.Property<string>("Major");

                    b.ToTable("Client");

                    b.HasDiscriminator().HasValue("Member");
                });

            modelBuilder.Entity("FinalProject.Models.ProjectRoster", b =>
                {
                    b.HasOne("FinalProject.Models.Project", "Project")
                        .WithMany("Participants")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FinalProject.Models.ProjectParticipant", "ProjectParticipant")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectParticipantID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
