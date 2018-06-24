using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Migrations.LorikeetApp
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppointmentMember",
                columns: table => new
                {
                    MemberActivityID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AppointmentsID = table.Column<int>(type: "int(11)", nullable: false),
                    MemberID = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentMember", x => x.MemberActivityID);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    UniqueID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AllDay = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    CustomField1 = table.Column<string>(maxLength: 20, nullable: true),
                    Description = table.Column<string>(maxLength: 20, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Label = table.Column<int>(type: "int(11)", nullable: true),
                    Location = table.Column<string>(maxLength: 50, nullable: true),
                    RecurrenceInfo = table.Column<string>(maxLength: 20, nullable: true),
                    ReminderInfo = table.Column<string>(maxLength: 20, nullable: true),
                    ResourceID = table.Column<int>(type: "int(11)", nullable: true),
                    ResourceIDs = table.Column<string>(maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int(11)", nullable: true),
                    Subject = table.Column<string>(maxLength: 50, nullable: true),
                    TimeZoneId = table.Column<string>(maxLength: 20, nullable: true),
                    Type = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.UniqueID);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentsNumbers",
                columns: table => new
                {
                    AppointmentsNumbers = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    LabelID = table.Column<int>(type: "int(11)", nullable: true),
                    Number = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentsNumbers", x => x.AppointmentsNumbers);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    AttendanceID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    MemberID = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.AttendanceID);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceNumbers",
                columns: table => new
                {
                    AttendanceNumbersID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Number = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceNumbers", x => x.AttendanceNumbersID);
                });

            migrationBuilder.CreateTable(
                name: "DiagnosisName",
                columns: table => new
                {
                    DiagnosisNameID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiagnosisName = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosisName", x => x.DiagnosisNameID);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Picture = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestID);
                });

            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    LabelID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<int>(type: "int(11)", nullable: true),
                    DisplayName = table.Column<string>(maxLength: 50, nullable: true),
                    MenuCaption = table.Column<string>(maxLength: 50, nullable: true),
                    Shortcut = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.LabelID);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    LogID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ErrorCode = table.Column<int>(type: "int(11)", nullable: false),
                    Message = table.Column<string>(maxLength: 255, nullable: false),
                    RefreshCode = table.Column<int>(type: "int(11)", nullable: false),
                    StaffID = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.LogID);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    LoginID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Access = table.Column<int>(type: "int(11)", nullable: true),
                    LoginName = table.Column<string>(maxLength: 50, nullable: true),
                    LoginPass = table.Column<string>(maxLength: 50, nullable: true),
                    Pin = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.LoginID);
                });

            migrationBuilder.CreateTable(
                name: "MedicationName",
                columns: table => new
                {
                    MedicationNameID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicationName = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationName", x => x.MedicationNameID);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Aboriginal = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    Agency = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    Archived = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    BirthdayCard = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    CountryOfOrigin = table.Column<string>(maxLength: 200, nullable: true),
                    DateAltered = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateJoined = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    MobileNumber = table.Column<string>(maxLength: 20, nullable: true),
                    PostCode = table.Column<string>(maxLength: 7, nullable: true),
                    ReceiveByMail = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    ReceiveNewsletter = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    Sex = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    State = table.Column<string>(maxLength: 50, nullable: true),
                    StreetAddress = table.Column<string>(maxLength: 200, nullable: true),
                    Studying = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    Suburb = table.Column<string>(maxLength: 50, nullable: true),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    TelephoneNumber = table.Column<string>(maxLength: 20, nullable: true),
                    Volunteering = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    Working = table.Column<sbyte>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MemberID);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateMade = table.Column<DateTime>(type: "datetime", nullable: false),
                    MenuName = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    NotesID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Editable = table.Column<sbyte>(type: "tinyint(1)", nullable: true),
                    MemberID = table.Column<int>(type: "int(11)", nullable: true),
                    Notes = table.Column<string>(maxLength: 255, nullable: true),
                    StaffID = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.NotesID);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    UniqueID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Color = table.Column<int>(type: "int(11)", nullable: true),
                    CustomField1 = table.Column<string>(maxLength: 20, nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    ResourceID = table.Column<int>(type: "int(11)", nullable: false),
                    ResourceName = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.UniqueID);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LoginID = table.Column<int>(type: "int(11)", nullable: false),
                    StaffName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                    table.ForeignKey(
                        name: "FK_Staff_Login",
                        column: x => x.LoginID,
                        principalTable: "Login",
                        principalColumn: "LoginID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContactAddress = table.Column<string>(maxLength: 500, nullable: true),
                    ContactName = table.Column<string>(maxLength: 500, nullable: true),
                    ContactPhone = table.Column<string>(maxLength: 20, nullable: true),
                    ContactType = table.Column<string>(maxLength: 500, nullable: true),
                    MemberID = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contact_Member",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosis",
                columns: table => new
                {
                    DiagnosisID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DiagnosisNameID = table.Column<int>(type: "int(11)", nullable: false),
                    MemberID = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosis", x => x.DiagnosisID);
                    table.ForeignKey(
                        name: "FK_Diagnosis_Member",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medication",
                columns: table => new
                {
                    MedicationID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicationNameID = table.Column<int>(type: "int(11)", nullable: false),
                    MemberID = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medication", x => x.MedicationID);
                    table.ForeignKey(
                        name: "FK_Medication_Member",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                columns: table => new
                {
                    PictureID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MemberFacialRecognition = table.Column<byte[]>(nullable: true),
                    MemberID = table.Column<int>(type: "int(11)", nullable: false),
                    MemberPicture = table.Column<byte[]>(nullable: false),
                    PictureName = table.Column<string>(maxLength: 256, nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.PictureID);
                    table.ForeignKey(
                        name: "FK_Picture_Member",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SignIn",
                columns: table => new
                {
                    SigninID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GuestID = table.Column<int>(type: "int(11)", nullable: true),
                    MemberID = table.Column<int>(type: "int(11)", nullable: true),
                    MethodOfSigningIn = table.Column<string>(maxLength: 50, nullable: true),
                    Timein = table.Column<DateTime>(type: "datetime", nullable: true),
                    Timeout = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignIn", x => x.SigninID);
                    table.ForeignKey(
                        name: "FK_SignIn_Guest",
                        column: x => x.GuestID,
                        principalTable: "Guest",
                        principalColumn: "GuestID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SignIn_Member",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DebitSystem",
                columns: table => new
                {
                    DebitID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Details = table.Column<string>(maxLength: 200, nullable: true),
                    MemberID = table.Column<int>(type: "int(11)", nullable: false),
                    RunningTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StaffID = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DebitSystem", x => x.DebitID);
                    table.ForeignKey(
                        name: "FK_DebitSystem_Member",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "MemberID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DebitSystem_Staff",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lunch",
                columns: table => new
                {
                    LunchID = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Main = table.Column<sbyte>(type: "tinyint(1)", nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Paid = table.Column<sbyte>(type: "tinyint(1)", nullable: false),
                    StaffID = table.Column<int>(type: "int(11)", nullable: true),
                    TakeAway = table.Column<sbyte>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lunch", x => x.LunchID);
                    table.ForeignKey(
                        name: "FK_Lunch_Staff",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "StaffID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "FK_Contact_Member",
                table: "Contact",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "FK_DebitSystem_Member",
                table: "DebitSystem",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "FK_DebitSystem_Staff",
                table: "DebitSystem",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "FK_Diagnosis_Member",
                table: "Diagnosis",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "FK_Lunch_Staff",
                table: "Lunch",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "FK_Medication_Member",
                table: "Medication",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "FK_Picture_Member",
                table: "Picture",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "FK_SignIn_Guest",
                table: "SignIn",
                column: "GuestID");

            migrationBuilder.CreateIndex(
                name: "FK_SignIn_Member",
                table: "SignIn",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "FK_Staff_Login",
                table: "Staff",
                column: "LoginID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentMember");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "AppointmentsNumbers");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "AttendanceNumbers");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "DebitSystem");

            migrationBuilder.DropTable(
                name: "Diagnosis");

            migrationBuilder.DropTable(
                name: "DiagnosisName");

            migrationBuilder.DropTable(
                name: "Labels");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Lunch");

            migrationBuilder.DropTable(
                name: "Medication");

            migrationBuilder.DropTable(
                name: "MedicationName");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "Picture");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "SignIn");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
