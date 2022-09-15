using System;
using System.Collections.Generic;

namespace TP8_Morrison.Models;

public class Actor
{
    private int _IdActor, _IdSerie;
    private string _Nombre;
    public Actor(int IdActor, int IdSerie, string Nombre)
    {
        _IdActor = IdActor;
        _IdSerie = IdSerie;
        _Nombre = Nombre;
    }
    public Actor()
    {
        _IdActor = 0; _IdSerie = 0; _Nombre = "";
    }
    public int IdActor
    {
        get { return _IdActor; }
        set { _IdActor = value; }
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
}