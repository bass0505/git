using Proyecto_ENE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ENE.DataAccess
{
    public class TrabajadorRepository
    {
        public static TrabajadorRepository instancia;
        
        private List<Trabajador> listaTrabajadores = new List<Trabajador>();

        private TrabajadorRepository() { }
        public static TrabajadorRepository GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new TrabajadorRepository();
            }
            return instancia;
        }
        public void GuardarTrabajador(Trabajador trabajador)
        {
            listaTrabajadores.Add(trabajador);
        }
        public List<Trabajador> ObtenerTodosTrabajadores()
        {
            return listaTrabajadores;
        }
        public Trabajador ObtenerTrabajadorPorRut(string ParametroRut)
        {
            return listaTrabajadores.Find(t => t.Rut == ParametroRut);
        }
        public bool EditarTrabajador(string rut, string nuevoNombre, string nuevaDireccion, string nuevoSueldo)
        {

            Trabajador trabajador = ObtenerTrabajadorPorRut(rut);
            if (trabajador != null)
            {
                trabajador.Nombre = nuevoNombre;
                trabajador.Direccion = nuevaDireccion;
                trabajador.SueldoLiquido = nuevoSueldo;
               
                

                return true;
            }
            return false;

        }

        public bool EliminarTrabajador(string rut)
        {
            Trabajador trabajador = ObtenerTrabajadorPorRut(rut);
            if (trabajador != null)
            {
                listaTrabajadores.Remove(trabajador);
                return true; 
            }
            return false; 
        }
    }
}
