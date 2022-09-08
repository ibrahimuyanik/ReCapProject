// See https://aka.ms/new-console-template for more information



using Business.Concrete;
using Core.Utilities.Results;
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


//var result = carManager.GetCarDetails();

//if (result.Success)
//{
//	//Console.WriteLine(result.Message);
//	foreach (var car in result.Data)
//	{
//		Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName);
//	}
//}  




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




//UserManager userManager = new UserManager(new EfUserDal());


//var result = userManager.GetById(1);

//if (result.Success)
//{
//    Console.WriteLine(result.Data.FirstName);
//}



//userManager.Add(new User { Id=2, FirstName="ümit", LastName="ciğeroğlu", Email="deneme2@gmail.com", Password="123456"});




//var result2 = userManager.GetAll();

//if (result2.Success)
//{
//    foreach (var user in result2.Data)
//    {
//        Console.WriteLine(user.FirstName);
//    }

//}



//CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

//var result = customerManager.Delete(new Customer {  CustomerId=4,UserId=1, CompanyName = "güncellendi"});
//if (result.Success)
//{
//    Console.WriteLine(result.Success);
//}


//var result = customerManager.GetById(1);

//if (result.Success)
//{
//    Console.WriteLine(result.Data.CompanyName);
//}



RentalManager rentalManager = new RentalManager(new EfRentalDal());

var result = rentalManager.Add(new Rental { CarId=3, CustomerId=2, RentDate=DateTime.Now });

if (result.Success)
{
    Console.WriteLine(result.Message);

}
else
{
    Console.WriteLine(result.Message);
}
//foreach (var rental in rentalManager.GetAll().Data)
//{
//    Console.WriteLine(rental.ReturnDate);
//}