function VerInfoSerie(id)
{
    $.ajax(
        {
            type:'POST',
            datatype:'JSON',
            url:'/Home/VerInfoSerie',
            data: { IdSerie : id },

            success : function(response)
            {
                $("#Titulo").html(response.nombre);
                $("#Imagen").attr("src",response.imagenSerie);
                $("#Numero").html(response.añoCreacion);
                $("#Sinopsis").html(response.sinopsis);
            }
        }
    )
}

function VerActores(id)
{
    $.ajax(
        {
            type:'POST',
            datatype:'JSON',
            url:'/Home/VerActores',
            data: { IdSerie : id },

            success : function(response)
            {
                let a="";
                response.forEach(element=> {
                    a += element + "</br>";
                });
                $("#Texto").html(a);
            }
        }
    )
}

function VerTemporadas(id)
{
    $.ajax(
        {
            type:'POST',
            datatype:'JSON',
            url:'/Home/VerTemporadas',
            data: { IdSerie : id },

            success : function(response)
            {
                response.forEach(function(temporada)
                {
                    console.log(temporada);
                });
                $("#Numero").html(temporada.numeroTemporada)
                $("#Texto").html(temporada.tituloTemporada);
            }
        }
    )
}
