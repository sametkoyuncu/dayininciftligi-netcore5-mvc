using DayininCiftligiNetCore5.Data;
using DayininCiftligiNetCore5.EmailServices;
using DayininCiftligiNetCore5.Identity;
using DayininCiftligiNetCore5.Interfaces;
using DayininCiftligiNetCore5.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayininCiftligiNetCore5
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => 
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=dayininciftligi; integrated security=true;"));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
                options.Password.RequireNonAlphanumeric = false;

                //lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                //user
                //options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.AccessDeniedPath = "/AccessDenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".DayininCiftligi.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });

            //services.AddDbContext<DayiDbContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<INavItemRepository, NavItemRepository>();
            services.AddScoped<IHomeBannerRepository, HomeBannerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IGalleryImagesRepository, GalleryImagesRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IFooterWidgetRepository, FooterWidgetRepository>();
            services.AddScoped<ISubscriberRepository, SubscriberRepository>();
            services.AddScoped<IWebsiteDataRepository, WebsiteDataRepository>();
            services.AddScoped<ISocialMediaRepository, SocialMediaRepository>();

            services.AddScoped<IEmailSender, SmtpEmailSender>(i =>
                new SmtpEmailSender(
                        Configuration["EmailSender:Host"],
                        Configuration.GetValue<int>("EmailSender:Port"),
                        Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                        Configuration["EmailSender:UserName"],
                        Configuration["EmailSender:Password"]
                    )
            ); 

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //HomeController Routes
                endpoints.MapControllerRoute(
                    name: "Index",
                    pattern: "Index",
                    defaults: new { controller = "Home", action = "Index" }
                );
                endpoints.MapControllerRoute(
                    name: "Galeri",
                    pattern: "Galeri",
                    defaults: new { controller = "Home", action = "GalleryPage" }
                );

                //BlogController Routes
                //endpoints.MapControllerRoute(
                //    name: "SingleBlog",
                //    pattern: "{url}",
                //    defaults: new { controller = "Blog", action = "Details" }
                //);

                //social media create
                endpoints.MapControllerRoute(
                    name: "SocialMedia/Create",
                    pattern: "SocialMedia/Create",
                    defaults: new { area = "Admin", controller = "SocialMedia", action = "Create" }
                );

                //logosedit
                endpoints.MapControllerRoute(
                    name: "Admin/LogosEdit",
                    pattern: "Admin/LogosEdit",
                    defaults: new { area = "Admin", controller = "WebsiteData", action = "LogosEdit" }
                );

                //metadataedit
                endpoints.MapControllerRoute(
                    name: "Admin/MetaDataEdit",
                    pattern: "Admin/MetaDataEdit",
                    defaults: new { area = "Admin", controller = "WebsiteData", action = "MetaDataEdit" }
                );
                //confirmemail
                endpoints.MapControllerRoute(
                    name: "Admin/ConfirmEmail",
                    pattern: "Account/ConfirmEmail",
                    defaults: new { area = "Admin", controller = "Account", action = "ConfirmEmail" }
                );
                //resetpassword
                endpoints.MapControllerRoute(
                    name: "Admin/ResetPassword",
                    pattern: "Account/ResetPassword",
                    defaults: new { area = "Admin", controller = "Account", action = "ResetPassword" }
                );
                //forgotpassword
                endpoints.MapControllerRoute(
                    name: "Admin/ForgotPassword",
                    pattern: "ForgotPassword",
                    defaults: new { area = "Admin", controller = "Account", action = "ForgotPassword" }
                );
                //Admin Routes
                endpoints.MapControllerRoute(
                   name: "Admin/Login",
                   pattern: "Login",
                   defaults: new { area = "Admin", controller = "Account", action = "Login" }
               );
                endpoints.MapControllerRoute(
                   name: "Admin/Register",
                   pattern: "Register",
                   defaults: new { area = "Admin", controller = "Account", action = "Register" }
               );
                endpoints.MapControllerRoute(
                    name: "Admin/Index",
                    pattern: "Admin",
                    defaults: new { area = "Admin" , controller = "Home", action = "Index" }
                );
                //Default Router
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "admin/default",
                    pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
