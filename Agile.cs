using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFightCatchApp
{
    class Agile : Catcheur
    {
        private int _hpMax;

        public Agile(string nom, StatutEnum statu)
            : base(125,3,3)
        {
            _hpMax = 125;
        }

        public override void SoignerCatcheur(Catcheur target)
        {
            target.Hp = _hpMax;
        }
    }
}
