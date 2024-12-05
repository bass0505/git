using Proyecto_ENE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ENE.DataAccess
{
    public class TrabajadorService
    {
        private TrabajadorRepository trabajadorRepository = TrabajadorRepository.GetInstancia();

        public void AgregarTrabajador(Trabajador trabajador)
        {
            if (string.IsNullOrEmpty(trabajador.Rut) || string.IsNullOrEmpty(trabajador.Nombre) || string.IsNullOrEmpty(trabajador.Direccion) || string.IsNullOrEmpty(trabajador.Telefono)
                        || string.IsNullOrEmpty(trabajador.ValorHora) || string.IsNullOrEmpty(trabajador.ValorHoraExtra)) 
            {
                throw new System.ArgumentException("Todos los campos deben tener valores");
            }
            trabajadorRepository.GuardarTrabajador(trabajador);
        }
        public void AgregarTrabajadorSueldo(Trabajador trabajador)
        {
            if (string.IsNullOrEmpty(trabajador.Rut) || string.IsNullOrEmpty(trabajador.Nombre) || string.IsNullOrEmpty(trabajador.Direccion) || string.IsNullOrEmpty(trabajador.SueldoLiquido))
            {
                throw new System.ArgumentException("Todos los campos deben tener valores");
            }
            trabajadorRepository.GuardarTrabajador(trabajador);
        }
        public void AgregarSueldo(Trabajador trabajador)
        {
            if (string.IsNullOrEmpty(trabajador.SueldoLiquido))
            {
                throw new System.ArgumentException("Calcule el Sueldo");
            }
            trabajadorRepository.GuardarTrabajador(trabajador);
        }


        public List<Trabajador> ObtenerTodosTrabajadores()
        {
            return trabajadorRepository.ObtenerTodosTrabajadores();
        }
        public Trabajador ObtenerTrabajadorPorRut(string ParametroRut)
        {
            return trabajadorRepository.ObtenerTrabajadorPorRut(ParametroRut);
        }
        public void EditarTrabajador(string rut, string nombre, string direccion, string sueldo)
        {
            trabajadorRepository.EditarTrabajador(rut, nombre, direccion, sueldo);
        }

        public bool EliminarTrabajador(string rut)
        {
            return trabajadorRepository.EliminarTrabajador(rut);
        }
    }
}
