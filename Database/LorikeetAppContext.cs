using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LorikeetRESTApp.Database
{
    public partial class LorikeetAppContext : DbContext
    {
        public LorikeetAppContext()
        {
        }

        public LorikeetAppContext(DbContextOptions<LorikeetAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppointmentMember> AppointmentMember { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<AppointmentsNumbers> AppointmentsNumbers { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<AttendanceNumbers> AttendanceNumbers { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<DebitSystem> DebitSystem { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<DiagnosisName> DiagnosisName { get; set; }
        public virtual DbSet<GeocodeCache> GeocodeCache { get; set; }
        public virtual DbSet<Guest> Guest { get; set; }
        public virtual DbSet<Labels> Labels { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Lunch> Lunch { get; set; }
        public virtual DbSet<Medication> Medication { get; set; }
        public virtual DbSet<MedicationName> MedicationName { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Picture> Picture { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<SignIn> SignIn { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=192.168.1.231;database=LorikeetApp;userid=lorikeet;pwd=lorikeet;port=3306;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentMember>(entity =>
            {
                entity.HasKey(e => e.MemberActivityId);

                entity.ToTable("AppointmentMember", "LorikeetApp");

                entity.Property(e => e.MemberActivityId).HasColumnName("MemberActivityID");

                entity.Property(e => e.AppointmentsId).HasColumnName("AppointmentsID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("Appointments", "LorikeetApp");

                entity.Property(e => e.UniqueId).HasColumnName("UniqueID");

                entity.Property(e => e.CustomField1)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.Location)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.RecurrenceInfo)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.ReminderInfo)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceIds)
                    .HasColumnName("ResourceIDs")
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.Subject)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeZoneId)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AppointmentsNumbers>(entity =>
            {
                entity.HasKey(e => e.AppointmentsNumbers1);

                entity.ToTable("AppointmentsNumbers", "LorikeetApp");

                entity.Property(e => e.AppointmentsNumbers1).HasColumnName("AppointmentsNumbers");

                entity.Property(e => e.LabelId).HasColumnName("LabelID");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance", "LorikeetApp");

                entity.Property(e => e.AttendanceId).HasColumnName("AttendanceID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");
            });

            modelBuilder.Entity<AttendanceNumbers>(entity =>
            {
                entity.ToTable("AttendanceNumbers", "LorikeetApp");

                entity.Property(e => e.AttendanceNumbersId).HasColumnName("AttendanceNumbersID");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact", "LorikeetApp");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactAddress)
                    .HasColumnType("varchar")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactName)
                    .HasColumnType("varchar")
                    .HasMaxLength(500);

                entity.Property(e => e.ContactPhone)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.ContactType)
                    .HasColumnType("varchar")
                    .HasMaxLength(500);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");
            });

            modelBuilder.Entity<DebitSystem>(entity =>
            {
                entity.HasKey(e => e.DebitId);

                entity.ToTable("DebitSystem", "LorikeetApp");

                entity.Property(e => e.DebitId).HasColumnName("DebitID");

                entity.Property(e => e.Credit)
                    .HasAnnotation("Precision", 18)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.Debit)
                    .HasAnnotation("Precision", 18)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.Details)
                    .HasColumnType("varchar")
                    .HasMaxLength(200);

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.RunningTotal)
                    .HasAnnotation("Precision", 18)
                    .HasAnnotation("Scale", 2);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.ToTable("Diagnosis", "LorikeetApp");

                entity.Property(e => e.DiagnosisId).HasColumnName("DiagnosisID");

                entity.Property(e => e.DiagnosisNameId).HasColumnName("DiagnosisNameID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");
            });

            modelBuilder.Entity<DiagnosisName>(entity =>
            {
                entity.ToTable("DiagnosisName", "LorikeetApp");

                entity.Property(e => e.DiagnosisNameId).HasColumnName("DiagnosisNameID");

                entity.Property(e => e.DiagnosisName1)
                    .IsRequired()
                    .HasColumnName("DiagnosisName")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<GeocodeCache>(entity =>
            {
                entity.ToTable("GeocodeCache", "LorikeetApp");

                entity.Property(e => e.GeocodeCacheId).HasColumnName("GeocodeCacheID");

                entity.Property(e => e.Latitude)
                    .HasAnnotation("Precision", 15)
                    .HasAnnotation("Scale", 10);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.Longitude)
                    .HasAnnotation("Precision", 15)
                    .HasAnnotation("Scale", 10);
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.ToTable("Guest", "LorikeetApp");

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.Property(e => e.Picture).IsRequired();
            });

            modelBuilder.Entity<Labels>(entity =>
            {
                entity.HasKey(e => e.LabelId);

                entity.ToTable("Labels", "LorikeetApp");

                entity.Property(e => e.LabelId).HasColumnName("LabelID");

                entity.Property(e => e.DisplayName)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.MenuCaption)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.Shortcut)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log", "LorikeetApp");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login", "LorikeetApp");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.LoginName)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.LoginPass)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Lunch>(entity =>
            {
                entity.ToTable("Lunch", "LorikeetApp");

                entity.Property(e => e.LunchId).HasColumnName("LunchID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.ToTable("Medication", "LorikeetApp");

                entity.Property(e => e.MedicationId).HasColumnName("MedicationID");

                entity.Property(e => e.MedicationNameId).HasColumnName("MedicationNameID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");
            });

            modelBuilder.Entity<MedicationName>(entity =>
            {
                entity.ToTable("MedicationName", "LorikeetApp");

                entity.Property(e => e.MedicationNameId).HasColumnName("MedicationNameID");

                entity.Property(e => e.MedicationName1)
                    .IsRequired()
                    .HasColumnName("MedicationName")
                    .HasColumnType("varchar")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("Member", "LorikeetApp");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Country)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryOfOrigin)
                    .HasColumnType("varchar")
                    .HasMaxLength(200);

                entity.Property(e => e.EmailAddress)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.Property(e => e.MobileNumber)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.PictureGuid)
                    .IsRequired()
                    .HasColumnName("PictureGUID")
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.PostCode)
                    .HasColumnType("varchar")
                    .HasMaxLength(7);

                entity.Property(e => e.State)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetAddress)
                    .HasColumnType("varchar")
                    .HasMaxLength(200);

                entity.Property(e => e.Suburb)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(100);

                entity.Property(e => e.TelephoneNumber)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu", "LorikeetApp");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.NotesId);

                entity.ToTable("Note", "LorikeetApp");

                entity.Property(e => e.NotesId).HasColumnName("NotesID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.Notes)
                    .HasColumnType("varchar")
                    .HasMaxLength(255);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("Picture", "LorikeetApp");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.MemberPicture).IsRequired();

                entity.Property(e => e.PictureName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("Resources", "LorikeetApp");

                entity.Property(e => e.UniqueId).HasColumnName("UniqueID");

                entity.Property(e => e.CustomField1)
                    .HasColumnType("varchar")
                    .HasMaxLength(20);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceName)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SignIn>(entity =>
            {
                entity.ToTable("SignIn", "LorikeetApp");

                entity.Property(e => e.SigninId).HasColumnName("SigninID");

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.MethodOfSigningIn)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.ToTable("Staff", "LorikeetApp");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasColumnType("varchar")
                    .HasMaxLength(50);
            });
        }
    }
}
