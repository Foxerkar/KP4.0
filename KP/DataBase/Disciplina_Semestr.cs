using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KP.DataBase
{
    public class Disciplina_Semestr
    {
        public Disciplina_Semestr() { }
        public int ID_Program { get; set; }
        public int MomSemestr { get; set; }
        public int ID_RabProg { get; set; }
        public string Type_Zanyatiya { get;set; }
        public int Okonc_Semestra { get; set; }
        public Rab_Programma Rab_Programma { get; set; }
    }
}
