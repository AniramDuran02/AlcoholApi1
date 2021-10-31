using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlcoholApi1.Domain.Entities;

namespace AlcoholApi1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlcoholBebidaController:ControllerBase
    {
        [HttpGet]
        [Route("IDatos")]
        /* 
    Nombre de la escuela: Universidad Tecnologica Metropolitana

    Asignatura: Aplicaciones Web Orientadas a Servicios

    Nombre del Maestro: Joel Ivan Chuc Uc

    Nombre de la actividad: Actividad 2 (Unidad ll)

    Nombre del alumno: Anaeli Aniram Duran Canche

    Cuatrimestre: 4    Grupo: B    Parcial: 2
*/
        public IActionResult Calcula(string bebida, int cantidad, int peso)
        {

            var resultado = new BebidaEntitie();
            resultado.AlcoholIngerido(bebida, cantidad);
            if (bebida.ToLower() != "licor" && bebida.ToLower() != "vermu" && bebida.ToLower() != "cava"
            && bebida.ToLower() != "vino" && bebida.ToLower() != "cerveza" && bebida.ToLower() != "brandy")
            {
                return Ok("Usted a Ingresado Una Bebida INCORRECTA.");
            }
            resultado.CantidadAlcoholSangre(peso);

            return Ok(resultado.Validar());
        }
    }
}
