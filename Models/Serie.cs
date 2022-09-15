using System;
using System.Collections.Generic;

namespace TP8_Morrison.Models;

public class Serie
{
    private int _IdSerie, _AñoInicio;
    private string _Nombre, _Sinopsis, _ImagenSerie;
    public Serie(int IdSerie, string Nombre, int AñoInicio, string Sinopsis, string ImagenSerie)
    {
        _IdSerie = IdSerie;
        _Nombre = Nombre;
        _AñoInicio = AñoInicio;
        _Sinopsis = Sinopsis;
        _ImagenSerie =ImagenSerie;
    }
    public Serie()
    {
        _IdSerie = 0; _Nombre = ""; _AñoInicio = 0; _Sinopsis = ""; _ImagenSerie = "";
    }
    public int IdSerie
    {
        get { return _IdSerie; }
        set { _IdSerie = value; }
    }
    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }
    public int AñoInicio
    {
        get { return _AñoInicio; }
        set { _AñoInicio = value; }
    }
    public string Sinopsis
    {
        get { return _Sinopsis; }
        set { _Sinopsis = value; }
    }
    public string ImagenSerie
    {
        get { return _ImagenSerie; }
        set { _ImagenSerie = value; }
    }
}