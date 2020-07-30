using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace LadyBusinesCoreAng
{
    public partial class LadyDbContext : DbContext
    {
        public LadyDbContext(DbContextOptions<LadyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArInternalMetadata> ArInternalMetadata { get; set; }
        public virtual DbSet<Gigs> Gigs { get; set; }
        public virtual DbSet<Instruments> Instruments { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<SchemaMigrations> SchemaMigrations { get; set; }
        public virtual DbSet<Songs> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                    
                optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArInternalMetadata>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("ar_internal_metadata_pkey");

                entity.ToTable("ar_internal_metadata");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Gigs>(entity =>
            {
                entity.ToTable("gigs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasColumnType("character varying");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DateOfEvent).HasColumnName("date_of_event");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EventName)
                    .HasColumnName("event_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.HouseNumber).HasColumnName("house_number");

                entity.Property(e => e.ImageFilename)
                    .HasColumnName("image_filename")
                    .HasColumnType("character varying");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("character varying");

                entity.Property(e => e.PhoneNum)
                    .HasColumnName("phone_num")
                    .HasMaxLength(11);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasColumnType("character varying");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasColumnType("character varying");

                entity.Property(e => e.TimeOfEvent).HasColumnName("time_of_event");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("character varying");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Instruments>(entity =>
            {
                entity.ToTable("instruments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<Members>(entity =>
            {
                entity.ToTable("members");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.FName)
                    .HasColumnName("f_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.ImageFile)
                    .HasColumnName("image_file")
                    .HasColumnType("character varying");

                entity.Property(e => e.NickName)
                    .HasColumnName("nick_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.SpecialGuest).HasColumnName("special_guest");

                entity.Property(e => e.Summary).HasColumnName("summary");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<SchemaMigrations>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("schema_migrations_pkey");

                entity.ToTable("schema_migrations");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Songs>(entity =>
            {
                entity.ToTable("songs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(6) without time zone");

                entity.Property(e => e.FileName)
                    .HasColumnName("file_name")
                    .HasColumnType("character varying");

                entity.Property(e => e.SongTitle)
                    .HasColumnName("song_title")
                    .HasColumnType("character varying");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("timestamp(6) without time zone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
