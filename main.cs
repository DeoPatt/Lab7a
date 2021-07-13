using System;

class MainClass {


  public static void Main (string[] args) {
Customers();
 
}
public static void Customers()
{
      int totalCustomers;
 Console.WriteLine("How Many Customers are parked ??");
 int customers = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Is there anymore customers ??");
 var answer = Console.ReadLine();
 if (answer == "no")
 {
   totalCustomers = customers;
   Console.WriteLine("The total amount of customers is " + totalCustomers);
 }
   else {
     Console.WriteLine("How many more ??");
     int customers2 = Convert.ToInt32(Console.ReadLine());
      totalCustomers = customers + customers2;
     Console.WriteLine("Total amount of customers is " + totalCustomers);
   }
   Console.WriteLine("How many hours did each customer parked for ? "); 
 for(int i= 0; i<totalCustomers; i++)
 {
  
 CalculateCharges();

 }
}
public static double CalculateCharges()
{
double totalCharges = 0;
 double hrs = Convert.ToDouble(Console.ReadLine());

double charges = 2 + (hrs - 3)*0.5;
  if (hrs == 24){
  charges = 10;
  
  
}
if (hrs > 24)
{
  charges = 0;
  Console.WriteLine("NO CAR CAN BE PARKED FOR MORE THAN 24 HRS ");
}

 Console.WriteLine("Customer charge is \n $"  + charges);

Console.WriteLine("total of customer charges is ");

  return charges;
  
}


}