using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace tableau
{

    public class Tableau
    {

        public int dim;
        public int[] tabl1;   //tableau des entiers
        public string[] tablestring;  //tableau des chars
        public int i, h;
        





        public Tableau(int dim) {
            tabl1 = new int[dim];  //constructeur
            tablestring = new string[dim];
            this.dim = dim;


        }
        //insertion entier
        public int insertion(int index, int valeur)
        {
            
            if (index < dim)
            {
                tabl1[index] = valeur;
                return 1;
            }
            else
            {
                return 0;
            }


        }
        //insertion cha

        public int Insertion(int index, string valeurst) 
        {
            if(index<dim && index >= 0)
            {
                tablestring[index] = valeurst;
                return 1;

            }
            else
            {
                return 0;
            }
        }

        //tableau entier
        public static void suppression<T>(ref int[] tabl1, int index)
        {
            for (int a = index; a < tabl1.Length - 1; a++)
            {

                tabl1[a] = tabl1[a + 1];
            }

            Array.Resize(ref tabl1, tabl1.Length - 1);
        }
        // tableau char
        public static void suppression<T>(ref string[] tablestring, int index)
        {
            for (int a = index; a < tablestring.Length - 1; a++)
            {

                tablestring[a] = tablestring[a + 1];
            }

            Array.Resize(ref tablestring, tablestring.Length - 1);
        }




        public int Recherche(ref int[] tabl1, int index, int h, int i = 0) {

            while (i < dim && h != tabl1[i])
            {
                i++;
                if (i < dim)
                {
                    
                    return 1;
                }
                else
                {
                    return 0;

                }

            }


        }
        //tableau cha
        public int Recherche(ref string []tablestring, int index ,int i, string valeur_recherche)
        {
                for (i = 0; i < tablestring.Length; i++)
            {
                if (tablestring[i] == valeur_recherche)
                {
                    return 1;

                }
                else
                {
                    return 0;
                }
            }
        }
        //tableau entier
        public static void trier(ref int []tabl1)
        {
            Array.Sort(tabl1);
            foreach(int value in tabl1)
            {
                Console.WriteLine(value + "");
            }

        }

        public static void trier(ref int []tabl1)
        {
            int t;
            //triage du tableau
            for (int h= 0; h < tabl1.Length; h++)
            {
                for(int j = 0; j < tabl1.Length - 1; j++)
                {
                    if (tabl1[j] > tabl1[j + 1])
                    {
                        t = tabl1[j + 1];
                        tabl1[j + 1] = tabl1[j];
                        tabl1[j] = t;
                    }

                }

            }
        }
        //tableau 



        public static void symetrie(ref int[] tabl1 , int q)
        {
            

        }

        public string[] concatenation(ref  int[] tabl1)
        {
            int[] tabl2 = { 1, 6, 5 };
            int taille_tab3 = tabl1.Length + tabl2.Length;
            int [] table_concatene = new int[taille_tab3];
            int i = 0;
            foreach(int s in tabl1)
            {
                table_concatene[i] = s;
                i++;
            }
            foreach(int s in tabl2)
            {
                table_concatene[i] = s;
                i++;
            }
            return table_concatene[];
                 


        }

        public  void affichage()
        {
            foreach(int n in tabl1)
            {
                Console.WriteLine(n);
            }
        }

    }


    class Program
        {
        


        }
    }

