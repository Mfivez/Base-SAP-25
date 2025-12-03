using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseC__sap_25.variables
{
    /// <summary>
    /// Class <c>ChapitreVariable</c> est la classe qui stocker les démonstrations et les exercices du
    /// chapitre sur les variables..
    /// </summary>
    internal class ChapitreVariable
    {
        #region Démonstrations
        /// <summary>
        /// Représente l'explication du fonctionnement du cycle de vie variables en C#
        /// </summary>
        public void DeclarerEtInitialiserUneVariable()
        {
            #region Déclaration
            /** 
             Une variables, c'est :
                - Nom
                - Valeur
                - Type
                - Référence mémoire.
             **/
            int monEntier;
            #endregion

            #region Initialisation
            /** 
            Initialiser une variable, c'est remplir la boîte qu'on a réservé en mémoire avec une valeur
            pour la 1ère fois.
             **/
            monEntier = 12;
            #endregion

            #region Modification de la valeur d'une variable
            /** 
            Même procédure que pour l'initialisation :
                1 : Nom de la variable qui subira le changement de valeur
                2 : Utilisation de l'opérateur d'affectation : ❗❗❗❗ 1 SEUL EGAL
                3 : Insérer la nouvelle valeur (ici 12)
             **/
            monEntier = 13;
            #endregion

        }

        /// <summary>
        /// Démontre les opérations de lecture & d'écriture en C#.
        /// </summary>
        public void LectureEtEcriture()
        {
            #region Lecture
            /**
             * Le Console.ReadLine() oblige l'utilisateur à entrer une valeur en console.
             *  -> Console.Read() #input = "coucou"
            **/
            //string entreeUtilisateur1 = Console.ReadLine();
            #endregion

            #region Ecriture
            /**
             * Au niveau des opérations d'écriture en C#, je retrouve sur Console, les opérations suivantes :
             *  -> Console.Write(""); --> J'écris et je ne passe pas à la lignes :
             *      exemple :
             *           Console.Write("coucou");
             *           Console.Write("coucou2");
             *           
             *           En console : coucoucoucou2
             *           
             *  -> Console.WriteLine(""); --> J'écris et je passe à la ligne
             *      exemple :
             *          Console.WriteLine("coucou");
             *          Console.WriteLine("coucou2");
             *          
             *          En console : 
             *              -> Sur une 1ère ligne : coucou
             *              -> Sur une 2nd ligne : coucou2
            **/
            Console.Write("azezaea \n");
            Console.Write("2azeaze");

            Console.WriteLine("============================");

            Console.WriteLine("azezaea");
            Console.WriteLine("2azeaze");
            #endregion

            #region Lire une valeur et la transformer d'un type à l'autre
            

            /**
             * Min & Max value sont des propriétés récupérable depuis les types entiers.
             * Elles permetent de récupérer le plus grand nombre et le plus petit nombre
             * définissable dans chacun de ces types.
             */
            Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");

            /**
             * Ici, je propose à l'utilisateur de donner son âge.
             * Une fois fait, je vais venir stocker l'âge de l'utilisateur dans une variable.
             * Un âge étant une valeur entière numérique, je choisis donc un type entier.
             * Le meilleur type possible dans ce cas est le byte.
             * 
             * Cependant, la méthode Console.ReadLine() retourne une valeur au format string.
             * 
             * Je vais donc devoir transformer la dite valeur vers le type byte.
             * Pour se faire, je possède sur chacun des types primitifs, la possibilité d'accéder 
             * à la fonction utilitaire Parse() :
             *  -> string userInput = Console.ReadLine();
             *  -> byte age = byte.Parse(userInput);
             *  
             *  Notes :
             *  Console.ReadLine(), ne renvoie pas tout à fait du string.
             *  En fait, elle retourne plutôt : string? -> du string ou null.
             *  
             *  Résultat, la fonction Parse, me souligne Console.ReadLine en vert afin de me prévenir.
             *      -> J'attends du string, et tu me passes peut-être du string (mais pas sûr)
             *          -> ❗Il y a peut-être un risque de se retrouver avec un comportement inattendu.
             *          
             *      -> Pour palier à ça, je possède le ! qui me permet de dire à c# :
             *          -> tkt le reuf, fais confiance, c'est du string.
             * 
             *      -> A l'inverse je possède le toString qui me permet de transformer un type vers du string.
             */
            Console.WriteLine("Donne-moi ton âge : ");
            byte? age = byte.Parse(Console.ReadLine());
            age.ToString();



            #endregion
        }
        #endregion

        #region Exos
        public void Exo1()
        {
            Console.WriteLine("Coucou exo");
        }
        #endregion

    }
}
