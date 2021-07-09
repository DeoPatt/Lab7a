using System;

class MainClass {
  
  
  
  public static void Main (string[] args) {
    
    
    
    
    
   Console.WriteLine("How many customers parked in garage ?");
   var total = 0;
   int customerCount = 0;
  int numOfPeople = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Is there any more people ? yes or no");
   var answer = Console.ReadLine();
   
     if(answer == "yes")
  {
    Console.WriteLine("How many more people ? ");
    int numOfPeople2 = Convert.ToInt32(Console.ReadLine());
    total = numOfPeople2 + numOfPeople;
  }
   CalculateCharges();
    
  }
  public static double CalculateCharges()
  {
    double charges = 0;
    Console.WriteLine("Enter hrs of each customer");
    double hours = Convert.ToDouble(Console.ReadLine());
    charges = 2 + (hours - 3)*0.05;
    return charges;
    
  }

   
  
 }