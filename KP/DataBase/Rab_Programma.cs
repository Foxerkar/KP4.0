using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP.DataBase
{
    public class Rab_Programma
    {
        public Rab_Programma() { }

        public int ID_RabProg { get; set; }
        public int ID_grup { get; set; }
        public int ID_Disciplina { get; set; }
        public int FAK_HOURS { get; set; }
        public int AUDIT_HOURS { get; set; }

        public Gruppa Gruppa { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
