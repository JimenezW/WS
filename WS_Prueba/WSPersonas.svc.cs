using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WS_Prueba.IWS;
using WS_Prueba.Model;

namespace WS_Prueba
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona ObtenerPersona(string Identificacion)
        {
            DB_Prueba db = new DB_Prueba();
            if (Identificacion == "1")
            {
                var ele = db.Personas.Find(Convert.ToInt32(Identificacion));
                return new Persona() { Nombre = ele.Nombre, Edad = 1 };
            }
            if (Identificacion == "2")
            {
                int id = Convert.ToInt32(Identificacion);
                var ele = db.Personas.Where(c=>c.ID==id).ToList();
                if (ele.Any())
                {
                    return new Persona() { Nombre = ele.First().Nombre, Edad = 2 };
                }
                else
                {
                    return new Persona() { Nombre = "No encontrado", Edad = 1 };
                }
            }
            else
            {
                return new Persona() { Error = "Persona no encontrada" };
            }
        }

        public  string GuardarPersona(string Identidicador, string Nombre, int Edad)
        {
            DB_Prueba db = new DB_Prueba();
            string Resultado = "";
            try
            {
                Model.Persona per = new Model.Persona();
                per.Edad = Edad;
                per.Nombre = Nombre;
                //per.ID = Convert.ToInt32(Identidicador);
                db.Personas.Add(per);
                Resultado = "Almacenamiento exitos";
            }catch(Exception ex)
            {
                Resultado = "Ocurrio un error durante el almacenamiento de la persona";
            }
            return Resultado;
        }

        public Persona BuscarPersona(int PersonaID)
        {
            Persona tem = new Persona();
            DB_Prueba db = new DB_Prueba();
            try
            {
                Model.Persona consulta = db.Personas.Find(PersonaID);
                tem.Edad =Convert.ToInt32(consulta.Edad);
                tem.Nombre = consulta.Nombre;

            }catch(Exception ex)
            {
                tem.Error = "Error";
                tem.MensajeRespuesta = ex.Message;
            }
            return tem;
        }

        public string GuardaPais(string Nombre, string Abreviatura)
        {

            try
            {
                Pais p = new Pais();
                p.Nombre = Nombre;
                p.abreviatura = Abreviatura;

                DB_Prueba db = new DB_Prueba();

                db.Pais.Add(p);
                db.SaveChanges();
                return "Almacenamiento exitoso";
            }catch(Exception ex)
            {
                return "Error: "+ex.Message;

            }


        }

    }
}
