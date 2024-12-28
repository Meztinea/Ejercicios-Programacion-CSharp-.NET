using GeolocalizacionTortugasMarinas;
using Geolocation;

internal static class UtilitariosHelpers
{
    /// <summary>
    /// Método que solicita los datos de coordenadas y fecha al usuario por día de recorrido
    /// </summary>
    /// <param name="tiempo">Indica si se está solicitando la coordenada de inicio o fin</param>
    /// <returns>Retorna un objeto coordenada con los datos ingresados por el usuario</returns>
    public static Coordenada IngresarDatosCoordenada(String tiempo)
    {
        Coordenada coordenada = new();

        Console.WriteLine("Ingresa los datos del día - Coordenada de " + tiempo);

        Console.Write("Ingresa la latitud - " + tiempo + ": ");
        coordenada.SetLatitud(double.Parse(Console.ReadLine()));

        Console.Write("Ingresa la longitud - " + tiempo + ": ");
        coordenada.SetLongitud(double.Parse(Console.ReadLine()));

        bool fechaCorrecta = false;

        do
        {
            Console.Write("Ingresa la fecha - " + tiempo + " (formato dd/MM/yyyy HH:mm:ss)" + ": ");
            String fecha = Console.ReadLine();

            if (DateTime.TryParseExact(fecha, "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime fechaHora))
            {
                coordenada.SetFechaHora(fechaHora);
                fechaCorrecta = true;
            }
            else
            {
                Console.WriteLine("Formato de fecha y hora no válido.");
            }

        } while (fechaCorrecta == false);

        return coordenada;
    }
    /// <summary>
    /// Método que realiza el cálculo de distancia entre el origen y destino de un recorrido
    /// </summary>
    /// <param name="recorrido">Recorrido del que se quiere calcular la distancia en Kilometros</param>
    /// <returns>Retorna la distancia en Km</returns>
    public static Double CalcularDistanciaKm(RecorridoDia recorrido)
    {
        Coordinate origen = new Coordinate(recorrido.GetCoordenadaInicio().GetLatitud(),
            recorrido.GetCoordenadaInicio().GetLongitud());

        Coordinate destino = new Coordinate(recorrido.GetCoordenadaFin().GetLatitud(),
            recorrido.GetCoordenadaFin().GetLongitud());

        return GeoCalculator.GetDistance(origen, destino, 1);
    }
    /// <summary>
    /// Método que calcula la dirección de un recorrido
    /// </summary>
    /// <param name="recorrido">Recorrido del que se quiere calcular la dirección</param>
    /// <returns>Retorna un String con la dirección de recorrido calculado desde el origen al destino</returns>
    public static String CalcularDireccionCardinal(RecorridoDia recorrido)
    {
        Coordinate origen = new Coordinate(recorrido.GetCoordenadaInicio().GetLatitud(),
            recorrido.GetCoordenadaInicio().GetLongitud());

        Coordinate destino = new Coordinate(recorrido.GetCoordenadaFin().GetLatitud(),
            recorrido.GetCoordenadaFin().GetLongitud());

        return GeoCalculator.GetDirection(origen, destino);
    }
    /// <summary>
    /// Método que calcula el tiempo transcurrido de un recorrido
    /// </summary>
    /// <param name="recorrido">Recorrido del que se quiere calcular el tiempo transcurrido</param>
    /// <returns>Retorna un objeto de tipo TimeSpan que contiene el tiempo transcurrido</returns>
    public static TimeSpan CalcularTiempoTranscurrido(RecorridoDia recorrido)
    {
        return recorrido.GetCoordenadaFin().GetFechaHora() - recorrido.GetCoordenadaInicio().GetFechaHora();
    }
    /// <summary>
    /// Método que calcula la velocidad de nado a partir de un objeto de tipo recorrido
    /// </summary>
    /// <param name="recorrido">Objeto de tipo Recorrido del que se desea calcular la velocidad de nado</param>
    /// <returns>Retorna un double con la velocidad de nado en Km/hr </returns>
    public static double CalcularVelocidadNado(RecorridoDia recorrido)
    {
        return recorrido.GetDistanciaKM() / recorrido.GetTiempoTranscurrido().TotalHours;
    }
    /// <summary>
    /// Método que permite calcular e imprimir los datos de un informe general
    /// </summary>
    /// <param name="recorrido">Recorrido del que se quiere generar el informe general</param>
    public static void ImprimirInforme(RecorridoDia recorrido)
    {
        Console.WriteLine("Distancia total recorrida en Km: " + recorrido.GetDistanciaKM());
        Console.WriteLine("Velocidad promedio del nado KM/hr: " + recorrido.GetVelocidadPromedioNado().ToString("N2"));
        Console.WriteLine("Ubicación de inicio: Latitud (" + recorrido.GetCoordenadaInicio().GetLatitud() + ") "
            + "Longitud (" + recorrido.GetCoordenadaInicio().GetLongitud() + ")");
        Console.WriteLine("Ubicación de fin: Latitud (" + recorrido.GetCoordenadaFin().GetLatitud() + ") "
            + "Longitud (" + recorrido.GetCoordenadaFin().GetLongitud() + ")");

    }
}