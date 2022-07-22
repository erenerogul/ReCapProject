using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsoleUI
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            //UI kısmında burda car managerı kullanarak InMemory teknolojisini kullanarak managele diyoruz 
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}