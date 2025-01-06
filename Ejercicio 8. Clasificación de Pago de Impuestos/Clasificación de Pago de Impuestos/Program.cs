
namespace ClasificacionDePagos
{
    /// <summary>
    /// Clase principal del programa
    /// </summary>
    class Program
    {
        /// <summary>
        /// Variables estáticas que pertenecen a la clase
        /// </summary>
        static int tipoPago;
        static bool tipoPagoValidado;
        static bool salir = false;

        /// <summary>
        /// Método principal del programa, desde donde inicia la ejecución
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

                do
                {
                    imprimirBienvenida();
                    Console.WriteLine("");

                    // Almacena el tipo de pago y valida que sea un dato correcto
                    Console.WriteLine("¿Qué tipo de pago desea realizar?");
                    Console.WriteLine("1. Agua");
                    Console.WriteLine("2. Predial");
                    Console.WriteLine("3. Refrendo");
                    Console.WriteLine("4. Salir");
                    Console.Write("Ingresa el tipo de pago: ");
                    tipoPago = int.Parse(Console.ReadLine());

                    if (tipoPago > 0 && tipoPago < 4)
                    {
                        tipoPagoValidado = true;
                    }

                    switch (tipoPago)
                    {
                        case 1:
                            calcularPagoAgua();
                            break;
                        case 2:
                            calcularPagoPredial();
                            break;
                        case 3:
                            calcularPagoRefrendo();
                            break;
                        case 4:
                            Console.WriteLine("Saliste del programa.");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                    Console.WriteLine("");

                } while (!salir);

        }

        /// <summary>
        /// Método que permite calcular el pago anual del refrendo de automóviles
        /// </summary>
        /// <returns> Rentorna 0 en caso de no existir datos para calcular </returns>
        public static int calcularPagoRefrendo()
        {
            int mesPago = validarMesPago();
            int tipoVehiculo = validarTipoVehiculo();
            double pagoAnual = 0;
            double pagoAnualTotal = 0;

            // Define el valor del pago anual del predial, antes de descuentos o recargos
            if (tipoVehiculo == 1) // Vehículo Particular
            {
                pagoAnual = 942.00;
            }
            else if (tipoVehiculo == 2) // Vehículo de servicio
            {
                pagoAnual = 1360.00;
            }
            else if (tipoVehiculo == 3) // 1 Particular y 1 de Servicio
            {
                pagoAnual = 942 + 1360;
            }
            else if (tipoVehiculo == 4)
            {
                pagoAnual = calcularPagoAnualVariosVehículos(); // 3 Venículos o más
            }
            else
            {
                Console.WriteLine("No hay datos para calcular\n");
                return 0;
            }

            // Realiza los cálculos para determinar el pago anual total del predial

            if (mesPago == 1) // Enero
            {
                pagoAnualTotal = pagoAnual * 0.85; // Descuenta el 15%
                Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                Console.WriteLine("Usted ha ahorrado: " + (pagoAnual * 0.15));
            }
            else if (mesPago == 2) // Febrero
            {
                pagoAnualTotal = pagoAnual * 0.95; // Descuenta el 5%
                Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                Console.WriteLine("Usted ha ahorrado: " + (pagoAnual * 0.05));
            }
            else if (mesPago >= 3 && mesPago <= 7) // Marzo a Julio
            {
                pagoAnualTotal = pagoAnual * 1.03; // Recargo del 3%
                Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                Console.WriteLine("Cargo por pago retrasado: " + (pagoAnual * 0.03));
            }
            else if (mesPago >= 8 && mesPago <= 12) // Agosto a Diciembre
            {
                pagoAnualTotal = pagoAnual * 1.07; // Recargo del 7%
                Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                Console.WriteLine("Cargo por pago retrasado: " + (pagoAnual * 0.07));
            }

            Console.WriteLine("");

            return 0;
        }

        /// <summary>
        /// Método que permite calcular el pago anual de refrendo de varios vehículos
        /// </summary>
        /// <returns> Pago anual de refrendo de varios vehículos </returns>
        public static double calcularPagoAnualVariosVehículos()
        {
            int cantVehiculos;
            double pagoAnual = 0;

            do
            {
                cantVehiculos = 0;

                Console.Write("Ingresa la cantidad de vehículos: ");
                cantVehiculos = int.Parse(Console.ReadLine());

                if (cantVehiculos >= 3)
                {
                    pagoAnual = cantVehiculos * 1000;
                    return pagoAnual;
                }

            } while (true);

        }

        /// <summary>
        /// Método que permite calcular el pago anual total del predial
        /// </summary>
        public static void calcularPagoPredial()
        {
            int mesPago = validarMesPago();
            int zonaVivienda = validarZonaVivienda();
            double pagoAnual = 0;
            double pagoAnualTotal = 0;

            // Define el valor del pago anual del predial, antes de descuentos o recargos
            if (zonaVivienda == 1)
            {
                pagoAnual = 1150.00;
            }
            else if (zonaVivienda == 2)
            {
                pagoAnual = 2380.00;
            }
            else
            {
                pagoAnual = 3645.00;
            }

            // Realiza los cálculos para determinar el pago anual total del predial
            switch (mesPago)
            {
                case 1:
                    pagoAnualTotal = pagoAnual * 0.8; // Descuenta el 20%
                    Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                    Console.WriteLine("Usted ha ahorrado: " + (pagoAnual * 0.2));
                    break;
                case 2:
                    pagoAnualTotal = pagoAnual * 0.88; // Descuenta el 12%
                    Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                    Console.WriteLine("Usted ha ahorrado: " + (pagoAnual * 0.12));
                    break;
                default:
                    Console.WriteLine("El pago anual total es de: " + pagoAnual);
                    Console.WriteLine("Por el mes de pago, ya no puede acceder a descuento");
                    break;
            }

            Console.WriteLine("");

        }

