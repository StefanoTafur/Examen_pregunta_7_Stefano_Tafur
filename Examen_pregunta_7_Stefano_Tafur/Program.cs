using System;
//Definicion de la clase abstracta
public abstract class Pais
{
    public abstract string ColorBandera();
    public abstract string Tamaño();
    public abstract string IdiomaOficial ();
}

//Definicion de la clase Ecuador que hereda de pais

public class Ecuador : Pais
{
    public override string ColorBandera()
    {
        return "Amarillo, Azul, Rojo";
    }
    public override string Tamaño()
    {
        return "283.561 km²";
    }
    public override string IdiomaOficial()
    {
        return "Español";
    }
}

// Definicion de la clase Brasil que hereda de Pais
public class Brasil : Pais
{
    public override string ColorBandera()
    {
        return "Verde, Amarillo, Azul, Blanco";
    }

    public override string Tamaño()
    {
        return "8,51 millones km²";
    }

    public override string IdiomaOficial()
    {
        return "Portugues";
    }
}

// Definicion de la clase Andorra que hereda de Pais
public class Andorra : Pais
{
    public override string ColorBandera()
    {
        return "Azul, Amarillo, Rojo";
    }

    public override string Tamaño()
    {
        return "468 km²";
    }

    public override string IdiomaOficial()
    {
        return "Catalan";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de los paises
        Pais ecuador = new Ecuador();
        Pais brasil = new Brasil();
        Pais andorra = new Andorra();

        // Mostrar la informacion solicitada
        Console.WriteLine("Color de la bandera de Ecuador: " + ecuador.ColorBandera());
        Console.WriteLine("Tamaño de Andorra: " + andorra.Tamaño());
        Console.WriteLine("Idioma oficial de Brasil: " + brasil.IdiomaOficial());
    }
}