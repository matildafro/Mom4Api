﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mom4Api.Data;

#nullable disable

namespace Mom4Api.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20230222081023_NewInitialAfterChanges")]
    partial class NewInitialAfterChanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("Mom4Api.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AlbumTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CommentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Release")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlbumId");

                    b.HasIndex("CommentId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Mom4Api.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Com")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grade")
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Mom4Api.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("Mom4Api.Models.Album", b =>
                {
                    b.HasOne("Mom4Api.Models.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentId");

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("Mom4Api.Models.Song", b =>
                {
                    b.HasOne("Mom4Api.Models.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId");

                    b.Navigation("Album");
                });
#pragma warning restore 612, 618
        }
    }
}
