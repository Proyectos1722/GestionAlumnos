using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class CiudadesBLL
    {
        public static List<Ciudades> ListaCiudades = new List<Ciudades>();

        public static object ListCiudades { get;  set; }

        public static void Crear(Ciudades ciudades) //CREAR
        {
            using (GestionAlumnoEntities db = new GestionAlumnoEntities())
            {
                db.Ciudades.Add(ciudades);
                db.SaveChanges();
            }
        }

        public static void Actualizar(Ciudades ciudades)
        {
            using (GestionAlumnoEntities db = new GestionAlumnoEntities())
            {
                Ciudades CIUDADActualizar = new Ciudades();
                CIUDADActualizar = db.Ciudades.First(e => e.idCiudad == ciudades.idCiudad);
                CIUDADActualizar.idCiudad = ciudades.idCiudad;
                // ... otros campos de la entidad Ciudad
                db.SaveChanges();
            }
            
        }
     
        public static List<Ciudades> GetCiudades()
        {
           



            using (GestionAlumnoEntities db = new GestionAlumnoEntities())
            {
                return db.Ciudades.ToList();
            }
        }
        public static void Eliminar(int id) //ELIMINAR
        {
            using (GestionAlumnoEntities db = new GestionAlumnoEntities())
            {
                Ciudades ciudades = new Ciudades();
                ciudades = db.Ciudades.First(e => e.idCiudad == id);
                db.Ciudades.Remove(ciudades);
                db.SaveChanges();
            }
            
        }

        public static void BuscarNombre(string Criterio)
        {
            using (GestionAlumnoEntities db = new GestionAlumnoEntities())
            {
                ListaCiudades = db.Ciudades.Where(e => e.Nciudad.Contains(Criterio)).ToList();
            }
        }
    }
    
}
