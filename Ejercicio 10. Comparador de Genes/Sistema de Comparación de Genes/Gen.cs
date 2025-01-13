

/// <summary>
/// Clase Gen para crear objetos de tipo Gen
/// </summary>
class Gen
{
    private String nombre;
    private String ubicacion;
    private String funcion;
    private String secuencia;


    // Getters y Setters
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Ubicacion
    {
        get { return ubicacion; }
        set { ubicacion = value; }
    }

    public string Funcion
    {
        get { return funcion; }
        set { funcion = value; }
    }

    public string Secuencia
    {
        get { return secuencia; }
        set { secuencia = value; }
    }

    // Constructores
    public Gen()
    {
    }

    // Constructor con parámetros
    public Gen(string nombre, string ubicacion, string funcion, string secuencia)
    {
        this.nombre = nombre;
        this.ubicacion = ubicacion;
        this.funcion = funcion;
        this.secuencia = secuencia;
    }

    // Destructor de objetos Gen
    ~Gen()
    {
        Console.WriteLine("El objeto ha sido destruido");
    }




    /// <summary>
    /// Método que permite comparar las secuencias de dos Genes
    /// </summary>
    /// <param name="otroGen"> El gen con el de ha de compararse el gen actual /param>
    /// <returns> Resultado de la comparación para mostrar al usuario </returns>
    public String CompararGenes(Gen otroGen)
    {

        // Secuencias
        String SecEsteGen = this.secuencia;
        String SecOtroGen = otroGen.secuencia;


        // Dos longitudes - comparación de longitudes
        int LongEsteGen = SecEsteGen.Length;
        int LongOtroGen = SecOtroGen.Length;
        bool mismaLongitud = LongEsteGen == LongOtroGen;
        int diferencias = 0;
        int longitudMinima = 0;

        // Verificando las longitudes
        if (mismaLongitud == false)
        {
            Console.WriteLine("Las secuencias tienen longitudes diferentes.");

            // Cuando son diferentes longitudes calcula la longitud más pequeña para recorrer las secuencias sin errores
            diferencias += Math.Abs(this.secuencia.Length - otroGen.secuencia.Length);
            longitudMinima = Math.Min(this.secuencia.Length, otroGen.secuencia.Length);
        }

            

        // Comparando las secuencias caracter por caracter
        for (int i = 0; i < longitudMinima; i++)
        {
            if (this.secuencia[i] != otroGen.secuencia[i])
            {
                diferencias++;
            }
        }

        // Mensaje de salida según las diferencias
        if (diferencias == 0)
        {
            return "Las secuencias son iguales";
        }
        else
        {
            return $"Las secuencias son diferentes. Cantidad de bases diferentes: {diferencias}.";
        }
    }



    /// <summary>
    /// Método que permite mutar una secuencia agregando una nueva base
    /// </summary>
    /// <param name="nuevaBase"> Nueva base para mutar al gen </param>
    /// <param name="posicion"> Posicion en la que debe modificarse con la nueva base </param>
    /// <returns> Mensaje para el usuario, indica si se pudo mutar o no </returns>
    public String MutarSecuencia(char nuevaBase, int posicion)
    {
        // Verificando si la posición es válida
        if (posicion < 0 || posicion >= this.secuencia.Length)
        {
            return "Posición inválida, no se puede mutar la secuencia. Verifique la posición.";
        }

        // Verificando si la nueva bas es válida (A-T-C-G)
        if (nuevaBase != 'A' || nuevaBase != 'T' || nuevaBase != 'C' || nuevaBase != 'G')
        {
            return "La base no es válida. Debe ser A, T, C o G";
        }

        // Utilizando un array para modificar la secuencia
        char[] secuenciaArray = this.secuencia.ToCharArray();

        // Reemplazando la base en la posición
        secuenciaArray[posicion] = nuevaBase;

        // Recuperand la secuencia en formato de String
        this.secuencia = new string(secuenciaArray);

        return $"La mutación ha sido exitosa. Esta es la nueva secuencia: {secuencia}";

    }

    /// <summary>
    /// Método que permite mostrar toda la información de un Gen
    /// </summary>
    /// <returns> Información del gen para mostrar al usuario </returns>
    public string MostrarInformacion()
    {

        string informacion = "\n\nInformación del Gen:\n" +
                                "Nombre: " + this.nombre + "\n" +
                                "Ubicación: " + this.ubicacion + "\n" +
                                "Función: " + this.funcion + "\n" +
                                "Secuencia: " + this.secuencia + "\n";

        return informacion;
    }

    /// <summary>
    /// Método que permite clonar a un gen generando uno nuevo e independiente 
    /// </summary>
    /// <returns> El nuevo gen clonado </returns>
    public Gen ClonarGen()
    {
        // Creando y devolviendo una copia del GEn
        return new Gen(this.nombre, this.ubicacion, this.funcion, this.secuencia);
    }


}

