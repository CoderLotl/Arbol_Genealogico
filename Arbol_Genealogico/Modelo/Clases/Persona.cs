using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol_Genealogico.Modelo
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private string portrait;
        private DateTime? fechaDeNacimiento;
        private DateTime? fechadDeDefunción;

        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;            
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.fechadDeDefunción = fechadDeDefunción;
        }

        public Persona(int id, string nombre, string apellido, string portrait, DateTime fechaDeNacimiento, DateTime fechadDeDefunción)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.portrait = portrait;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.fechadDeDefunción = fechadDeDefunción;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Portrait { get => portrait; set => portrait = value; }
        public DateTime? FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public DateTime? FechadDeDefunción { get => fechadDeDefunción; set => fechadDeDefunción = value; }
    }
}
