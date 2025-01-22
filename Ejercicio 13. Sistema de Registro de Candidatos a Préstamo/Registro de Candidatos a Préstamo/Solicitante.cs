

namespace CandidatosPrestamo
{
    /// <summary>
    /// Clase que representa a un solicitante de préstamo
    /// </summary>
    public class Solicitante
    {
        // Atributos
        private String NombreCompleto;
        private String CorreoElectronico;
        private long Telefono;
        private String LugarResidencia;
        private int Edad;
        private double IngresosSolicitante;
        private String Aval1;
        private String Aval2;


        // Getters y Setters
        public void SetNombreCompleto(String NombreCompleto)
        {
            this.NombreCompleto = NombreCompleto;
        }

        public String GetNombreCompleto()
        {
            return this.NombreCompleto;
        }


        public void SetCorreoElectronico(String CorreoElectronico)
        {
            this.CorreoElectronico = CorreoElectronico;
        }

        public String GetCorreoElectronico()
        {
            return this.CorreoElectronico;
        }


        public void SetTelefono(long Telefono)
        {
            this.Telefono = Telefono;
        }

        public long GetTelefono()
        {
            return this.Telefono;
        }


        public void SetLugarResidencia(String LugarResidencia)
        {
            this.LugarResidencia = LugarResidencia;
        }

        public String GetLugarResidencia()
        {
            return this.LugarResidencia;
        }


        public void SetEdad(int Edad)
        {
            this.Edad = Edad;
        }

        public int GetEdad()
        {
            return this.Edad;
        }


        public void SetIngresosSolicitante(double IngresosSolicitante)
        {
            this.IngresosSolicitante = IngresosSolicitante;
        }

        public double GetIngresosSolicitante()
        {
            return this.IngresosSolicitante;
        }


        public void SetAval1(String Aval)
        {
            this.Aval1 = Aval;
        }

        public String GetAval1()
        {
            return this.Aval1;
        }


        public void SetAval2(String Aval)
        {
            this.Aval2 = Aval;
        }

        public String GetAval2()
        {
            return this.Aval2;
        }

        // Constructores 
        public Solicitante()
        {

        }

        public Solicitante(String NombreCompleto)
        {
            this.NombreCompleto = NombreCompleto;
        }
    }
}
