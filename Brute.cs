using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFightCatchApp
{
    class Brute : Catcheur
    {
        private int _hpMax;

        public Brute(string nom, StatutEnum statu)
            : base(100,5,1)
        {
            _hpMax = 100;
        }

        public override void SoignerCatcheur(Catcheur target)
        {
            target.Hp = _hpMax;
        }
    }
}
