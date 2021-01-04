using DayininCiftligiNetCore5.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Data
{
    public class DayiDbContext : DbContext
    {
        //public DayiDbContext(DbContextOptions<DayiDbContext> options) : base(options) 
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=dayininciftligi; integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //NavItems Table
            modelBuilder.Entity<NavItem>()
                .Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<NavItem>()
                .Property(n => n.Url)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<NavItem>()
                .Property(n => n.DisplayOrder)
                .HasDefaultValue(1)
                .HasMaxLength(2);
            modelBuilder.Entity<NavItem>()
                .Property(n => n.IsVisible)
                .HasDefaultValue(true);

            //HomeBanners Table
            modelBuilder.Entity<HomeBanner>()
                .Property(h => h.Header)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<HomeBanner>()
                .Property(h => h.Text)
                .IsRequired()
                .HasMaxLength(400);
            modelBuilder.Entity<HomeBanner>()
                .Property(h => h.BgImageUrl)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<HomeBanner>()
                .Property(h => h.ButtonText)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<HomeBanner>()
                .Property(h => h.ButtonUrl)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<HomeBanner>()
                .Property(h => h.IsVisible)
                .HasDefaultValue(true);

            //Products Table
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<Product>()
                .Property(p => p.ImageUrl)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Product>()
                .Property(p => p.ImageAltText)
                .HasMaxLength(255);
            modelBuilder.Entity<Product>()
                .Property(p => p.DisplayOrder)
                .HasDefaultValue(1)
                .HasMaxLength(2);
            modelBuilder.Entity<Product>()
               .Property(p => p.IsVisible)
               .HasDefaultValue(true);

            //Images Table
            modelBuilder.Entity<GalleryImage>()
                .Property(i => i.ImageUrl)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<GalleryImage>()
                .Property(i => i.ImageAltText)
                .HasMaxLength(255);
            modelBuilder.Entity<GalleryImage>()
                .Property(i => i.DisplayOrder)
                .HasDefaultValue(1)
                .HasMaxLength(2);
            modelBuilder.Entity<GalleryImage>()
               .Property(i => i.IsVisible)
               .HasDefaultValue(true);
            modelBuilder.Entity<GalleryImage>()
              .Property(i => i.IsHome)
              .HasDefaultValue(false);

            //Contacts Table
            modelBuilder.Entity<Contact>()
                .Property(c => c.Address)
                .HasMaxLength(255);
            modelBuilder.Entity<Contact>()
                .Property(c => c.City)
                .HasMaxLength(50);
            modelBuilder.Entity<Contact>()
                .Property(c => c.Email)
                .HasMaxLength(50);
            modelBuilder.Entity<Contact>()
                .Property(c => c.Phone)
                .HasMaxLength(20);
            modelBuilder.Entity<Contact>()
                .Property(c => c.GoogleMapsUrl)
                .HasMaxLength(500);
            modelBuilder.Entity<Contact>()
                .Property(c => c.FbUserName)
                .HasMaxLength(25);
            modelBuilder.Entity<Contact>()
                .Property(c => c.InstaUserName)
                .HasMaxLength(25);
            modelBuilder.Entity<Contact>()
               .Property(c => c.IsVisible)
               .HasDefaultValue(true);

            //Sections Table
            modelBuilder.Entity<Section>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<Section>()
                .Property(s => s.ComponentName)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Section>()
                .Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Section>()
                .Property(s => s.ButtonText)
                .HasMaxLength(100);
            modelBuilder.Entity<Section>()
                .Property(s => s.ButtonUrl)
                .HasMaxLength(255);
            modelBuilder.Entity<Section>()
                .Property(s => s.DisplayOrder)
                .HasDefaultValue(1)
                .HasMaxLength(2);
            modelBuilder.Entity<Section>()
               .Property(s => s.IsVisible)
               .HasDefaultValue(true);
            //Messages Table
            modelBuilder.Entity<Message>()
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Message>()
                .Property(m => m.Email)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Message>()
                .Property(m => m.Subject)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Message>()
                .Property(m => m.Text)
                .IsRequired()
                .HasMaxLength(1000);
            modelBuilder.Entity<Message>()
               .Property(m => m.IsRead)
               .HasDefaultValue(false);
            modelBuilder.Entity<Message>()
               .Property(m => m.IsArchived)
               .HasDefaultValue(false);
            modelBuilder.Entity<Message>()
               .Property(m => m.IsDeleted)
               .HasDefaultValue(false);
            //FooterWidgets Table
            modelBuilder.Entity<FooterWidget>()
                .Property(fw => fw.Header)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<FooterWidget>()
                .Property(fw => fw.Body)
                .IsRequired()
                .HasMaxLength(1000);
            modelBuilder.Entity<FooterWidget>()
                .Property(fw => fw.ImageUrl)
                .HasMaxLength(255);
            modelBuilder.Entity<FooterWidget>()
               .Property(fw => fw.IsVisible)
               .HasDefaultValue(false);
            //Blogs Table
            ///must bu uniqe
            modelBuilder.Entity<Blog>()
                .Property(m => m.Url)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Blog>()
                .Property(m => m.Header)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Blog>()
                .Property(m => m.SubHeader)
                .IsRequired()
                .HasMaxLength(150);
            modelBuilder.Entity<Blog>()
                .Property(m => m.CoverImageUrl)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Blog>()
                .Property(m => m.SmallImageUrl)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<Blog>()
                .Property(m => m.Text)
                .IsRequired();
            modelBuilder.Entity<Blog>()
               .Property(m => m.IsVisible)
               .HasDefaultValue(true);
            modelBuilder.Entity<Blog>()
               .Property(m => m.Created)
               .HasDefaultValue(DateTime.Now);
            //Subscribers Table
            modelBuilder.Entity<Subscriber>()
                .Property(s => s.Email)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Subscriber>()
               .Property(s => s.IsDeleted)
               .HasDefaultValue(false);
            //WebsiteDatas Table
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.Title)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.Description)
                .HasMaxLength(255);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.Keywords)
                .HasMaxLength(100);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.Author)
                .HasMaxLength(50);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.Owner)
                .HasMaxLength(50);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.CopyrightForMeta)
                .HasMaxLength(25);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.CopyrightForFooter)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.Favicon)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<WebsiteData>()
                .Property(wd => wd.Logo)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<WebsiteData>()
               .Property(s => s.IsVisible)
               .HasDefaultValue(false);
            //SocialMedias Table
            modelBuilder.Entity<SocialMedia>()
                .Property(sm => sm.Name)
                .IsRequired()
                .HasMaxLength(25);
            modelBuilder.Entity<SocialMedia>()
                .Property(sm => sm.Url)
                .IsRequired()
                .HasMaxLength(255);
            modelBuilder.Entity<SocialMedia>()
                .Property(sm => sm.Icon)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<SocialMedia>()
                .Property(sm => sm.DisplayOrder)
                .HasMaxLength(2)
                .HasDefaultValue(0);
            modelBuilder.Entity<SocialMedia>()
               .Property(s => s.IsVisible)
               .HasDefaultValue(true);

        }

        public DbSet<NavItem> NavItems { get; set; }
        public DbSet<HomeBanner> HomeBanners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<FooterWidget> FooterWidgets { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<WebsiteData> WebsiteDatas { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
