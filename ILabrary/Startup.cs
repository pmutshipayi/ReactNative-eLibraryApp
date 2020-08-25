using AutoMapper;
using ILabrary.Core;
using ILabrary.Data;
using ILabrary.Mappings;
using ILabrary.Mappings.Libraries;
using ILabrary.Services;
using ILabrary.Services.Libraries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace ILabrary
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;

            var dbExists = File.Exists($"{env.ContentRootPath}/Data/{AppDbContext.DbName}");
            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                if (!dbExists)
                {
                    // Create default data

                    db.AddRange(SampleData.GetSampleData());
                    db.SaveChanges();
                }
            }
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // register services

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ILibrarySessionService, LibrarySessionService>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IBookService, BookService>();

            var mappingConfig = new MapperConfiguration(x =>
            {
                x.AddProfile(new LibraryProfile());
                x.AddProfile(new BookProfile());
                x.AddProfile(new LibraryUserProfile());
                x.AddProfile(new UserMappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddEntityFrameworkSqlite()
                .AddDbContext<AppDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
