using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Arbol_Genealogico.Modelo.Servicios
{
    public class DataAccess
    {
        private string path;

        public DataAccess()
        {

        }

        public DataAccess(string path)
        {
            this.path = path;
        }

        public string Path { get => path; set => path = value; }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> personas = new List<Persona>();

            SqliteConnection connection = new SqliteConnection(this.path);

            try
            {
                connection.Open();                

                SqliteCommand command = new SqliteCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT all from Personas";
                command.Connection = connection;

                SqliteDataReader reader = command.ExecuteReader();

                while( reader.Read())
                {
                    DateTime_JsonConverter jsonConverter = new DateTime_JsonConverter();

                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string portrait = reader.GetString(3);
                    DateTime? fechaDeNacimiento = jsonConverter.ConvertFromJsonToDateTime(reader.GetString(4));
                    DateTime? fechadDeDefunción = jsonConverter.ConvertFromJsonToDateTime(reader.GetString(5));

                    Persona unaPersona = new Persona(id, nombre, apellido);
                    
                    if(portrait != null)
                    {
                        unaPersona.Portrait = portrait;
                    }
                    if(fechaDeNacimiento != null)
                    {
                        unaPersona.FechaDeNacimiento = fechaDeNacimiento;
                    }
                    if(fechadDeDefunción != null)
                    {
                        unaPersona.FechadDeDefunción = fechadDeDefunción;
                    }

                    personas.Add(unaPersona);
                }
            }
            catch(Exception message)
            {

            }


            return personas;
        }

        public void AgregarPersonaADB(Persona persona)
        {
            SqliteConnection connection = new SqliteConnection(this.path);
        }


    }
}
