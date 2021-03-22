using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyServiceWeb.Models
{
    public partial class MyABMContext : DbContext
    {
        public MyABMContext()
        {
        }

        public MyABMContext(DbContextOptions<MyABMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<RequestRelationship> RequestRelationships { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserPost> UserPosts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-R3L94R9\\FORCIDB;Database=MyABM;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.IdImage)
                    .HasName("image_pk");

                entity.ToTable("Image");

                entity.Property(e => e.IdImage).HasColumnName("id_image");

                entity.Property(e => e.IdPublication).HasColumnName("id_publication");

                entity.Property(e => e.Image1)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.HasOne(d => d.IdPublicationNavigation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.IdPublication)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("publication_image_fk");
            });

            modelBuilder.Entity<RequestRelationship>(entity =>
            {
                entity.HasKey(e => e.IdRequest)
                    .HasName("request_relationship_pk");

                entity.ToTable("Request_Relationship");

                entity.Property(e => e.IdRequest).HasColumnName("id_request");

                entity.Property(e => e.IdUserReceive).HasColumnName("id_user_receive");

                entity.Property(e => e.IdUserSend).HasColumnName("id_user_send");

                entity.Property(e => e.State).HasColumnName("state");

                entity.HasOne(d => d.IdUserReceiveNavigation)
                    .WithMany(p => p.RequestRelationshipIdUserReceiveNavigations)
                    .HasForeignKey(d => d.IdUserReceive)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_request_relationship_fk1");

                entity.HasOne(d => d.IdUserSendNavigation)
                    .WithMany(p => p.RequestRelationshipIdUserSendNavigations)
                    .HasForeignKey(d => d.IdUserSend)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_request_relationship_fk");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("user_pk");

                entity.ToTable("User");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.AttemptLogin).HasColumnName("attempt_login");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Locked).HasColumnName("locked");

                entity.Property(e => e.LogIn).HasColumnName("log_in");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Nickname)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("nickname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<UserPost>(entity =>
            {
                entity.HasKey(e => e.IdPublication)
                    .HasName("user_post_pk");

                entity.ToTable("User_Post");

                entity.Property(e => e.IdPublication).HasColumnName("id_publication");

                entity.Property(e => e.DatePublication)
                    .HasColumnType("datetime")
                    .HasColumnName("date_publication");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Post)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("post");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserPosts)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_publication_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
