using CandidatosPrestamo;

/// <summary>
/// Clase principal
/// </summary>
public class Program ()
{
    public static Solicitante sl = new Solicitante();

    /// <summary>
    /// Método principal
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {

        int opcion = 0;

        while (opcion != 2)
        {
            Console.WriteLine("\nMenú de opciones");
            Console.WriteLine("1. Capturar los datos del solicitante");
            Console.WriteLine("2. Salir del sistema");
            opcion = Convert.ToInt32(Console.ReadLine());
            bool SolicitudTerminada = false;

            switch (opcion)
            {
                case 1:

                    do
                    {
                        if (sl.GetNombreCompleto() == null) // No se ha capturado el nombre
                        {
                            try
                            {
                                SolicitarNombreCompleto();
                            }
                            catch (NombreCompletoException ncex)
                            {
                                Console.WriteLine(ncex.Message);
                                continue;
                            }
                            catch (ArgumentException aex)
                            {
                                Console.WriteLine(aex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("El nombre almacenado es: " + sl.GetNombreCompleto());
                                
                            }
                        }


                        if (sl.GetCorreoElectronico() == null) // No se ha capturado el correo
                        {
                            try
                            {
                                SolicitarCorreoElectronico();
                            }
                            catch (CorreoElectronicoException ceex)
                            {
                                Console.WriteLine(ceex.Message);
                                continue;
                            }
                            catch (FormatException fex)
                            {
                                Console.WriteLine(fex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("El correo electrónico almacenado es: " + sl.GetCorreoElectronico());
                            }
                        }


                        if (sl.GetTelefono() == 0)// No se ha capturado el telefono
                        {
                            try
                            {
                                SolicitarNumeroTelefono();
                            }
                            catch (NumeroTelException ntex)
                            {
                                Console.WriteLine(ntex.Message);
                                continue;
                            }
                            catch (FormatException fex)
                            {
                                Console.WriteLine("El formato del número es incorrecto.");
                            }
                            finally
                            {
                                Console.WriteLine("El número de teléfono almacenado es: " + sl.GetTelefono());
                            }
                        }


                        if (sl.GetLugarResidencia() == null)// No se ha capturado el lugar de residencia
                        {
                            try
                            {
                                SolicitarLugarResidencia();
                            }
                            catch (LugarResidenciaException lrex)
                            {
                                Console.WriteLine(lrex.Message);
                                continue;
                            }
                            catch (ArgumentOutOfRangeException aoofrex)
                            {
                                Console.WriteLine(aoofrex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("El lugar de residencia almacenado es: " + sl.GetLugarResidencia());
                            }
                        }


                        if (sl.GetEdad() == 0)// No se ha capturado la edad
                        {
                            try
                            {
                                SolicitarEdad(sl);
                            }
                            catch (EdadSolicitanteException esex)
                            {
                                Console.WriteLine(esex.Message);
                                continue;
                            }
                            catch (ArgumentOutOfRangeException aoorex)
                            {
                                Console.WriteLine(aoorex.Message);
                            }
                            catch (ArithmeticException aex)
                            {
                                Console.WriteLine(aex.Message);
                            }
                            finally
                            {
                                if (sl.GetEdad() > 64)
                                {
                                    Console.WriteLine("Debe ingresar los nombres de dos avales.");
                                    Console.WriteLine("Ingresa el nombre del primer aval: ");
                                    sl.SetAval1(Console.ReadLine());
                                    Console.WriteLine("Ingresa el nombre del segundo aval: ");
                                    sl.SetAval2(Console.ReadLine());
                                }
                                Console.WriteLine("La edad almacenada es: " + sl.GetEdad());
                            }
                        }


                        if (sl.GetIngresosSolicitante() == 0.0)// No se ha capturado el ingreso del solicitante
                        {
                            try
                            {
                                SolicitarIngreso();
                            }
                            catch (IngresoSolicitanteException isex)
                            {
                                Console.WriteLine(isex.Message);
                                continue;
                            }
                            catch (ArgumentOutOfRangeException aoorex)
                            {
                                Console.WriteLine(aoorex.Message);
                            }
                            finally
                            {
                                Console.WriteLine("El ingreso almacenado es: " + sl.GetIngresosSolicitante());
                            }
                        }

                        // Verifica si la solicitud ha sido terminada
                        if (sl.GetNombreCompleto()!=null && sl.GetCorreoElectronico()!=null && sl.GetTelefono() != 0 &&
                            sl.GetLugarResidencia()!=null && sl.GetEdad()!=0 && sl.GetIngresosSolicitante()!=0.0)
                        {
                            SolicitudTerminada = true;
                            Console.WriteLine("Todos los datos han sido almacenados exitosamente. La solicitud de préstamo ha sido aceptada.");
                        }

                    } while (SolicitudTerminada == false);
                    break;

                case 2:
                    Console.WriteLine("Saliendo del sistema...");
                    opcion = 2;
                    break;

                default:
                    Console.WriteLine("La opción no es correcta, intenta de nuevo.");
                    break;

            }
        }
    }

    /// <summary>
    /// Método auxiliar para solicitar datos
    /// </summary>
    public static void SolicitarNombreCompleto()
    {
        // Pidiendo el nombre del solicitante
        Console.WriteLine("\nIngresa el nombre completo: ");
        String nombre = Console.ReadLine();

        // Validando el dato - Lanzando la excepción
        NombreCompletoException.ValidarNombreCompleto(nombre);

        // Almacenando el nombre del solicitante
        sl.SetNombreCompleto(nombre);
    }

    /// <summary>
    /// Método auxiliar para solicitar datos
    /// </summary>
    public static void SolicitarCorreoElectronico()
    {
        // Pidiendo el correo del solicitante
        Console.WriteLine("\nIngresa el correo electrónico: ");
        String CorreoElectronico = Console.ReadLine();

        // Validando el dato - Lanzando la excepción
        CorreoElectronicoException.ValidarCorreoElectronico(CorreoElectronico);

        // Almacenando el correo del solicitante
        sl.SetCorreoElectronico(CorreoElectronico);
    }

    /// <summary>
    /// Método auxiliar para solicitar datos
    /// </summary>
    public static void SolicitarNumeroTelefono()
    {
        // Pidiendo el número de teléfono del solicitante
        Console.WriteLine("\nIngresa el número de teléfono: ");
        String NumeroTelefono = Console.ReadLine();

        // Validando el dato - Lanzando la excepción
        NumeroTelException.ValidarNumeroTelefono(NumeroTelefono);

        // Almacenando el numero de teléfnono del solicitante
        sl.SetTelefono(Convert.ToInt64(NumeroTelefono));
    }

    /// <summary>
    /// Método auxiliar para solicitar datos
    /// </summary>
    public static void SolicitarLugarResidencia()
    {
        // Pidiendo el lugar de residencia del solicitante
        Console.WriteLine("\nIngresa el lugar de residencia: ");
        String LugarResidencia = Console.ReadLine();

        // Validando el dato - Lanzando la excepción
        LugarResidenciaException.ValidarLugarResidencia(LugarResidencia);

        // Almacenando el lugar de residencia del solicitante
        sl.SetLugarResidencia(LugarResidencia);
    }

    /// <summary>
    /// Método auxiliar para solicitar datos
    /// </summary>
    /// <param name="sl"> Solicitante del que se están almacenando los datos </param>
    public static void SolicitarEdad(Solicitante sl)
    {
        // Pidiendo la edad del solicitante
        Console.WriteLine("\nIngresa la edad: ");
        int Edad = Convert.ToInt16(Console.ReadLine());

        // Validando el dato - Lanzando la excepción
        EdadSolicitanteException.ValidarEdadSolicitante(Edad, sl);

        // Almacenando la edad del solicitante
        sl.SetEdad(Edad);
    }

    /// <summary>
    /// Método auxiliar para solicitar datos
    /// </summary>
    public static void SolicitarIngreso()
    {
        // Pidiendo los ingresos del solicitante
        Console.WriteLine("\n¿A cuánto ascienden sus ingresos económicos diarios?");
        double Ingresos = Convert.ToDouble(Console.ReadLine());

        // Validando el dato - Lanzando la excepción
        IngresoSolicitanteException.ValidarIngresos(Ingresos);

        // Almacenando los ingressos del solicitante
        sl.SetIngresosSolicitante(Ingresos);
    }

}






