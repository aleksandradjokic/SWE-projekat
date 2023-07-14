﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceByteBackend;

namespace ReceByteBackend.Migrations
{
    [DbContext(typeof(ReceByteContext))]
    [Migration("20210515212358_initBazaBezVirtualFja")]
    partial class initBazaBezVirtualFja
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.BookMark", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ReceptID");

                    b.ToTable("BookMark");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.Frizider", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("NamirniceID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("NamirniceID");

                    b.ToTable("Frizider");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.Komentar", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tekst");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ReceptID");

                    b.ToTable("Komentar");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.Namirnice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KcalVrednost")
                        .HasColumnType("int")
                        .HasColumnName("KcalVrednost");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Naziv");

                    b.Property<string>("Vrsta")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Vrsta");

                    b.HasKey("ID");

                    b.ToTable("Namirnice");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.OceneNaKom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("KomentarID")
                        .HasColumnType("int");

                    b.Property<int>("Ocena")
                        .HasColumnType("int")
                        .HasColumnName("Ocena");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("KomentarID");

                    b.ToTable("OceneNaKom");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.PrijavljeniKom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("KomentarID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("KomentarID");

                    b.ToTable("PrijavljeniKom");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.PrijavljeniKorisnici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrijavljenId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TuzibabaId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("PrijavljenId");

                    b.HasIndex("TuzibabaId");

                    b.ToTable("PrijavljeniKorisnici");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.PrijavljeniRecepti", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ReceptID");

                    b.ToTable("PrijavljeniRecepti");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.ReakcijaNaRecepte", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Ocena")
                        .HasColumnType("int")
                        .HasColumnName("Ocena");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ReceptID");

                    b.ToTable("ReakcijaNaRecepte");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.Recept", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojPorcija")
                        .HasColumnType("int")
                        .HasColumnName("BrojPorcija");

                    b.Property<string>("ImgPath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ImgPath");

                    b.Property<int>("KcalVrednost")
                        .HasColumnType("int")
                        .HasColumnName("KcalVrednost");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Naziv");

                    b.Property<string>("ObjavioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OdobrioId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Tekst");

                    b.HasKey("ID");

                    b.HasIndex("ObjavioId");

                    b.HasIndex("OdobrioId");

                    b.ToTable("Recept");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.ReceptiNamirnice", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("NamirniceID")
                        .HasColumnType("int");

                    b.Property<int?>("ReceptID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NamirniceID");

                    b.HasIndex("ReceptID");

                    b.ToTable("ReceptiNamirnice");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.BookMark", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ReceByteBackend.Models.Baza.Recept", "Recept")
                        .WithMany()
                        .HasForeignKey("ReceptID");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.Frizider", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ReceByteBackend.Models.Baza.Namirnice", "Namirnice")
                        .WithMany()
                        .HasForeignKey("NamirniceID");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Namirnice");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.Komentar", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ReceByteBackend.Models.Baza.Recept", "Recept")
                        .WithMany()
                        .HasForeignKey("ReceptID");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.OceneNaKom", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ReceByteBackend.Models.Baza.Komentar", "Komentar")
                        .WithMany()
                        .HasForeignKey("KomentarID");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Komentar");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.PrijavljeniKom", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ReceByteBackend.Models.Baza.Komentar", "Komentar")
                        .WithMany()
                        .HasForeignKey("KomentarID");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Komentar");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.PrijavljeniKorisnici", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "Prijavljen")
                        .WithMany()
                        .HasForeignKey("PrijavljenId");

                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "Tuzibaba")
                        .WithMany()
                        .HasForeignKey("TuzibabaId");

                    b.Navigation("Prijavljen");

                    b.Navigation("Tuzibaba");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.PrijavljeniRecepti", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ReceByteBackend.Models.Baza.Recept", "Recept")
                        .WithMany()
                        .HasForeignKey("ReceptID");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.ReakcijaNaRecepte", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ReceByteBackend.Models.Baza.Recept", "Recept")
                        .WithMany()
                        .HasForeignKey("ReceptID");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.Recept", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "Objavio")
                        .WithMany()
                        .HasForeignKey("ObjavioId");

                    b.HasOne("ReceByteBackend.Models.Baza.ApplicationUser", "Odobrio")
                        .WithMany()
                        .HasForeignKey("OdobrioId");

                    b.Navigation("Objavio");

                    b.Navigation("Odobrio");
                });

            modelBuilder.Entity("ReceByteBackend.Models.Baza.ReceptiNamirnice", b =>
                {
                    b.HasOne("ReceByteBackend.Models.Baza.Namirnice", "Namirnice")
                        .WithMany()
                        .HasForeignKey("NamirniceID");

                    b.HasOne("ReceByteBackend.Models.Baza.Recept", "Recept")
                        .WithMany()
                        .HasForeignKey("ReceptID");

                    b.Navigation("Namirnice");

                    b.Navigation("Recept");
                });
#pragma warning restore 612, 618
        }
    }
}
