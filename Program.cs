using PROG7311_OrderProcessingSystem.Services;

namespace PROG7311_OrderProcessingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //5th Solid Principle
            //Implement Dependency Inversion Principle (DIP)

            // Register services for Dependency Injection
            builder.Services.AddScoped<IOrderProcessor, OrderProcessingService>();
            builder.Services.AddScoped<INotificationSender, EmailNotificationService>();

            var app = builder.Build();

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
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

            app.Run();
        }
    }
}
