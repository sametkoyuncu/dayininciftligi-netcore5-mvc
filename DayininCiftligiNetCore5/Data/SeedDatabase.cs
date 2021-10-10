using DayininCiftligiNetCore5.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5.Data
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new DayiDbContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.NavItems.Count() == 0)
                {
                    context.NavItems.AddRange(NavItemsSeed);
                }
                if (context.HomeBanners.Count() == 0)
                {
                    context.HomeBanners.AddRange(HomeBannersSeed);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(ProductsSeed);
                }
                if (context.GalleryImages.Count() == 0)
                {
                    context.GalleryImages.AddRange(GalleryImagesSeed);
                }
                if (context.Contacts.Count() == 0)
                {
                    context.Contacts.AddRange(ContactsSeed);
                }
                if (context.Sections.Count() == 0)
                {
                    context.Sections.AddRange(SectionsSeed);
                }
                if (context.Blogs.Count() == 0)
                {
                    context.Blogs.AddRange(BlogsSeed);
                }
                if (context.FooterWidgets.Count() == 0)
                {
                    context.FooterWidgets.AddRange(FooterWidgetsSeed);
                }
                if (context.WebsiteDatas.Count() == 0)
                {
                    context.WebsiteDatas.AddRange(WebsiteDatasSeed);
                }
                if (context.SocialMedias.Count() == 0)
                {
                    context.SocialMedias.AddRange(SocialMediasSeed);
                }
                //if (context.Products.Count() == 0)
                //{
                //    context.Products.AddRange(Products);
                //    context.AddRange(ProductCategories);
                //}
                context.SaveChanges();
            }
        }

        private static NavItem[] NavItemsSeed = {
            new NavItem(){Name="Anasayfa", Url="giris", IsVisible=true},
            new NavItem(){Name="Ürünler", Url="urunler", IsVisible=true},
            new NavItem(){Name="Galeri", Url="galeri", IsVisible=true},
            new NavItem(){Name="Blog", Url="blog", IsVisible=false},
            new NavItem(){Name="İletişim", Url="iletisim", IsVisible=true},
        };

        private static HomeBanner[] HomeBannersSeed = {
            new HomeBanner(){
                Header="Hoş Geldiniz",
                Text="Merhabalar, sitemizi kullanarak hakkımızda detaylı bilgiye ulaşabilir, bizimle irtibata geçebilir veya kendi ürettiğimiz doğal ürünlerden sipariş verebilirsiniz.",
                BgImageUrl="home-banner.jpg",
                ButtonText="İLETİŞİME GEÇİN",
                ButtonUrl="iletisim",
                IsVisible=true
            }
        };

        private static Product[] ProductsSeed = {
            new Product(){Name="Kurbanlık", ImageUrl="1.png", ImageAltText="Kurbanlık"},
            new Product(){Name="Adaklık", ImageUrl="2.png", ImageAltText="Adaklık"},
            new Product(){Name="Günlük Süt", ImageUrl="3.png", ImageAltText="Günlük Süt"},
            new Product(){Name="Yumurta", ImageUrl="4.png", ImageAltText="Yumurta"},
            new Product(){Name="Sebze Meyve", ImageUrl="5.png", ImageAltText="Sebze Meyve"}
        };

        private static GalleryImage[] GalleryImagesSeed = {
            new GalleryImage(){ImageUrl="images/1.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/2.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/3.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/4.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/5.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/6.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/7.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/8.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/9.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/10.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/11.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/12.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/13.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/14.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/15.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/16.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/17.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/18.jpg", ImageAltText="Dayının Çiftliğinden Görseller"},
            new GalleryImage(){ImageUrl="images/19.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true},
            new GalleryImage(){ImageUrl="images/20.jpg", ImageAltText="Dayının Çiftliğinden Görseller", IsHome=true}
        };

        private static Contact[] ContactsSeed = {
            new Contact(){
                Address="Çayırbaşı Köyü",
                City="Şile / İSTANBUL",
                Email="dayininciftligisile@gmail.com",
                Phone="+90 (533) 931 8226",
                GoogleMapsUrl="https://maps.google.com/maps?width=700&amp;height=480&amp;hl=tr&amp;q=%C3%87ay%C4%B1rba%C5%9F%C4%B1%2C%20%C5%9Eile%2C%20%C4%B0stanbul%2C%20Turkey+(Day%C4%B1n%C4%B1n%20%C3%87iftli%C4%9Fi)&amp;ie=UTF8&amp;t=&amp;z=12&amp;iwloc=B&amp;output=embed",
                FbUserName="dayininciftligi",
                InstaUserName="dayininciftligi"
            }
        };

        private static Section[] SectionsSeed = {
            new Section(){Name="Ürünler", ComponentName="ProductsComponent", Description="Ürünler", DisplayOrder=1},
            new Section(){Name="Galeri", ComponentName="GalleryComponent", Description="Dayının Çiftliğinden Görseller", ButtonText="Daha fazla görsel için tıklayınız -->", DisplayOrder=2},
            new Section(){Name="Blog", ComponentName="BlogComponent", Description="Son eklenen yazılarımız..", ButtonText="Daha fazla yazı için tıklayınız -->", DisplayOrder=3, IsVisible=false},
            new Section(){Name="İletişim", ComponentName="ContactComponent", Description="İletişim", DisplayOrder=4}
        };

        private static Blog[] BlogsSeed = {
            new Blog(){
                Header="Şampiyon: Paşa",
                SubHeader="Şile buzağı güzellik yarışmasına katıldık",
                Url="/blog/sampiyon-pasa",
                CoverImageUrl="blogCovers/pasa-kapak.jpg",
                SmallImageUrl="blogSmalls/buzagi-blog-gorsel.jpg",
                Text="Blog Text Here"
            }
        };

        private static FooterWidget[] FooterWidgetsSeed = {
            new FooterWidget(){
                Header="Hakkımızda",
                Body="Dayının Çiftliği, İstanbul Şile'de kurbanlık, adaklık ve süt üretimi yapan bir aile işletmesidir.",
                IsVisible=true
            },
            new FooterWidget(){
                Header="Haber Bülteni",
                Body="Çiftliğimizden güncel haberler için haber bültenimize abone olabilirsiniz. (Örneğin: Kurban satışları vb.)",
                ImageUrl="logo-foto.png",
                IsVisible=true
            }
        };

        private static WebsiteData[] WebsiteDatasSeed = {
            new WebsiteData(){
                Title="Dayının Çiftliği | Kurbanlık - Adaklık - Günlük Süt",
                Description="Dayının Çiftliği İstanbul Şile'de kurbanlık, adaklık ve süt üretimi yapan bir aile işletmesidir.",
                Keywords="kurbanlık, adaklık, süt",
                Author="Samet Koyuncu",
                Owner="Samet Koyuncu",
                CopyrightForMeta="(c) 2020",
                CopyrightForFooter="from DATABASE",
                Favicon="favicon.png",
                Logo="logo.png",
                IsVisible=true
            }
        };

        private static SocialMedia[] SocialMediasSeed = {
            new SocialMedia(){Name="Facebook", Url="https://www.facebook.com/dayininciftligi/", Icon="ti-facebook", DisplayOrder=1},
            new SocialMedia(){Name="İnstagram", Url="https://www.instagram.com/dayininciftligi/", Icon="ti-instagram", DisplayOrder=2},
            new SocialMedia(){Name="Youtube", Url="https://www.youtube.com/channel/UCzXD8w7Amtq1-HL_jwmXVgw", Icon="ti-youtube", DisplayOrder=3}
        };
    }
}
