using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholApi1.Services
{
    public class AlcoholServices
    {
        public double CalcularTotalAlcoholConsumido(string bebida, int Cantidad)
        {
            int totalBebidaConsumido;
            double AlcoholPorBebidaConsumido;
            switch (bebida)
            {
                case "cerveza":
                    totalBebidaConsumido = Cantidad * 330;
                    AlcoholPorBebidaConsumido = totalBebidaConsumido * 0.05;
                    break;

                case "vino" or "cava":
                    totalBebidaConsumido = Cantidad * 100;
                    AlcoholPorBebidaConsumido = totalBebidaConsumido * 0.12;
                    break;

                case "vermu":
                    totalBebidaConsumido = Cantidad * 70;
                    AlcoholPorBebidaConsumido = totalBebidaConsumido * 0.24;
                    break;

                case "licor":
                    totalBebidaConsumido = Cantidad * 45;
                    AlcoholPorBebidaConsumido = totalBebidaConsumido * 0.51;
                    break;

                case "brandy":
                    totalBebidaConsumido = Cantidad * 45;
                    AlcoholPorBebidaConsumido = totalBebidaConsumido * 0.84;
                    break;

                case "combinado":
                    totalBebidaConsumido = Cantidad * 50;
                    AlcoholPorBebidaConsumido = totalBebidaConsumido * 0.76;
                    break;
                default:
                    return AlcoholPorBebidaConsumido = 0;
            }
            return AlcoholPorBebidaConsumido;

        }

        internal object CalcularTotalAlcoholConsumido(string bebida, object cantidad)
        {
            throw new NotImplementedException();
        }

        //calcular la cantidad de alcohol que pasa directo a la sangre
        public double CalcularCantidadAlcoholSangre(double AlcoholPorBebidaConsumido)
        {
            double CantAlcoholSangre = (AlcoholPorBebidaConsumido * 15) / 100;
            return CantAlcoholSangre;
        }
        //calcular la masa del etanol en sangre
        public double CalcularMasa(double CantAlcoholSangre)
        {
            double masa = 0.789 * CantAlcoholSangre;
            return masa;
        }

        //calcular el volumen de la sangre de la persona considerando su peso
        public double CalcularVolumenSangre(double peso)
        {
            double volumenSangre = (8 * peso / 100);
            return volumenSangre;
        }

        //calcular el volumen de alcochol en la sangre (alcoholemia)
        public double CalcularVolumenAlcohol(double masa, double voluSangre)
        {
            double voluAlcohol = masa / voluSangre;
            return voluAlcohol;
        }

        //validar si es apto para manejar
        public string Validar(double voluAlcohol)
        {
            string resultado;

            if (voluAlcohol > 0.8)
            {
                resultado = $"La cantidad de alcohol que tiene es: {voluAlcohol}. es superior a 0.8 y no es apta para manejar.";
                return resultado;
            }
            resultado = $"La cantidad de alcohol que tiene es: {voluAlcohol}. es inferios a 0.8 y es apta para manejar. ";
            return resultado;
        }
    }
}
