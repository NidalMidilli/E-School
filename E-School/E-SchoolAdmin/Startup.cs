using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_SchoolAdmin
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
            services.AddControllersWithViews();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<ITeacherService, TeacherManager>();
            services.AddScoped<ILessonService, LessonManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IStudentDAL, StudentDAL>();
            services.AddScoped<ITeacherDAL, TeacherDAL>();
            services.AddScoped<ILessonDAL, LessonDAL>();
            services.AddScoped<IUserDAL, UserDAL>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
            AddCookie(x =>
            {
                x.LoginPath = "/Login/LoginPanel";
            }
         );
            services.AddAuthenticationCore();
            //Bu k�sma kadar tan�mlamam
            services.AddHttpContextAccessor();
            //Role do�rulaman�n servisini ekliyoruz.
            services.AddAuthorization(options =>
            {
                options.AddPolicy("User",
                     policy => policy.RequireRole("User"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=LoginPanel}/{id?}");
            });
        }
    }
}