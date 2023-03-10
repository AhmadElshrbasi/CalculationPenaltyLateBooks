// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleTouchTask.Server;

#nullable disable

namespace SimpleTouchTask.Server.Migrations
{
    [DbContext(typeof(SimpleTouchContext))]
    partial class SimpleTouchContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimpleTouchTask.Shared.Models.LibraryCountry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CurrencyKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PenaltyValueOneDay")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("libraryCountries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrencyKey = "EGP",
                            Name = "Egypt",
                            PenaltyValueOneDay = 40f
                        },
                        new
                        {
                            Id = 2,
                            CurrencyKey = "AED",
                            Name = "Emirate",
                            PenaltyValueOneDay = 5f
                        },
                        new
                        {
                            Id = 3,
                            CurrencyKey = "SAR",
                            Name = "Saudi",
                            PenaltyValueOneDay = 6f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
