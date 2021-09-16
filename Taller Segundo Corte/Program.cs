using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Segundo_Corte
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class Persona
        {
            string Nombre;
            string PrimerApellido;
            string SegundoApellido;
            public TipoDocumento Documento;
            int NumDocumento;
            string Direccion;
            string Ciudad;
            int Telefono;
        }
        public class Vehiculo
        {
            public ClaseDeVehiculo ClaseVehiculo;
            string Marca;
            bool Placa;
            string Linea;
            string Combustible;
            string Colores;
            string Modelo;
            string Cilindrada;
            string Capacidad;
            bool Blindaje;
            bool DesmBlindaje;
            string Potencia;
            string Carroceria;
            string idintvehiculo;
            string Importacion;
            string DatosAlerta;
            string EmpresaVinc;
        }
        public class ClaseDeVehiculo
        {
            string Automovil;
            string Bus;
            string Buseta;
            string Camion;
            string Camioneta;
            string Campero;
            string Microbus;
            string Tractocamion;
            string Motocicleta;
            string Motocarro;
            string Mototriciclo;
            string Cuatrimoto;
            string Volqueta;
            string Otro;       
        }
        public class TipoDocumento
        {
            string Cedula;
            string NIT;
            string NN;
            string Pasaporte;
            string CedExtranjero;
            string TarjIdentidad;
            string NUIP;
            string CedDiplomatico;
        }
        public class Tramite
        {
            public Propietario Propietario;
            public Comprador Comprador;
            string OrganismoTransito;
            string TipoTramite;
            string Observaciones;
        }
        public class Servicio
        {
            int Particular;
            int Publico;
            int Diplomatico;
            int Oficial;
            int Especial;
        }
        public class Propietario
        {
            public Persona Persona;
            string Firma;
        }
        public class Comprador
        {
            public Persona Persona;
            string Firma;
        }
    }
}
