using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrete;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.WebUI.EmailServices;
using ShopApp.WebUI.Identity;
using ShopApp.WebUI.Middlewares;

namespace ShopApp.WebUI
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationIdentityDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection"))); //AppSetting içinde connectionstring var

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()//dataların nerde saklanacağı bilgisi
                .AddDefaultTokenProviders();//Parola reset işlemi yapıldığında benzersiz token - kullanılacak provider

            services.Configure<IdentityOptions>(options =>
            {
                //password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;

                options.Lockout.MaxFailedAccessAttempts = 5;//kaç defa yanlış girebilsin
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);//ne kadar süre sonra pasif kalabilsin
                options.Lockout.AllowedForNewUsers = true;

                options.User.RequireUniqueEmail = true; //aynı mail adresi ile üyelik oluşturmama 

                options.SignIn.RequireConfirmedEmail = true; //mail onayı gereksin
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
             services.ConfigureApplicationCookie(options => //oluşan session tanıtma
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60); // 60 dk cookie kalabilir
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder
                {
                     HttpOnly = true,
                    Name=".ShopApp.Security.Cookie", //varsayılan isimi kullanmak yerine
                    SameSite = SameSiteMode.Strict //crosssite ataklarını engeller
                };

            });
            //hangi veritabanı kullanılacaksa burdan karar verilir ona göre işlem yapılır. (Oracle, MySQL,MSSQL)
            //IProduct,EfCoreProductDal
            //IProduct,MySQLProductDal

            services.AddScoped<IProductDal, EfCoreProductDal>();
            services.AddScoped<ICategoryDal, EfCoreCategoryDal>();
            services.AddScoped<ICartDal, EfCoreCartDal>();
            services.AddScoped<IOrderDal, EfCoreOrderDal>();
            services.AddScoped<IBrandDal, EfCoreBrandDal>();

            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IBrandService, BrandManager>();

            services.AddTransient<IEmailSender, EmailSender>();
            //services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //SeedDatabase.Seed();
            }
            // app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();
            app.CustomStaticFiles();
            // app.UseMvc(ConvfigureRoutes);
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                 name: "adminProductsEdit",
                 template: "admin/products",
                 defaults: new { controller = "Admin", action = "ProductList" }
               );

                routes.MapRoute(
                    name: "adminProducts",
                    template: "admin/products/{id?}",
                    defaults: new { controller = "Admin", action = "EditProduct" }
                );

                routes.MapRoute(
                  name: "cart",
                  template: "cart",
                  defaults: new { controller = "Cart", action = "Index" }
                );

                routes.MapRoute(
                  name: "orders",
                  template: "orders",
                  defaults: new { controller = "Cart", action = "GetOrders" }
                );


                routes.MapRoute(
                 name: "checkout",
                 template: "checkout",
                 defaults: new { controller = "Cart", action = "Checkout" }
                 );

                routes.MapRoute(
                  name: "products",
                  template: "products/{category?}",
                  defaults: new { controller = "Shop", action = "List" }
                );
                routes.MapRoute(
                  name: "brand",
                  template: "products/{brand?}",
                  defaults: new { controller = "Shop", action = "List" }
                );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );

            });

            //SeedIdentity.Seed(userManager, roleManager, Configuration).Wait(); //bekleyenleri çalıştır


        }
    }
}

