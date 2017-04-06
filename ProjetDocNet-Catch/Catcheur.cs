using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDocNet_Catch
{
    abstract class Catcheur
    {
        public string Nom { get; set; }
        public int Hp { get; set; }
        public int Str { get; set; }
        public int Def { get; set; }

        public StatuEnum Statu { get; set; }

        public Catcheur(string nom, int hp, int str, int def)
        {
            Nom = nom;
            Hp = hp;
            Str = str;
            Def = def;
            Statu = StatuEnum.Disponible;
        }

        public void ChoixAction()
        {
            Random rnd = new Random();
            int action = rnd.Next(1, 3);
            switch (action)
            {
                case 1:
                    Frapper(target, attaquant);
                    break;
                case 2:
                    Defendre(target, attaquant);
                    break;
                case 3:
                    CompSpec(target, attaquant);
                    break;
            }
        }

        public void Frapper(Catcheur target, Catcheur attaquant)
        {
            target.Hp -= attaquant.Str;
        }

        public void Defendre(Catcheur target, Catcheur attaquant)
        {
            attaquant.Str -= target.Def;
        }

        public void CompSpec(Catcheur target, Catcheur attaquant)
        {
            Random rnd = new Random();
            int activation = rnd.Next();
            if ((activation % 2) == 0)
            {

            }

        }

        public abstract void SoignerCatcheur(Catcheur target);
    }
}
