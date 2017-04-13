using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDocNet_Catch
{
    class Agile : Catcheur
    {
        private int _hpMax;

        public Agile(string nom, StatuEnum statu) 
            : base(nom, statu)
        {
            _hpMax = 125;
            Str = 3;
            Def = 3;
            Hp = _hpMax;
        }

        public override void SoignerCatcheur(Catcheur target)
        {
            target.Hp = _hpMax;
        }
    }
}
