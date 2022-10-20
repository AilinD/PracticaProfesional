using AutoMapper;
using BLL;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.MapperConfig;
using UI;

namespace SistemaMedico
{
    public class Program
    {
        private IConfiguration _configuration { get; set; }

        public Program(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

            var serviceCollection = new ServiceCollection();
            {
                serviceCollection.AddSingleton<PatientRepository>();
                serviceCollection.AddSingleton<PatientService>();
                serviceCollection.AddSingleton<LoginService>();
            }

            ConfigureServices.AddServices(serviceCollection);

        }
    }
}