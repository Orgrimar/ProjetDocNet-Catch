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

        public Brute(string nom, int hp, int str, int def) 
            : base(nom, hp, str, def)
        {
            _hpMax = 100;
            Str = 5;
            Def = 1;
        }

        public void Hopital()
        {
            Statu = StatuEnum.Convalescense;
            Random rnd = new Random();
            int tourHS = rnd.Next(2, 5);
        }

        public void Mort()
        {
            Statu = StatuEnum.Morgue;
        }

        public override void SoignerCatcheur(Catcheur target)
        {
            target.Hp = _hpMax;
        }
    }
}
