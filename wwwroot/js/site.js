function VerInfoSerie(id, nombre)
{
    $.ajax(
        {
            type:'POST',
            datatype:'JSON',
            url:'/Home/VerInfoSerie',
            data: { IdSerie : id },

            success : function(response)
            {
                $("#Titulo").html(nombre);
                $("#Imagen").attr("src",response.imagenSerie);
                $("#Texto").html("<p></p>Año de inicio: " + response.añoInicio + "</br><p></p>Sinopsis: " + response.sinopsis);
            }
        }
    )
}

function VerActores(id, nombre)
{
    $.ajax(
        {
            type:'POST',
            datatype:'JSON',
            url:'/Home/VerActores',
            data: { IdSerie : id },

            success : function(response)
            {
                let a = "";
                response.forEach(actor => {
                    a += actor + "</br>";
                });
                $("#Titulo").html(nombre);
                $("#Imagen").attr("src","");
                $("#Texto").html(a);
            }
        }
    )
}

function VerTemporadas(id, nombre)
{
    $.ajax(
        {
            type:'POST',
            datatype:'JSON',
            url:'/Home/VerTemporadas',
            data: { IdSerie : id },

            success : function(response)
            {
                let t = "";
                response.forEach(actor => {
                    t += actor.numeroTemporada + " " + actor.tituloTemporada + "</br>";
                });
                $("#Titulo").html(nombre);
                $("#Imagen").attr("src","");
                $("#Texto").html(t);
            }
        }
    )
}
