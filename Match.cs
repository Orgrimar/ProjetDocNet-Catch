using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFightCatchApp
{
	public class Match
	{

		const int maxIteration = 20;

		public int nbIteration = 1;
		public int gain = 0;

		public void gainRecu(Catcheur C1, Catcheur C2)
		{
			while (nbIteration != maxIteration)
			{
				gain += 5000;
				nbIteration++;

				if (C1.Hp == 0 || C2.Hp == 0 && nbIteration != maxIteration)
				{
					gain += 10000;

				}
				return;
			}

			if (nbIteration == maxIteration)
			{
				gain += 1000;
			}
		}

		public void matchOver(Catcheur C1, Catcheur C2)
		{
			if (C1.Hp == 0)
			{
				C1.Mort();
			}

			if (C2.Hp == 0)
			{
				C2.Mort();
			}

			if (C1.Hp > C2.Hp)
			{
				C1.SoignerCatcheur(C1);
				C2.Hopital();
			}

			if (C2.Hp > C1.Hp)
			{
				C2.SoignerCatcheur(C2);
				C1.Hopital();
			}
		}

        public void QuiCommence(Catcheur C1, Catcheur C2)
        {
            Random rnd = new Random();
            int begins = rnd.Next(0, 1);
            if (begins == 0)
            {
                C1.Combat(C2);
                C2.Combat(C1);
            }
            else
            {
                C2.Combat(C1);
                C1.Combat(C2);
            }
        }

        public   void CommencerCombat(Catcheur C1, Catcheur C2)
        {
            while((nbIteration<maxIteration) && (C1.Hp!= 0 && C2.Hp != 0))
            {
                QuiCommence(C1,C2);
                nbIteration++;
            }
        }
	}
}
