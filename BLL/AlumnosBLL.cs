using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class AlumnosBLL
    {   
        public static List<Alumno> ListaAlumnos=new List<Alumno>();
        public static void Crear (Alumno alumno) //CREAR
        {
            using (GestionAlumnoEntities db=new GestionAlumnoEntities ()) 
            {
                db.Alumno.Add(alumno);
                db.SaveChanges();
            }

        }

        public static void Actualizar(Alumno alumno)
        {
            using(GestionAlumnoEntities db=new GestionAlumnoEntities())
            {
                Alumno ALUMNOActualizar = new Alumno();
                ALUMNOActualizar = db.Alumno.First(e => e.ID == alumno.ID);
                ALUMNOActualizar.Nombre = alumno.Nombre;
                ALUMNOActualizar.Apellido = alumno.Apellido;
                ALUMNOActualizar.Nacionalidad = alumno.Nacionalidad;
                ALUMNOActualizar.Fecha_De_Nacimiento = alumno.Fecha_De_Nacimiento;
                ALUMNOActualizar.Edad = alumno.Edad;
                ALUMNOActualizar.Procedencia = alumno.Procedencia;
                ALUMNOActualizar.idCiudad = alumno.idCiudad;

                db.SaveChanges() ;
            }

        }
        
        public static void Eliminar (int id) //ELIMINAR
        {
            using (GestionAlumnoEntities db = new GestionAlumnoEntities())
            {
                Alumno alumno = new Alumno();
                alumno = db.Alumno.First(e => e.ID == id);
                db.Alumno.Remove(alumno );
                db.SaveChanges();

            }
        }

       


        public static void BuscarNombreApellido(string Criterio)
        {
            using (GestionAlumnoEntities db = new GestionAlumnoEntities())
            {
                ListaAlumnos = db.Alumno.Where(e => e.Nombre.Contains(Criterio)||
                e.Apellido.Contains(Criterio)).ToList();    
                

                
            }  
        }
    }
}
