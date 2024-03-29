﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodesApp.DAL;

#nullable disable

namespace NodesApp.DAL.Migrations
{
    [DbContext(typeof(NodesConext))]
    partial class NodesConextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NodesApp.DAL.Entities.Comment", b =>
                {
                    b.Property<long>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CommentId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("File")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<long?>("NodeId")
                        .HasColumnType("bigint");

                    b.Property<long>("PostId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("CommentId");

                    b.HasIndex("NodeId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Message", b =>
                {
                    b.Property<long>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MessageId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<long?>("MessageReplyTo")
                        .HasColumnType("bigint");

                    b.Property<long>("ReceiverId")
                        .HasColumnType("bigint");

                    b.Property<long>("SenderId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.HasIndex("MessageReplyTo");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Node", b =>
                {
                    b.Property<long>("NodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("NodeId"));

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("File")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NodeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NodeType")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NodeId");

                    b.ToTable("Nodes");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.NodeSettings", b =>
                {
                    b.Property<long>("NodeSettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("NodeSettingsId"));

                    b.Property<long>("NodeId")
                        .HasColumnType("bigint");

                    b.HasKey("NodeSettingsId");

                    b.HasIndex("NodeId");

                    b.ToTable("NodeSettings");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Post", b =>
                {
                    b.Property<long>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PostId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("File")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<long>("NodeId")
                        .HasColumnType("bigint");

                    b.Property<long>("PosterUserId")
                        .HasColumnType("bigint");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("NodeId");

                    b.HasIndex("PosterUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Reaction", b =>
                {
                    b.Property<long>("ReactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ReactionId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReactionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReactionId");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.UserNode", b =>
                {
                    b.Property<long>("UserNodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserNodeId"));

                    b.Property<long>("NodeId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("UserNodeId");

                    b.HasIndex("NodeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserNodes");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Comment", b =>
                {
                    b.HasOne("NodesApp.DAL.Entities.Node", null)
                        .WithMany("Comments")
                        .HasForeignKey("NodeId");

                    b.HasOne("NodesApp.DAL.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NodesApp.DAL.Entities.User", "Poster")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Poster");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Message", b =>
                {
                    b.HasOne("NodesApp.DAL.Entities.Message", "ReplyTo")
                        .WithMany()
                        .HasForeignKey("MessageReplyTo");

                    b.HasOne("NodesApp.DAL.Entities.User", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NodesApp.DAL.Entities.User", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("ReplyTo");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.NodeSettings", b =>
                {
                    b.HasOne("NodesApp.DAL.Entities.Node", "Node")
                        .WithMany()
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Node");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Post", b =>
                {
                    b.HasOne("NodesApp.DAL.Entities.Node", "Node")
                        .WithMany("Posts")
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NodesApp.DAL.Entities.User", "Poster")
                        .WithMany()
                        .HasForeignKey("PosterUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Node");

                    b.Navigation("Poster");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.UserNode", b =>
                {
                    b.HasOne("NodesApp.DAL.Entities.Node", "Node")
                        .WithMany("UserNodes")
                        .HasForeignKey("NodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NodesApp.DAL.Entities.User", "User")
                        .WithMany("UserNodes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Node");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Node", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");

                    b.Navigation("UserNodes");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.Post", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("NodesApp.DAL.Entities.User", b =>
                {
                    b.Navigation("UserNodes");
                });
#pragma warning restore 612, 618
        }
    }
}