        /// <summary>
        /// Método que permite calcular el pago anual total del agua 
        /// </summary>
        public static void calcularPagoAgua()
        {
            int mesPago = validarMesPago();
            int zonaVivienda = validarZonaVivienda();
            double pagoAnual = 0;
            double pagoAnualTotal = 0;

            // Define el valor del pago anual del agua, antes de descuentos o recargos
            if (zonaVivienda == 1)
            {
                pagoAnual = 4090.00;
            }
            else if (zonaVivienda == 2)
            {
                pagoAnual = 6100.00;
            }
            else
            {
                pagoAnual = 8792.00;
            }

            // Realiza los cálculos para determinar el pago anual total del agua
            switch (mesPago)
            {
                case 1:
                    pagoAnualTotal = pagoAnual * 0.8; // Descuenta el 20%
                    Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                    Console.WriteLine("Usted ha ahorrado: " + (pagoAnual * 0.2) );
                    break;
                case 2:
                    pagoAnualTotal = pagoAnual * 0.88; // Descuenta el 12%
                    Console.WriteLine("El pago anual total es de: " + pagoAnualTotal);
                    Console.WriteLine("Usted ha ahorrado: " + (pagoAnual * 0.12));
                    break;
                default:
                    Console.WriteLine("El pago anual total es de: " + pagoAnual);
                    Console.WriteLine("Por el mes de pago, ya no puede acceder a descuento");
                    break;
            }

            Console.WriteLine("");
        }

        /// <summary>
        /// Método que pemirte validar la opción que el usuario selecciona respecto al tipo de vehículo
        /// </summary>
        /// <returns> Opción seleccionada por el usuario entre la lista de tipos de vehículos </returns>
        public static int validarTipoVehiculo()
        {
            int vehiculos = 0;
            bool vehiculosValidado = false;

            do
            {
                // Almacena los vehículos y valida que sea un dato correcto
                Console.WriteLine("TIPO DE VEHÍCULO");
                Console.WriteLine("1. Venículo particular");
                Console.WriteLine("2. Venículo de servicio");
                Console.WriteLine("3. Ambos (1 particular y 1 de servicio)");
                Console.WriteLine("4. 3 vehículos o más");
                Console.WriteLine("5. No tengo vehículos");
                Console.Write("Elige el tipo de venículo: ");
                vehiculos = int.Parse(Console.ReadLine());

                if (vehiculos > 0 && vehiculos < 6)
                {
                    vehiculosValidado = true;
                }

                Console.WriteLine("");

            } while (!vehiculosValidado);

            return vehiculos;
        }

        /// <summary>
        /// Método que permite validar la opción que el usuario selecciona respecto a las zonas de vivienda 
        /// </summary>
        /// <returns> Zona de vivienda seleccionada por el usuario </returns>
        public static int validarZonaVivienda()
        {
            int zonaVivienda = 0;
            bool zonaViviendaValidado = false;

            do
            {
                // Almacena la zona de vivienda y valida que sea un dato correcto
                Console.WriteLine("ZONAS DE VIVIENDA");
                Console.WriteLine("1. Urbano");
                Console.WriteLine("2. Fraccionamiento");
                Console.WriteLine("3. Residencial");
                Console.Write("Elige tu zona de vivienda: ");
                zonaVivienda = int.Parse(Console.ReadLine());

                if (zonaVivienda > 0 && zonaVivienda < 4)
                {
                    zonaViviendaValidado = true;
                }

                Console.WriteLine("");

            } while (!zonaViviendaValidado);

            return zonaVivienda;
        }

        /// <summary>
        /// Método que permite validar la opción seleccionada por el usuario respecto al mes de pago
        /// </summary>
        /// <returns> Mes de pago ingresado por el usuario </returns>
        public static int validarMesPago()
        {
            int mesPago = 0;
            bool mesPagoValidado = false;

            do
            {
                // Almacena el mes de pago y valida que sea un dato correcto
                Console.Write("Ingresa el mes de pago (Enero = 1, Febrero = 2, etc.): ");
                mesPago = int.Parse(Console.ReadLine());

                if (mesPago > 0 && mesPago < 13)
                {
                    mesPagoValidado = true;
                }

                Console.WriteLine("");

            } while (!mesPagoValidado);

            return mesPago;
        }

        /// <summary>
        /// Método que muestra el mensaje de bienvenida
        /// </summary>
        public static void imprimirBienvenida()
        {
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("****************************************************************");
            }

            for (int i = 0;i < 4;i++)
            {
                
                if (i == 0 || i == 3)
                {
                    Console.WriteLine("**********                                            **********");
                }

                if (i == 1)
                {
                    Console.WriteLine("**********       GOBIERNO DEL ESTADO DE MÉXICO        **********");
                }

                if(i == 2)
                {
                    Console.WriteLine("**********      PAGOS DE OBLIGACIONES ESTATALES       **********");
                }

            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("****************************************************************");
            }

                Console.WriteLine("      BIENVENIDO A ESTE SISTEMA DE ADMINISTRACIÓN ESTATAL       ");

        }

    }

}

