using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_05_Enum
{
    class Program
    {
        enum CommodityType // тип товара
        {
            FrozenFood, Food, DomesticChemistry, BuildingMaterials, Petrol
        }

        enum TransportType // тип транспорта
        {
            Semitrailer, Coupling, Refrigerator, OpenSideTruck, FuelTruck
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 5");

            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number < 6)
            {
                CommodityType commodity = (CommodityType)Enum.GetValues(typeof(CommodityType)).GetValue(number - 1);

                //CommodityType commodity1 = (CommodityType)(number - 1);

                TransportType transport = TransportType.Semitrailer;

                switch (commodity)
                {
                    case CommodityType.FrozenFood:
                        transport = TransportType.Refrigerator;
                        break;
                    case CommodityType.Food:
                        transport = TransportType.Semitrailer;
                        break;
                    case CommodityType.DomesticChemistry:
                        transport = TransportType.Coupling;
                        break;
                    case CommodityType.BuildingMaterials:
                        transport = TransportType.OpenSideTruck;
                        break;
                    case CommodityType.Petrol:
                        transport = TransportType.FuelTruck;
                        break;
                }
                Console.WriteLine("Для товара - {0} необходим транспорт - {1}.", commodity, transport);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
