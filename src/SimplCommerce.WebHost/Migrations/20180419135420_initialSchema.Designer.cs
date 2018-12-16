﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SimplCommerce.Module.Core.Data;
using SimplCommerce.Module.Core.Models;
using System;

namespace SimplCommerce.WebHost.Migrations
{
    [DbContext(typeof(SimplDbContext))]
    [Migration("20180419135420_initialSchema")]
    partial class initialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Core_RoleClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserClaim");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<long>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserLogin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("Core_UserToken");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City");

                    b.Property<string>("ContactName");

                    b.Property<long>("CountryId");

                    b.Property<long?>("DistrictId");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalCode");

                    b.Property<long>("StateOrProvinceId");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("StateOrProvinceId");

                    b.ToTable("Core_Address");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.AppSetting", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsVisibleInCommonSettingPage");

                    b.Property<string>("Key");

                    b.Property<string>("Module");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Core_AppSetting");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code2");

                    b.Property<string>("Code3");

                    b.Property<bool>("IsBillingEnabled");

                    b.Property<bool>("IsCityEnabled");

                    b.Property<bool>("IsDistrictEnabled");

                    b.Property<bool>("IsPostalCodeEnabled");

                    b.Property<bool>("IsShippingEnabled");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Core_Country");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.CustomerGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Core_CustomerGroup");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.District", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<long>("StateOrProvinceId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("StateOrProvinceId");

                    b.ToTable("Core_District");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Entity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("EntityId");

                    b.Property<long>("EntityTypeId");

                    b.Property<string>("Name");

                    b.Property<string>("Slug");

                    b.HasKey("Id");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Core_Entity");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.EntityType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsMenuable");

                    b.Property<string>("Name");

                    b.Property<string>("RoutingAction");

                    b.Property<string>("RoutingController");

                    b.HasKey("Id");

                    b.ToTable("Core_EntityType");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Media", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption");

                    b.Property<string>("FileName");

                    b.Property<int>("FileSize");

                    b.Property<int>("MediaType");

                    b.HasKey("Id");

                    b.ToTable("Core_Media");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Core_Role");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.StateOrProvince", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CountryCode");

                    b.Property<long>("CountryId");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Core_StateOrProvince");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<long?>("DefaultBillingAddressId");

                    b.Property<long?>("DefaultShippingAddressId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<Guid>("UserGuid");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<long?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("DefaultBillingAddressId");

                    b.HasIndex("DefaultShippingAddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("VendorId");

                    b.ToTable("Core_User");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.UserAddress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AddressId");

                    b.Property<int>("AddressType");

                    b.Property<DateTimeOffset?>("LastUsedOn");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserAddress");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.UserCustomerGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CustomerGroupId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CustomerGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Core_UserCustomerGroup");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.UserRole", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<long>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("Core_UserRole");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Vendor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<string>("SeoTitle");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("Core_Vendor");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Widget", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("CreateUrl");

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("EditUrl");

                    b.Property<bool>("IsPublished");

                    b.Property<string>("Name");

                    b.Property<string>("ViewComponentName");

                    b.HasKey("Id");

                    b.ToTable("Core_Widget");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.WidgetInstance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedOn");

                    b.Property<string>("Data");

                    b.Property<int>("DisplayOrder");

                    b.Property<string>("HtmlData");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("PublishEnd");

                    b.Property<DateTimeOffset?>("PublishStart");

                    b.Property<DateTimeOffset>("UpdatedOn");

                    b.Property<long>("WidgetId");

                    b.Property<long>("WidgetZoneId");

                    b.HasKey("Id");

                    b.HasIndex("WidgetId");

                    b.HasIndex("WidgetZoneId");

                    b.ToTable("Core_WidgetInstance");
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.WidgetZone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Core_WidgetZone");
                });

            modelBuilder.Entity("SimplCommerce.Module.Localization.Models.Culture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Localization_Culture");
                });

            modelBuilder.Entity("SimplCommerce.Module.Localization.Models.Resource", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CultureId");

                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CultureId");

                    b.ToTable("Localization_Resource");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Address", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.StateOrProvince", "StateOrProvince")
                        .WithMany()
                        .HasForeignKey("StateOrProvinceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.District", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.StateOrProvince", "StateOrProvince")
                        .WithMany()
                        .HasForeignKey("StateOrProvinceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.Entity", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.StateOrProvince", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.Country", "Country")
                        .WithMany("StatesOrProvinces")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.User", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.UserAddress", "DefaultBillingAddress")
                        .WithMany()
                        .HasForeignKey("DefaultBillingAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.UserAddress", "DefaultShippingAddress")
                        .WithMany()
                        .HasForeignKey("DefaultShippingAddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.Vendor")
                        .WithMany("Users")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.UserAddress", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.Address", "Address")
                        .WithMany("UserAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.User", "User")
                        .WithMany("UserAddresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.UserCustomerGroup", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.CustomerGroup", "CustomerGroup")
                        .WithMany("Users")
                        .HasForeignKey("CustomerGroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.User", "User")
                        .WithMany("CustomerGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.UserRole", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Core.Models.WidgetInstance", b =>
                {
                    b.HasOne("SimplCommerce.Module.Core.Models.Widget", "Widget")
                        .WithMany()
                        .HasForeignKey("WidgetId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SimplCommerce.Module.Core.Models.WidgetZone", "WidgetZone")
                        .WithMany()
                        .HasForeignKey("WidgetZoneId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SimplCommerce.Module.Localization.Models.Resource", b =>
                {
                    b.HasOne("SimplCommerce.Module.Localization.Models.Culture", "Culture")
                        .WithMany("Resources")
                        .HasForeignKey("CultureId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}