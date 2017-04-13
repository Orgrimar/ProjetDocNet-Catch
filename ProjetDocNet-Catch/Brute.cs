using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDocNet_Catch
{
    class Brute : Catcheur
    {
        private int _hpMax;

        public Brute(string nom, StatuEnum statu) 
            : base(nom, statu)
        {
            _hpMax = 100;
            Str = 5;
            Def = 1;
            Hp = _hpMax;
        }

        public override void SoignerCatcheur(Catcheur target)
        {
            target.Hp = _hpMax;
        }
    }
}
