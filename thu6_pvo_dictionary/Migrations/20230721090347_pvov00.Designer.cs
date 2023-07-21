﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using thu6_pvo_dictionary.Models.DataContext;

#nullable disable

namespace thu6_pvo_dictionary.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230721090347_pvov00")]
    partial class pvov00
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.AuditLog", b =>
                {
                    b.Property<int>("audit_log_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("action_type")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("reference")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("screen_info")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("audit_log_id");

                    b.ToTable("audit_logs");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Concept", b =>
                {
                    b.Property<int>("concept_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("dictionary_id")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("concept_id");

                    b.ToTable("concepts");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.ConceptLink", b =>
                {
                    b.Property<int>("concept_link_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("concept_link_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("concept_link_type")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.Property<int>("sys_concept_link_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("concept_link_id");

                    b.ToTable("concept_links");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.ConceptRelationship", b =>
                {
                    b.Property<int>("concept_relationship_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("concept_id")
                        .HasColumnType("int");

                    b.Property<int>("concept_link_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("dictionary_id")
                        .HasColumnType("int");

                    b.Property<int>("parent_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("concept_relationship_id");

                    b.ToTable("concept_relationships");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.ConceptSearchHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("dictionary_id")
                        .HasColumnType("int");

                    b.Property<string>("list_concept_search")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("modified_date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("conceptSearchHistories");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Dialect", b =>
                {
                    b.Property<int>("dialect_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("dialect_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("dialect_type")
                        .HasColumnType("int");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.Property<int>("sys_dialect_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("dialect_id");

                    b.ToTable("dialects");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Dictionary", b =>
                {
                    b.Property<int>("dictionary_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("dictionary_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("last_view_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("dictionary_id");

                    b.ToTable("dictionaries");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Example", b =>
                {
                    b.Property<int>("example_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("detail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("detail_html")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("dialect_id")
                        .HasColumnType("int");

                    b.Property<int>("dictionary_id")
                        .HasColumnType("int");

                    b.Property<int>("mode_id")
                        .HasColumnType("int");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("nuance_id")
                        .HasColumnType("int");

                    b.Property<int>("register_id")
                        .HasColumnType("int");

                    b.Property<int>("tone_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("example_id");

                    b.ToTable("examples");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.ExampleLink", b =>
                {
                    b.Property<int>("example_link_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("dictionary_id")
                        .HasColumnType("int");

                    b.Property<string>("example_link_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("example_link_type")
                        .HasColumnType("int");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.Property<int>("sys_example_link_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("example_link_id");

                    b.ToTable("example_links");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.ExampleRelationship", b =>
                {
                    b.Property<int>("example_relationship_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("concept_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("dictionary_id")
                        .HasColumnType("int");

                    b.Property<int>("example_id")
                        .HasColumnType("int");

                    b.Property<int>("example_link_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("example_relationship_id");

                    b.HasIndex("example_link_id");

                    b.ToTable("example_relationships");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Mode", b =>
                {
                    b.Property<int>("mode_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("mode_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("mode_type")
                        .HasColumnType("int");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.Property<int>("sys_mode_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("mode_id");

                    b.ToTable("modes");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Nuance", b =>
                {
                    b.Property<int>("nuance_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("nuance_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("nuance_type")
                        .HasColumnType("int");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.Property<int>("sys_nuance_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("nuance_id");

                    b.ToTable("nuance");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Register", b =>
                {
                    b.Property<int>("register_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("register_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("register_type")
                        .HasColumnType("int");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.Property<int>("sys_register_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("register_id");

                    b.ToTable("registers");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.Tone", b =>
                {
                    b.Property<int>("tone_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("sort_order")
                        .HasColumnType("int");

                    b.Property<int>("sys_tone_id")
                        .HasColumnType("int");

                    b.Property<string>("tone_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("tone_type")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("tone_id");

                    b.ToTable("tones");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("avatar")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("display_name")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("full_name")
                        .HasColumnType("longtext");

                    b.Property<string>("otp")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("position")
                        .HasColumnType("longtext");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("user_id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            user_id = 1,
                            avatar = "",
                            birthday = new DateTime(2000, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            created_date = new DateTime(2023, 7, 21, 16, 3, 47, 285, DateTimeKind.Local).AddTicks(785),
                            display_name = "test",
                            email = "test@gmail.com",
                            full_name = "test",
                            otp = "",
                            password = "test",
                            position = "test",
                            status = 1,
                            updated_date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            user_name = "test"
                        });
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.UserSetting", b =>
                {
                    b.Property<int>("user_setting_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("setting_key")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("setting_value")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("updated_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("user_setting_id");

                    b.ToTable("user_settings");
                });

            modelBuilder.Entity("thu6_pvo_dictionary.Models.Entity.ExampleRelationship", b =>
                {
                    b.HasOne("thu6_pvo_dictionary.Models.Entity.ExampleLink", "ExampleLink")
                        .WithMany()
                        .HasForeignKey("example_link_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExampleLink");
                });
#pragma warning restore 612, 618
        }
    }
}
