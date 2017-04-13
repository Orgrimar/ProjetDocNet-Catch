using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDocNet_Catch
{
    public abstract class Catcheur
    {
        public string Nom { get; set; }
        public int Hp { get; set; }
        public int Str { get; set; }
        public int Def { get; set; }

        public StatuEnum Statu { get; set; }

        public Catcheur(string nom, StatuEnum statu)
        {
            Nom = nom;
            Statu = statu;
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

        public abstract void SoignerCatcheur(Catcheur target);
    }
}
