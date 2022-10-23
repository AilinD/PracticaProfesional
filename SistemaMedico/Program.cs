using AutoMapper;
using BLL;
using BLL.Interfaces;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.BLL;
using Services.BLL.Dto;
using Services.Logger;
using Services.MapperConfig;
using UI;
using UI.Generales;
using UI.Recepcionista;

namespace SistemaMedico
{
    public class Program
    {
        private readonly IGenericBusiness<PacienteDto> business;

        public Program(IGenericBusiness<PacienteDto> genericBusiness)
        {
            business = genericBusiness;
            
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new Login());
            //Application.Run(new ModificaPaciente(business));

            //Application.Run(new MenuPrincipal());


            ConfigureServices.AddServices();

        }
    }
}