using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AplikacjaZawodnicy
{
    internal class TemperaturyRepository
    {
        private string connString = "Data Source=.\\sqlexpress;Initial Catalog=A_Zawodnicy;Integrated Security=True";

        public void DodajTemperature(Temperatura temp)
        {
            string sql = "insert into historiaTemperatury (nazwaMiasta,dataSprawdzenia,temperatura) values ('{0}','{1}',{2})";
            sql = string.Format(sql, temp.Miasto, temp.Data.ToString("yyyy-MM-dd hh:mm:ss"), temp.Wartosc);

            PolaczenieZBaza pzb = new PolaczenieZBaza(connString);
            pzb.WykonajZapytanie(sql);
        }
    }
}