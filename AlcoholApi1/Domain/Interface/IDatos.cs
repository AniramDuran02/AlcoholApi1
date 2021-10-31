using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcoholApi1.Domain.Interface
{
    public interface IDatos
    {
        void AlcoholIngerido(string bebida, int cantidad);
        void CantidadAlcoholSangre(int peso);
        string Validar();
    }
}
