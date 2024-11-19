using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05_Structs
{
    class Program
    {
        struct KeyValueStruct
        {
            public int Key;
            public string Value;
        }

        static void Sort(KeyValueStruct[]arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1 - j; i++)
                {
                    if (arr[i + 1].Key < arr[i].Key)
                    {
                        KeyValueStruct buf = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = buf;
                    }
                }
            }
        }

        static KeyValueStruct[] Merger(KeyValueStruct[] s1, KeyValueStruct[] s2)
        {
            KeyValueStruct[] arrTmp = new KeyValueStruct[s1.Length];
            for (int i = 0; i < s1.Length; i++)
            {
                arrTmp[i].Key = s1[i].Key + s2[i].Key;
                arrTmp[i].Value = s1[i].Value + s2[i].Value;
            }

            return arrTmp;
        }

        static int BinarySearch(KeyValueStruct[] ss, int key)
        {
            int index = -1;
            for (int i = 0; i < ss.Length; i++)
            {
                //byte[] arrByte1 = BitConverter.GetBytes(ss[i].Key);
                //byte[] arrByte2 = BitConverter.GetBytes(key);
                //if (BitConverter.GetBytes(ss[i].Key) == BitConverter.GetBytes(key));

                if ((byte)ss[i].Key == (byte)key)
                {
                    index = i;
                    return i;
                }
                else if(index > -1)
                {
                    return index;
                }
            }
            return index;
        }
        
        static void Main(string[] args)
        {
            /*1. Объявить статический метод void Sort(KeyValueStruct[] ss),
             * который упорядочит структуры в массиве по возрастанию ключа.
              
              2. Объявить статический метод int BinarySearch(KeyValueStruct[] ss, int key),
                который по заданному ключу key находит индекс структуры в массиве ss. 
            Если структуры с заданным ключом нет, метод возвращает -1. 
            Элементы массива упорядочены по возрастанию ключа.

              3. Объявить статический метод KeyValueStruct[] Merge (KeyValueStruct[] s1, 
            KeyValueStruct[] s2), который сливает два упорядоченных массива структур 
            в третий, тоже упорядоченный. 
            Элементы массивов упорядочены по возрастанию ключа.*/


            Console.WriteLine("=============== 1 ==============");

            Random rand = new Random();
            const int size = 5;
            KeyValueStruct[] arrStructs = new KeyValueStruct[size];
            KeyValueStruct[] arrStructs2 = new KeyValueStruct[size];

            for (int i = 0; i < arrStructs.Length; i++)
            {
                arrStructs[i].Key = rand.Next(1, 5);
                arrStructs[i].Value = $"{rand.Next(10, 100)}";

                arrStructs2[i].Key = rand.Next(1, 5);
                arrStructs2[i].Value = $"{rand.Next(10, 100)}";

                //Console.Write($"{arrStructs[i].Key} ");
            }

            Console.WriteLine();

            Sort(arrStructs);
            Sort(arrStructs2);

            Console.Write("arrStructs: ");

            for (int i = 0; i < arrStructs.Length; i++)
            {
                Console.Write($"{arrStructs[i].Key} ");
            }

            Console.WriteLine();
            Console.Write("arrStructs2: ");

            for (int i = 0; i < arrStructs.Length; i++)
            {
                Console.Write($"{arrStructs2[i].Key} ");
            }

            Console.WriteLine("\n=============== 2 ==============");

            Console.WriteLine($"index: {BinarySearch(arrStructs, 3)}");

            Console.WriteLine("\n=============== 3 ==============");

            KeyValueStruct[] arrStructs3 = new KeyValueStruct[size];
            
            arrStructs3 = Merger(arrStructs,arrStructs2);

            Sort(arrStructs3);

            for (int i = 0; i < arrStructs3.Length; i++)
            {
                Console.Write($"{arrStructs3[i].Key}\t");
            }

            Console.WriteLine();

            for (int i = 0; i < arrStructs3.Length; i++)
            {
                Console.Write($"{arrStructs3[i].Value}\t");
            }

            Console.ReadKey();
        }
    }
}
