using System;


    /// <summary>
    /// Clase que crea cartas líder con sus atributos y métodos
    /// </summary>
    public class CartaLider
    {
        /// <summary>
        /// Atributos de una carta líder
        /// </summary>
        private String nombre;
        private String color;
        private int puntosDeVida;
        private int costoDeDon;
        private String habilidad;
        private String efectoDeVolteo;
        private bool estado;

        /// <summary>
        /// Atributos extra de una carta líder
        /// </summary>
        private int cantidadPoder;
        private String tipoLider;
        private String descripcionLider;


        /// <summary>
        /// Getters y Setters para los atributos de una CartaLíder
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int PuntosDeVida
        {
            get { return puntosDeVida; }
            set { puntosDeVida = value; }
        }

        public int CostoDeDon
        {
            get { return costoDeDon; }
            set { costoDeDon = value; }
        }

        public string Habilidad
        {
            get { return habilidad; }
            set { habilidad = value; }
        }

        public string EfectoDeVolteo
        {
            get { return efectoDeVolteo; }
            set { efectoDeVolteo = value; }
        }

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // Propiedades para los atributos extra
        public int CantidadPoder
        {
            get { return cantidadPoder; }
            set { cantidadPoder = value; }
        }

        public string TipoLider
        {
            get { return tipoLider; }
            set { tipoLider = value; }
        }

        public string DescripcionLider
        {
            get { return descripcionLider; }
            set { descripcionLider = value; }
        }

        /// <summary>
        /// Constructor que recibe todos los parámetros para crear una instancia de CartaLider
        /// </summary>
        /// <param name="nombre"> El nombre del Líder (por ejemplo, Monkey D. Luffy, Trafalgar Law) </param>
        /// <param name="color"> Representa la afinidad o clase de la carta (por ejemplo, Rojo, Azul, Verde) </param>
        /// <param name="puntosDeVida"> La cantidad de vida del Líder. Si llega a cero, el Líder es derrotado </param>
        /// <param name="costoDeDon"> La cantidad de recursos necesarios para activar la carta </param>
        /// <param name="habilidad"> Una descripción de la habilidad especial de la carta </param>
        /// <param name="efectoDeVolteo"> Un efecto especial que ocurre cuando la carta es volteada </param>
        /// <param name="estado"> Un indicador de si la carta ha sido volteada durante la partida </param>
        /// <param name="cantidadPoder"> Cantidad de poder de la carta líder </param>
        /// <param name="tipoLider"> Tipo de líder (por ejemplo, Jaya/Sky Island/Shandian Warrior) </param>
        /// <param name="descripcionLider"> Descripción física del líder de la carta </param>
        public CartaLider(string nombre, string color, int puntosDeVida, int costoDeDon, string habilidad, 
            string efectoDeVolteo, bool estado, int cantidadPoder, string tipoLider, string descripcionLider 
            )
        {
            this.nombre = nombre;
            this.color = color;
            this.puntosDeVida = puntosDeVida;
            this.costoDeDon = costoDeDon;
            this.habilidad = habilidad;
            this.efectoDeVolteo = efectoDeVolteo;
            this.estado = estado;
            this.cantidadPoder = cantidadPoder;
            this.tipoLider = tipoLider;
            this.descripcionLider = descripcionLider;
            
        }

        /// <summary>
        /// Constructor que no recibe parámetros e inicializa una CartaLider con los valores por defecto 
        /// </summary>
        public CartaLider()
        {
            this.nombre = "Kalgara";
            this.color = "Yellow";
            this.puntosDeVida = 5;
            this.costoDeDon = 1;
            this.habilidad = "Cortar";
            this.efectoDeVolteo = "[DON!! x1] [Al Atacar] Juega hasta 1 carta de Personaje de tipo {Guerrero Shandiano} de tu mano con un coste igual o menor que el número de cartas DON!! en tu campo. Si lo haces, añade 1 carta de la parte superior de tus cartas de Vida a tu mano.";
            this.estado = false;
            this.cantidadPoder = 5000;
            this.tipoLider = "Jaya/Sky Island/Shandian Warrior";
            this.descripcionLider = "Líder superpoderoso de cabello largo y rojo";

        }

        /// <summary>
        /// Método que reduce la vida de uná CartaLíder al recibir daño 
        /// </summary>
        /// <param name="cantidad"> Cantidad de vida que se resta a la del líder </param>
        public void recibirDaño(int cantidad)
        {
            
            // Resta vida al líder por recibir daño
            this.puntosDeVida = this.puntosDeVida - cantidad;
            System.Console.WriteLine("\nLider " + this.nombre + " recibió daño por: " + cantidad);

            // Líder derrotado???
            if (this.puntosDeVida <= 0)
            {
                this.puntosDeVida = 0;
                System.Console.WriteLine("\nLider derrotado :(");
            }

        }

        /// <summary>
        /// Método que activa la habilidad especial de la carta líder
        /// </summary>
        public void activarHabilidad()
        {
            System.Console.WriteLine("\nHabilidad activada: " + this.habilidad + " - Líder " + this.nombre);
        }

        /// <summary>
        /// Método que voltea la carta para activar el efecto de volteo
        /// </summary>
        public void voltear()
        {
            if (this.estado == true)
            {
                System.Console.WriteLine("\nLa carta se encuentra volteada");
            }
            else
            {
                this.estado = true;
                System.Console.WriteLine("\nSe ha activado el efecto de volteo: " + this.efectoDeVolteo);
            }
        }

        /// <summary>
        /// Método que endereza la carta líder (volver a no volteado) 
        /// </summary>
        public void enderezar()
        {
            if (this.estado == true)
            {
                this.estado = false;
                System.Console.WriteLine("\nSe enderezó la carta");
            }
            
        }

        /// <summary>
        /// Método que muestra toda la información de los atributos de una carta líder
        /// </summary>
        public void mostrarInformacion()
        {
            System.Console.WriteLine(
                "\n\n--- Información de la Carta Líder ---" + "\n\n" + 
                "Nombre: " + this.nombre + "\n" + 
                "Color: " + this.color + "\n" +
                "Vida: " + this.puntosDeVida + "\n" +
                "Costo de Don: " + this.costoDeDon + "\n" +
                "Habilidad: " + this.habilidad + "\n" +
                "Efecto de volteo: " + this.efectoDeVolteo + "\n" +
                "Estado: " + this.estado + "\n" +
                "Cantidad Poder: " + this.CantidadPoder + "\n" +
                "Tipo líder: " + this.tipoLider + "\n" +
                "Descripción líder: " + this.descripcionLider + "\n");

        }
    }
