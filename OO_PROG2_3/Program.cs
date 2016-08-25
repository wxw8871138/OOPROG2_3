using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_PROG2_3
{
    //test class
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a side of faces you want to use(0-10):");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many times to throw:");
            int times = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("probability of obtaining the number {0}: {1} ",n, compute(times,n));
        }
        
        static double compute(int times,int n)
        {
            double p = 0;
            double count = 0;
            for (int i = 0; i < times; i++)
            {
                Dice dice = new Dice();
                Console.Write(dice.FaceUp + " ");
                if (dice.FaceUp == n)
                {
                    count++;
                }
            }
            p = count / times;
            return p;
        }
    }

    class Dice
    {
        //attribute
        private int faceup;
        private string strFaceUp;

        //constructor
        public Dice()
        {
            Throw();
        }

        //properties
        public int FaceUp
        {
            get
            {
                return faceup;
            }
            set
            {
                faceup = value;
            }
        }
        
        public string StrFaceUp
        {
            set
            {
                strFaceUp = value;
            }
        }
        public string GetFaceUp()
        {
            return strFaceUp;
        }
        //method
        public void Throw()
        {
            Random r = new Random();
            faceup = r.Next(0,10);
        }
    }
}
