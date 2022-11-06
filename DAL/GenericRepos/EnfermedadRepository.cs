using DAL.Interfaces;

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GenericRepos
{
    //public class EnfermedadRepository : IGenericRepository<enfer>
    //{
    //    private readonly SysCExpertContext _context;
    //    public EnfermedadRepository(SysCExpertContext context)
    //    {
    //        _context = context;
    //    }
    //    public void Delete(Enfermedads guid)
    //    {
    //        var r = _context.Enfermedads.FirstOrDefault(x => x.ID == guid.ID);
    //        if (r != null)
    //        {
    //            _context.Enfermedads.Remove(r);
    //            _context.SaveChanges();
    //        }
    //    }

    //    public IEnumerable<Enfermedad> GetAll(Enfermedad parameters = null)
    //    {
    //        return _context.Enfermedad.ToList();
    //    }

    //    public Enfermedad GetOne(int? guid)
    //    {
    //        var r = _context.Enfermedad.FirstOrDefault(x => x.ID == guid);

    //        return r;
    //    }

    //    public void Insert(Enfermedad obj)
    //    {
    //        _context.Enfermedad.Add(obj);
    //        _context.SaveChanges();
    //    }

    //    public void Update(Enfermedad obj)
    //    {
    //        var enfermedad = _context.Enfermedad.FirstOrDefault(x => x.ID == obj.ID);
    //        if (enfermedad != null)
    //        {
    //            enfermedad.ID = obj.ID;
    //            enfermedad.Descripcion = obj.Descripcion;

    //            _context.Update(enfermedad);
    //            _context.SaveChanges();

    //        }
    //    }
    //}
}
