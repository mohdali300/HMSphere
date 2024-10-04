using HMSphere.Domain.Entities;
using HMSphere.Infrastructure.DataContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HMSphere.MVC
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Add Identity
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<HmsContext>();

            //Add DbContext
            builder.Services.AddDbContext<HmsContext>(options =>
            options.UseSqlServer(builder.Configuration
            .GetConnectionString("DefaultConnection")));

            var app = builder.Build();
            //For Seeding Data 
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<HmsContext>();
                var usermanager = services.GetRequiredService<UserManager<ApplicationUser>>();
                await StoredContextSeed.SeedAsync(context);
               // await IdentitySeed.SeedUserAsync(usermanager);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
