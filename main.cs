using System;

class MainClass {


 
    
    
  
  
  public static void Main (string[] args) {
    
    
  CalculateCharges(Console.WriteLine(charge));
   
    
       
  }
  public static void CalculateCharges(){
    double charge = 0;
    Console.WriteLine("How many customers parking ?");
    int numParking = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter customer hours");
    Console.WriteLine("Customer hours (1-" + numParking + ") inputs ");
    for(int customers =0; customers<numParking; customers++)
    {
    
      int hours = Convert.ToInt32(Console.ReadLine());
    charge = 2 + (hours-3) * 0.05;
   
    }
    
    
  }
}
  
  