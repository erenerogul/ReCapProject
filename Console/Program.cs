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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetByColorId(5))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}