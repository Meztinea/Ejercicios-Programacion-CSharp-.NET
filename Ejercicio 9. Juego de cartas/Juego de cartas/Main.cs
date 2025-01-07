using System;

class Program
{
    /// <summary>
    /// Método principal donde se inicializa el programa
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // Creación de los dos objetos CartaLider
        CartaLider lider1 = new CartaLider();

        CartaLider lider2 = new CartaLider("Tony Tony.Chopper", "Red/Green", 4, 1, "Golpear",
        "[Activate: Main] [Once Per Turn] Give up to 3 of your {Animal} or {Drum Kingdom} type Characters up to 1 rested DON!! card each.",
        false, 5000, "Animal/Drum Kingdom/Straw Hat Crew", "Pequeño pero letal animal con sombrero");


        // Ejecución de los métodos de estos objetos CartaLíder
        lider1.mostrarInformacion();
        lider1.recibirDaño(1);
        lider1.voltear();
        lider1.activarHabilidad();
        lider1.mostrarInformacion();
        lider1.enderezar();

        lider2.mostrarInformacion();
        lider2.recibirDaño(2);
        lider2.recibirDaño(1);
        lider2.voltear();
        lider2.activarHabilidad();
        lider2.mostrarInformacion();
        lider2.enderezar();

    }
}