using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunTakip
{
    class Program
    {
        static void Main(string[] args)

        {
            string conString = "Data Source=MATHEMATICHE;Initial Catalog=PROJEDB;Persist Security Info=True;User ID=sa;Password=393895";
            Bolumler blm = new Bolumler(conString);
            blm.deleteData(1);
        }
    }
}
