using System.Security.Cryptography;

Console.WriteLine("== Part 1 Trip Questions ==");
Console.WriteLine("What was the round trip in miles?");
int milesForTheTrip = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the miles per gallon of the car you are using?");
int carMilesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What was the gas price?");
double gasPrice = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("How many pizzas?");
int pizzas = Convert.ToInt32(Console.ReadLine());
const int slices = 8;
Console.WriteLine("How much does a pizza cost?");
double pizzaCost = Convert.ToDouble(Console.ReadLine());


//do the math
//double gallonsNeeded = milesForTheTrip / (double)carMilesPerGallon;
//double fuelCost = gallonsNeeded * gasPrice;

static double fuelCost(double milesForTheTrip, double carMilesPerGallon, double gasPrice)
{
    double gallonsNeeded = milesForTheTrip / carMilesPerGallon;
    
    return gallonsNeeded * gasPrice;
}



double totalslices = pizzas * slices;

double pizzaCosttotal= pizzas * pizzaCost;

double triptot = fuelCost + pizzaCosttotal;

//Do Output
System.Console.WriteLine("Fuel cost: "+ fuelCost.ToString("C2"));
System.Console.WriteLine("Pizza cost: " + pizzaCosttotal.ToString("c2"));
System.Console.WriteLine("Trip total: " + triptot.ToString("c2"));


//Next Part
//Console.WriteLine("Food Cost");
//double sliceperpers = totalslices /;
//print screen
//System.Console.WriteLine("Total slices: " + totalslices.ToString("F2"));

//System.Console.WriteLine("Slices per person: " + sliceperpers.ToString("F2"));

//System.Console.WriteLine("Pizza Cost: " +pizzaCosttotal.ToString("C2"));



//Cost control
//Console.WriteLine("Paycheck");

//const double taxes = 0.18;
//Math Pt 3
//double grosspay = ;

//double withheld = grosspay * taxes;

//double takehome = grosspay - withheld;
//Printscreen
//System.Console.WriteLine("Gross pay: " +grosspay.ToString("C2"));
//System.Console.WriteLine("Tax withheld : " +withheld.ToString("C2"));
//System.Console.WriteLine("Take home pay: " +takehome.ToString("C2"));
// Whole Trip
//double triptot = fuelCost + pizzaCosttotal;
//double costperpers = triptot + ;
//double takehomephr = takehome / ;
//double hltw = costperpers / takehomephr;
//Print last section
//Console.WriteLine("Totals");
//System.Console.WriteLine("Trip total: " + triptot.ToString("C2"));

//System.Console.WriteLine("Cost Per Person: " + costperpers.ToString("C2"));

//System.Console.WriteLine("Take Home Pay Per Hour: " + takehomephr.ToString("C2"));

//System.Console.WriteLine("Hours to work to cover your share: " + hltw.ToString("f2"));