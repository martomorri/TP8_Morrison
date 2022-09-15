using System;
using System.Collections.Generic;

namespace TP8_Morrison.Models;

public class Temporada
{
    private int _IdTemporada, _IdSerie, _NumeroTemporada;
    private string _TituloTemporada;
    public Temporada(int IdTemporada, int IdSerie, int NumeroTemporada, string TituloTemporada)
    {
        _IdTemporada = IdTemporada;
        _IdSerie = IdSerie;
        _NumeroTemporada = NumeroTemporada;
        _TituloTemporada = TituloTemporada;
    }
    public Temporada()
    {
        _IdTemporada = 0; _IdSerie = 0; _NumeroTemporada = 0; _TituloTemporada = "";
    }
    public int IdTemporada
    {
        get { return _IdTemporada; }
        set { _IdTemporada = value; }
    }
    public int IdSerie
    {
        get { return _IdSerie; }
        set { _IdSerie = value; }
    }
    public int NumeroTemporada
    {
        get { return _NumeroTemporada; }
        set { _NumeroTemporada = value; }
    }
    public string TituloTemporada
    {
        get { return _TituloTemporada; }
        set { _TituloTemporada = value; }
    }
}