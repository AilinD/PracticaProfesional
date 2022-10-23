using DAL.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;


namespace DAL.Factory
{
    static class FactoryDAL
    {
        /// <summary>
        /// String de repositorio. Indica donde se ubican los repositorios.
        /// </summary>
        readonly static string repository;

        /// <summary>
        /// Instancia de repositorio de clientes.
        /// </summary>
        public static IGenericRepository<Paciente> PatientRepo { get; private set; }



        //MovieRepository = CreateInstance<Movie>("MoviesRepository");
        //RoomRepository = CreateInstance<Room>("RoomsRepository");
        //SessionRepository = CreateInstance<Session>("SessionRepository");
        //TicketRepository = CreateInstance<Ticket>("TicketsRepository");
    }


    //private static IGenericRepository<T> CreateInstance<T>(string type) where T : class, new()
    //{
    //    return (IGenericRepository<T>)Activator.CreateInstance(Type.GetType("Cinema." + repository + "." + type));
    //}

}

