using Microsoft.EntityFrameworkCore;
using System;

namespace LorikeetRESTApp.Database
{
    public partial class LorikeetAppContext : DbContext
    {
        public virtual DbSet<AppointmentMember> AppointmentMember { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<AppointmentsNumbers> AppointmentsNumbers { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<AttendanceNumbers> AttendanceNumbers { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<DebitSystem> DebitSystem { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<DiagnosisName> DiagnosisName { get; set; }
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
                optionsBuilder.UseMySql("server=192.168.1.231;TreatTinyAsBoolean=false;database=LorikeetApp;userid=lorikeet;pwd=lorikeet;port=3306;sslmode=none;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentMember>(entity =>
            {
                entity.HasKey(e => e.MemberActivityId);

                entity.Property(e => e.MemberActivityId)
                    .HasColumnName("MemberActivityID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppointmentsId)
                    .HasColumnName("AppointmentsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AllDay).HasColumnType("tinyint(1)");

                entity.Property(e => e.CustomField1).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(20);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Label).HasColumnType("int(11)");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.RecurrenceInfo).HasMaxLength(20);

                entity.Property(e => e.ReminderInfo).HasMaxLength(20);

                entity.Property(e => e.ResourceId)
                    .HasColumnName("ResourceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceIds)
                    .HasColumnName("ResourceIDs")
                    .HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.TimeZoneId).HasMaxLength(20);

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<AppointmentsNumbers>(entity =>
            {
                entity.HasKey(e => e.AppointmentsNumbers1);

                entity.Property(e => e.AppointmentsNumbers1)
                    .HasColumnName("AppointmentsNumbers")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.LabelId)
                    .HasColumnName("LabelID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Number).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.Property(e => e.AttendanceId)
                    .HasColumnName("AttendanceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<AttendanceNumbers>(entity =>
            {
                entity.Property(e => e.AttendanceNumbersId)
                    .HasColumnName("AttendanceNumbersID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Number).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => e.MemberId)
                    .HasName("FK_Contact_Member");

                entity.Property(e => e.ContactId)
                    .HasColumnName("ContactID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactAddress).HasMaxLength(500);

                entity.Property(e => e.ContactName).HasMaxLength(500);

                entity.Property(e => e.ContactPhone).HasMaxLength(20);

                entity.Property(e => e.ContactType).HasMaxLength(500);

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_Member");
            });

            modelBuilder.Entity<DebitSystem>(entity =>
            {
                entity.HasKey(e => e.DebitId);

                entity.HasIndex(e => e.MemberId)
                    .HasName("FK_DebitSystem_Member");

                entity.HasIndex(e => e.StaffId)
                    .HasName("FK_DebitSystem_Staff");

                entity.Property(e => e.DebitId)
                    .HasColumnName("DebitID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Credit).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Debit).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Details).HasMaxLength(200);

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RunningTotal).HasColumnType("decimal(18,2)");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.DebitSystem)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebitSystem_Member");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.DebitSystem)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebitSystem_Staff");
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.HasIndex(e => e.MemberId)
                    .HasName("FK_Diagnosis_Member");

                entity.Property(e => e.DiagnosisId)
                    .HasColumnName("DiagnosisID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiagnosisNameId)
                    .HasColumnName("DiagnosisNameID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Diagnosis)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Diagnosis_Member");
            });

            modelBuilder.Entity<DiagnosisName>(entity =>
            {
                entity.Property(e => e.DiagnosisNameId)
                    .HasColumnName("DiagnosisNameID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DiagnosisName1)
                    .IsRequired()
                    .HasColumnName("DiagnosisName")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.Property(e => e.GuestId)
                    .HasColumnName("GuestID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Picture).IsRequired();
            });

            modelBuilder.Entity<Labels>(entity =>
            {
                entity.HasKey(e => e.LabelId);

                entity.Property(e => e.LabelId)
                    .HasColumnName("LabelID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color).HasColumnType("int(11)");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.MenuCaption).HasMaxLength(50);

                entity.Property(e => e.Shortcut).HasMaxLength(20);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.LogId)
                    .HasColumnName("LogID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorCode).HasColumnType("int(11)");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RefreshCode).HasColumnType("int(11)");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Access).HasColumnType("int(11)");

                entity.Property(e => e.LoginName).HasMaxLength(50);

                entity.Property(e => e.LoginPass).HasMaxLength(50);

                entity.Property(e => e.Pin).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Lunch>(entity =>
            {
                entity.HasIndex(e => e.StaffId)
                    .HasName("FK_Lunch_Staff");

                entity.Property(e => e.LunchId)
                    .HasColumnName("LunchID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Main).HasColumnType("tinyint(1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Paid).HasColumnType("tinyint(1)");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TakeAway).HasColumnType("tinyint(1)");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Lunch)
                    .HasForeignKey(d => d.StaffId)
                    .HasConstraintName("FK_Lunch_Staff");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.HasIndex(e => e.MemberId)
                    .HasName("FK_Medication_Member");

                entity.Property(e => e.MedicationId)
                    .HasColumnName("MedicationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedicationNameId)
                    .HasColumnName("MedicationNameID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Medication)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medication_Member");
            });

            modelBuilder.Entity<MedicationName>(entity =>
            {
                entity.Property(e => e.MedicationNameId)
                    .HasColumnName("MedicationNameID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MedicationName1)
                    .IsRequired()
                    .HasColumnName("MedicationName")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Aboriginal).HasColumnType("tinyint(1)");

                entity.Property(e => e.Agency).HasColumnType("tinyint(1)");

                entity.Property(e => e.Archived).HasColumnType("tinyint(1)");

                entity.Property(e => e.BirthdayCard).HasColumnType("tinyint(1)");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CountryOfOrigin).HasMaxLength(200);

                entity.Property(e => e.DateAltered).HasColumnType("datetime");

                entity.Property(e => e.DateJoined).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MobileNumber).HasMaxLength(20);

                entity.Property(e => e.PostCode).HasMaxLength(7);

                entity.Property(e => e.ReceiveByMail).HasColumnType("tinyint(1)");

                entity.Property(e => e.ReceiveNewsletter).HasColumnType("tinyint(1)");

                entity.Property(e => e.Sex).HasColumnType("tinyint(1)");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StreetAddress).HasMaxLength(200);

                entity.Property(e => e.Studying).HasColumnType("tinyint(1)");

                entity.Property(e => e.Suburb).HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(20);

                entity.Property(e => e.Volunteering).HasColumnType("tinyint(1)");

                entity.Property(e => e.Working).HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.MenuId)
                    .HasColumnName("MenuID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateMade).HasColumnType("datetime");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.NotesId);

                entity.Property(e => e.NotesId)
                    .HasColumnName("NotesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Editable).HasColumnType("tinyint(1)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.HasIndex(e => e.MemberId)
                    .HasName("FK_Picture_Member");

                entity.Property(e => e.PictureId)
                    .HasColumnName("PictureID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemberPicture).IsRequired();

                entity.Property(e => e.PictureName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.Picture)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Picture_Member");
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.Property(e => e.UniqueId)
                    .HasColumnName("UniqueID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Color).HasColumnType("int(11)");

                entity.Property(e => e.CustomField1).HasMaxLength(20);

                entity.Property(e => e.ResourceId)
                    .HasColumnName("ResourceID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceName).HasMaxLength(50);
            });

            modelBuilder.Entity<SignIn>(entity =>
            {
                entity.HasIndex(e => e.GuestId)
                    .HasName("FK_SignIn_Guest");

                entity.HasIndex(e => e.MemberId)
                    .HasName("FK_SignIn_Member");

                entity.Property(e => e.SigninId)
                    .HasColumnName("SigninID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GuestId)
                    .HasColumnName("GuestID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MemberID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MethodOfSigningIn).HasMaxLength(50);

                entity.Property(e => e.Timein).HasColumnType("datetime");

                entity.Property(e => e.Timeout).HasColumnType("datetime");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.SignIn)
                    .HasForeignKey(d => d.GuestId)
                    .HasConstraintName("FK_SignIn_Guest");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.SignIn)
                    .HasForeignKey(d => d.MemberId)
                    .HasConstraintName("FK_SignIn_Member");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasIndex(e => e.LoginId)
                    .HasName("FK_Staff_Login");

                entity.Property(e => e.StaffId)
                    .HasColumnName("StaffID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.Staff)
                    .HasForeignKey(d => d.LoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staff_Login");
            });
        }
    }
}
