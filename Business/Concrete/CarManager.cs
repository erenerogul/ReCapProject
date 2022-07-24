﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;

        }

        public void Add(Car car)
        {
            if (car.Description.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
          
        }

        public List<Car> GetAll()
        {
            //İş kodları
            //Bu metod dönmeden önce kontroller vesaire yapacağımız yer burası 

            return _carDal.GetAll();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetAll(b => b.BrandId == brandId);
        }

        public List<Car> GetByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }
    }
}