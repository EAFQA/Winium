using PDV_Tests.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV_Tests.Utils
{
    public class GeraData : BaseTest
    {
        public DateTime GerarData()
        {
            Random rdn = new Random();

            int ano = rdn.Next(1990, 2050);
            int mes = rdn.Next(01, 12);
            int dia = DateTime.DaysInMonth(ano, mes);
            int Dia = rdn.Next(1, dia);
            DateTime data = new DateTime(Dia, mes, ano);

            return data;
        }
    }
}
