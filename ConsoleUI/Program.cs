// See https://aka.ms/new-console-template for more information



using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new InMemoryCarDal());

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.Description);
//}



//BrandManager brandManager = new BrandManager(new EfBrandDal());


//var result = brandManager.GetById(5);          // ekleme, listeleme, silme, güncelleme, id'ye göre getirme var

//Console.WriteLine(result.BrandName);

//foreach (var brand in brandManager.GetAll())
//{
//    Console.WriteLine(brand.BrandName);
//}




//ColorManager colorManager = new ColorManager(new EfColorDal());   //--->Ekleme, silme, güncelleme, listeleme, id'ye göre getirme var


//var result = colorManager.GetById(4);
//Console.WriteLine(result.ColorName);

//colorManager.Delete(new Color { ColorName = "Blue değişti", Id = 1003});

//foreach (var color in colorManager.GetAll())
//{
//    Console.WriteLine(color.ColorName);
//}





//CarManager carManager = new CarManager(new EfCarDal()); // CRUD var,  id'ye göre getirme tamam




//foreach (var car in carManager.GetCarDetails())
//{
//    Console.WriteLine(car.CarName + " / " + car.ColorName + " / " + car.BrandName + " / " + car.DailyPrice);
//}

//carManager.Delete(new Car { Id=1002,BrandId=3, ColorId=2, CarName="araba4 değişti", DailyPrice=800, ModelYear=new DateTime(2020,01,01), Description="araba4 açıklama"});


//var result = carManager.GetById(3);

//Console.WriteLine(result.CarName);


//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.CarName);
//}