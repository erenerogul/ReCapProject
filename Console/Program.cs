using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsoleUI
{
    //birim test mantığına yakın çalışır -- Unit testw
    public class Program
    { 
        public static void Main(string[] args)
        {
            //UI kısmında burda car managerı kullanarak InMemory teknolojisini kullanarak managele diyoruz 
            //CarTest();
            //ColorTest();
            //BrandTest();
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Description + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetByColorId(5))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}