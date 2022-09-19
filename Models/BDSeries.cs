using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace TP8_Morrison.Models;

public static class BDSeries
{
    private static string _connectionString = @"Server=A-PHZ2-CIDI-017; DataBase=BDSeries; Trusted_Connection=true;";
    public static List<Serie> ListarSeries()
    {
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sp = "ListarSeries";
            return db.Query<Serie>(sp, commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public static Serie ListarSerieXID(int IdSerie)
    {
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sp = "ListarSerieXID";
            return db.QueryFirstOrDefault<Serie>(sp, new { @IdSerie = IdSerie }, commandType: CommandType.StoredProcedure);
        }
    }
    public static List<string> ListarActores(int IdSerie)
    {
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sp = "ListarActoresXSerie";
            return db.Query<string>(sp, new { @IdSerie = IdSerie }, commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public static List<Temporada> ListarTemporadas(int IdSerie)
    {
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            string sp = "ListarTemporadasXSerie";
            return db.Query<Temporada>(sp, new { @IdSerie = IdSerie }, commandType: CommandType.StoredProcedure).ToList();
        }
    }
}