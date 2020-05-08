using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SQL_Multi_Flow
{
    public partial class RushDataBasesServersListContext : DbContext
    {
        string server, database, login, password;

        public RushDataBasesServersListContext()
        {
            this.server = ConfigurationManager.AppSettings["server"];
            this.database = ConfigurationManager.AppSettings["database"];
            this.login = ConfigurationManager.AppSettings["login"];
            this.password = ConfigurationManager.AppSettings["password"];
        }

        public RushDataBasesServersListContext(DbContextOptions<RushDataBasesServersListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Markers> Markers { get; set; }
        public virtual DbSet<Relations> Relations { get; set; }
        public virtual DbSet<ServerList> ServerList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"server={this.server};database={this.database};user={this.login};password={this.password};");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Markers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MarkerName)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Relations>(entity =>
            {
                entity.HasIndex(e => new { e.ServerListId, e.MarkerId })
                    .HasName("UI")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MarkerId).HasColumnName("MarkerID");

                entity.Property(e => e.ServerListId).HasColumnName("ServerListID");

                entity.HasOne(d => d.Marker)
                    .WithMany(p => p.Relations)
                    .HasForeignKey(d => d.MarkerId)
                    .HasConstraintName("FK_Relations_TO_Marker");

                entity.HasOne(d => d.ServerList)
                    .WithMany(p => p.Relations)
                    .HasForeignKey(d => d.ServerListId)
                    .HasConstraintName("FK_Relations_TO_ServerList");
            });

            modelBuilder.Entity<ServerList>(entity =>
            {
                entity.HasIndex(e => e.ServerDomainName)
                    .HasName("UQ_RushDataBasesServersList")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataBaseName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ServerDomainName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ServerLogin)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ServerPassword)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
