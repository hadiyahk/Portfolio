namespace Portfolio
{
    public class Program
    {
        public static void Main(string[] args)


        {
            var builder = WebApplication.CreateBuilder(args);

         
            var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
            builder.WebHost.UseUrls($"http://0.0.0.0:{port}");

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }
    }
}
