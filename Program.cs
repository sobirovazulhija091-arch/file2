using System.Runtime.InteropServices;

var customersService = new CustomersService();
var carService = new CarService();
var rentalService = new RentalService();
while (true)
{
Console.WriteLine(@$"1.Add custamer:
2.Delete customer:
3.Show all cusomers:
4.Update custamer:
5.See Active or unactive customers:
6.Add car:
7.Delete car:
8.Show all car:
9.Number of cars:
10.Update car:
11.Available car:
12.Add rental:
13.Delate rental:
14.Show all:
15.Update renatl:
16.Total cost:");
string? a = Console.ReadLine();
switch (a)
{
    case"1":
    Console.WriteLine("Enter your fullname");
    string? name =Console.ReadLine();
      Console.WriteLine("Enter your phone");
     int phone =Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine("Enter your driver license number");
    string? driver = Console.ReadLine();
    var cusomers = new Customers(){FullName=name,Phone=phone,DriverLicenseNumber=driver};
     customersService.AddCustomers(cusomers);
    break;
    case"2":
        Console.WriteLine("Enter your id for delete");
     int deleteid =Convert.ToInt32(Console.ReadLine());  
      Console.WriteLine(customersService.Delete(deleteid));
    break;
    case"3":
    try
    {
        customersService.GetAll();
    }
    catch (System.Exception e)
    {
        
        Console.WriteLine($"Something whent wrong {e.Message}");
    }
    break;
    case"4":
    
         Console.WriteLine("Enter your id for update");
     int updateid =Convert.ToInt32(Console.ReadLine());  
      Console.WriteLine("Enter your new phone");
     int newphone=Convert.ToInt32(Console.ReadLine()); 
     Console.WriteLine(customersService.Update(updateid,newphone));   
    
    break;
    case"5": 
      try
      {
          Console.WriteLine(customersService.Active());
      }
      catch (System.Exception e)
      {
        
             Console.WriteLine($"Something whent wrong {e.Message}");

      }
    break;
    case"6":
     Console.WriteLine("Enter your Brand");
    string? brand =Console.ReadLine();
      Console.WriteLine("Enter your Model");
     string? model =Console.ReadLine();
      Console.WriteLine("Enter  year: ");
     int year =Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine("Enter your daily price");
     int price =Convert.ToInt32(Console.ReadLine());  
    var car = new Car(){Brand=brand,Model=model,Year=year,DailyPrice=price};
     carService.AddCar(car);
    break;
    case"7":
     Console.WriteLine("Enter your id for delete");
     int deleteidcar =Convert.ToInt32(Console.ReadLine());  
      Console.WriteLine(carService.Delete(deleteidcar));
break;
    case"8":  
     carService.GetAll();
   break;
    case"9":
     try
     {
        carService.GetCoutCars();
     }
     catch (System.Exception e)
     {
           Console.WriteLine($"Something whent wrong {e.Message}");
     }
   break;
    case"10":
   Console.WriteLine("Enter your id for update");
     int idcar =Convert.ToInt32(Console.ReadLine());  
      Console.WriteLine("Enter your new price");
     int newprice=Convert.ToInt32(Console.ReadLine()); 
     Console.WriteLine(carService.Update(idcar,newprice));
    break;
    case"11":
 try
 {
     carService.Availablecar();
 }
 catch (System.Exception e)
 {
    
     Console.WriteLine($"Something whent wrong {e.Message}");
 }
 break;
    case"12":
     Console.WriteLine("Enter your rent day");
     DateTime rentdate =Convert.ToDateTime(Console.ReadLine());
      Console.WriteLine("Enter your totalprice");
     int totalprice =Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine("Enter your return day");
    DateTime returndate = Convert.ToDateTime(Console.ReadLine());
    var rental = new Rental(){RentDate=rentdate,TotalPrice=totalprice,ReturnDate=returndate};
     rentalService.AddRental(rental);
    break;
    case"13":
       Console.WriteLine("Enter your id for delete");
     int rentalid =Convert.ToInt32(Console.ReadLine());  
      Console.WriteLine(rentalService.Delete(rentalid));
    break;
    case"14":  
 try
    {
        rentalService.GetAll();
    }
    catch (System.Exception e)
    {
        
        Console.WriteLine($"Something whent wrong {e.Message}");
    }
    break;
    case"15":
         Console.WriteLine("Enter your id for update");
     int rentalidd =Convert.ToInt32(Console.ReadLine());  
      Console.WriteLine("Enter your new total price");
     int newcost=Convert.ToInt32(Console.ReadLine()); 
     Console.WriteLine(rentalService.Update(rentalidd,newcost));   
    break;
    case"16":
    try
    {
      
        carService.Cost();
    }
    catch (System.Exception e)
    {
        
        Console.WriteLine($"Something whent wrong {e.Message}");
    }
    break;
  default:
    Console.WriteLine("Finish....");
    break;
}
}