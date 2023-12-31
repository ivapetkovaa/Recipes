﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recipes.Models;

#nullable disable

namespace Recipes.Migrations
{
    [DbContext(typeof(RecipesContext))]
    partial class RecipesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Recipes.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAlergen")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Recipes.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Complexity")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PreparationTime")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Recipe", (string)null);
                });

            modelBuilder.Entity("Recipes.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("Recipes.Models.RecipeStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeSteps");
                });

            modelBuilder.Entity("Recipes.Models.RecipeIngredient", b =>
                {
                    b.HasOne("Recipes.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .IsRequired()
                        .HasConstraintName("FK_RecipeIngredients_Ingredients");

                    b.HasOne("Recipes.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .IsRequired()
                        .HasConstraintName("FK_RecipeIngredients_Recipe");

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Recipes.Models.RecipeStep", b =>
                {
                    b.HasOne("Recipes.Models.Recipe", "Recipe")
                        .WithMany("RecipeSteps")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("FK_RecipeSteps_Recipe");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Recipes.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("Recipes.Models.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");

                    b.Navigation("RecipeSteps");
                });
#pragma warning restore 612, 618
        }
    }
}
