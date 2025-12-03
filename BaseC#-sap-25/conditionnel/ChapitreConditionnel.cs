using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseC__sap_25.conditionnel
{
    internal class ChapitreConditionnel
    {
        /**
         * Lorsqu'on parle de structure de contrôle de flux en programmation, on parle principalement
         * de 2 choses :
         *  1. Les structures conditionnelles
         *  2. Les structures itératives
         *  
         *  Ce chapitre aborde les structures conditionnelles.
         *  
         *  La 1ère d'entre elles est le if-else.
         */
        public void LeIfEtLeElse()
        {
            bool estMajeur = false;

            if (estMajeur)
            {
                Console.WriteLine("Tu es majeur.");
            }
            else
            {
                Console.WriteLine("Tu es mineur");
            }

            /**
             * Pour un cas simple comme celui ci-dessus, ça marche très bien avec juste un if et un else,
             * mais que se passe-t-il dans le cas ou je veux vérifier plusieurs conditions différentes :
             */
            byte age = 16;

            if (age > 30)
            {
                Console.WriteLine("Adulte confirmé");
            }
            else if (age > 20)
            {
                Console.WriteLine("Bébé adulte");
            }
            else if (age > 15)
            {
                Console.WriteLine("Ado");
            }
            else
            {
                Console.WriteLine("Enfant");
            }


        }

        /// <summary>
        /// Le Switch est un "if else" un peu plus moderne en terme de syntaxe d'écriture.
        /// </summary>
        public void LeSwitch() 
        {
            byte jourSemaine = 1;

            switch (jourSemaine)
            {
                case 1:
                {
                    Console.WriteLine("Lundi");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Mardi");
                    break;
                }
                default:
                {
                    Console.WriteLine("Un autre jour");
                    break;
                }
            }
            
        }
    }
}
