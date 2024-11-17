using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_05_Enum_Struct
{
    //enum MyEnum2{}
    
    class Program
    {
        //enum MyEnum{}
        
        enum Suits
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        enum Cats
        {
            Tiger = 1,
            Lion = 34,
            Puma,
            Barsik = Puma + 4,
            Guepard = 34
        }

        enum Cars : byte
        {
            Ford,
            BMW,
            Nissan = 254,
            Opel
        }
        static void Main(string[] args)
        {
            //enum MyEnum{} Error

            //Cats cat = Cats.Barsik;
            //Console.WriteLine((int)cat);
            //switch (cat)
            //{
            //    case Cats.Tiger:
            //        break;
            //    case Cats.Lion:
            //        break;
            //    case Cats.Puma:
            //        break;
            //    case Cats.Barsik:
            //        break;
            //    //case Cats.Guepard:
            //        //break;
            //    default:
            //        break;
            //}



            //int number = 4567;
            //Suits suit = Suits.Clubs;

            //switch (suit)
            //{
            //    case Suits.Clubs:
            //        break;
            //    case Suits.Diamonds:
            //        break;
            //    case Suits.Hearts:
            //        break;
            //    case Suits.Spades:
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(suit);

            //foreach (var item in Enum.GetNames(typeof(Suits)))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(Enum.GetName(typeof(Suits),3));

            //foreach (Suits item in Enum.GetValues(typeof(Suits)))
            //{
            //    Console.Write($"{(int)item}\t");
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(Enum.IsDefined(typeof(Suits), 7)); // false
            //Console.WriteLine(Enum.IsDefined(typeof(Suits), "qqq")); // false
            //Console.WriteLine(Enum.IsDefined(typeof(Suits), 1)); // true
            //Console.WriteLine(Enum.IsDefined(typeof(Suits), "Diamonds")); // true

            Cars car = Cars.Opel;

            int n = (byte)car;
            Console.WriteLine(n);
            Console.WriteLine();

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
