using System;
using System.Collections.Generic;
using System.Text;

namespace WSTowers.Models
{
    public class Jogo
    {
        public int idJogo { get; set; }
        public string timeCasa { get; set; }
        public string timeVisitante { get; set; }
        public DateTime data { get; set; }

        public override string ToString()
        {
            return $"{timeCasa}  X {timeVisitante} ";
        }
    }
}
