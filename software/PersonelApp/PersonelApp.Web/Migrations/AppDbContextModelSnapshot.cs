﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonelApp.Web.Models;

#nullable disable

namespace PersonelApp.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PersonelApp.Web.Models.BlogModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bloglar");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.DerslerAyrintiModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DersContent1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersContent2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersContent3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<string>("DersImg1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersImg2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersImg3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersLink1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersLink2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersLink3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersTitle1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersTitle2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersTitle3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Semestr")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DersId")
                        .IsUnique();

                    b.ToTable("DersAyrintilar");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.DerslerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Dersler");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.HomeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Home");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.IletisimModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Iletisim");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.KurslarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VideoNumber")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kurslar");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.YoneticiModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departmant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Github")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Linkedin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yonetici");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.DerslerAyrintiModel", b =>
                {
                    b.HasOne("PersonelApp.Web.Models.DerslerModel", "Dersler")
                        .WithOne("DersAyrintilar")
                        .HasForeignKey("PersonelApp.Web.Models.DerslerAyrintiModel", "DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dersler");
                });

            modelBuilder.Entity("PersonelApp.Web.Models.DerslerModel", b =>
                {
                    b.Navigation("DersAyrintilar")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
