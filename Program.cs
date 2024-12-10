using AForge.Video.DirectShow;
using Microsoft.Extensions.DependencyInjection;
using Pilak.Database;

namespace Pilak
{
    internal static class Program
    {
        private static ServiceProvider? _serviceProvider;

        [STAThread]
        private static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using var scope = _serviceProvider.CreateScope();
            var mainForm = scope.ServiceProvider.GetRequiredService<FormMain>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>();

            services.AddScoped<ILicenseRepository, LicenseRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();

            services.AddTransient<FormMain>();
            services.AddTransient<FormPersonInfo>();

            services.AddScoped(provider => new FilterInfoCollection(FilterCategory.VideoInputDevice));
            services.AddScoped<VideoCaptureDevice>();
        }
    }
}