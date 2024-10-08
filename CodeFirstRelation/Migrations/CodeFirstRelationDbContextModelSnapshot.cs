﻿using CodeFirstRelation.Context;
using System.Reflection.Emit;

namespace CodeFirstRelation.Migrations
{
    [DbContext(typeof(CodeFirstRelationDbContext))]
    partial class CodeFirstRelationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Code_First_Relation.Entities.PostEntity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Content")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreateDate")
                    .HasColumnType("datetime2");

                b.Property<bool>("IsDelete")
                    .HasColumnType("bit");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("Posts");
            });

            modelBuilder.Entity("Code_First_Relation.Entities.UserEntity", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("CreateDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsDelete")
                    .HasColumnType("bit");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Users");
            });

            modelBuilder.Entity("Code_First_Relation.Entities.PostEntity", b =>
            {
                b.HasOne("Code_First_Relation.Entities.UserEntity", "User")
                    .WithMany("Posts")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("User");
            });

            modelBuilder.Entity("Code_First_Relation.Entities.UserEntity", b =>
            {
                b.Navigation("Posts");
            });
#pragma warning restore 612, 618
        }
    }
}
