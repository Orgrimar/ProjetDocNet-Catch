using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFightCatchApp
{
    public abstract class Catcheur
    {
        public string Nom { get; set; }
        public int Hp { get; set; }
        public int Str { get; set; }
        public int Def { get; set; }
        public bool EnAttaque = false;

        public StatutEnum Statu { get; set; }

        public Catcheur(int hp,int att,int def)
        {
            Hp = hp;
            Str = att;
            Def = def;
            //Nom = nom;
            //Statu = statu;
        }

        public void Frapper(Catcheur enemi)
        {
            enemi.Hp -= Str;
        }

        public void Defendre(Catcheur enemi)
        {
            Str -= enemi.Def;
        }

        public void CompSpec(Catcheur enemi)
        {
            Random rnd = new Random();
            int activation = rnd.Next();
            if ((activation % 2) == 0)
            {

            }
        }
        public bool ChoixAction()
        {
            Random rnd = new Random();
            int action = rnd.Next(1, 3);
            if (action == 1)
            {
                EnAttaque = true;
            }
            if (action == 2)
            {
                EnAttaque = false;
            }
            if (action == 3)
            {
                EnAttaque = true;
            }
            return EnAttaque;

        }
        public void Combat(Catcheur enemi)
        {
            if (EnAttaque)
            {
                Frapper(enemi);
            }
            else
            {
                Defendre(enemi);
            }  
        }
        

        public void Hopital()
        {
            Statu = StatutEnum.Convalescense;
            Random rnd = new Random();
            int tourHS = rnd.Next(2, 5);
        }

        public void Mort()
        {
            Statu = StatutEnum.Morgue;
        }

        public abstract void SoignerCatcheur(Catcheur target);
    }
}
