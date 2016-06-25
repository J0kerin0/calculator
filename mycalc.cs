using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Timers;
using System.Text;
using System.Diagnostics;

namespace supercalc
{
 
public class calculadora
{

public static double num1;
public static double num2;
public static string Operator;
public static double result;



public static void  Main (string [] args)
{

Console.WriteLine("For decimals use full stop sign (.).");
Console.WriteLine("Calculator press 1.\nQuadratic formula press 2.");

switch(Console.ReadLine())
{
	case"1":
	calcular();
	break;
	case"2":
	formResolvente();
	break;
	case"exit": case"sair": case"out":
	Environment.Exit(0);
	break;
	default:
	restart();
	break;
}

}//END MAIN


public static void formResolvente(){
	
	Console.WriteLine("Give values to a, b, and c\ny=a(x^2)+bx+c");
	double a = Convert.ToDouble(Console.ReadLine());
	double b = Convert.ToDouble(Console.ReadLine());
	double c = Convert.ToDouble(Console.ReadLine());
   	if ((Math.Pow(b*b-4*a*c,0.5))>=0)
	{
	double result1 = (-b+(Math.Pow(b*b-4*a*c,0.5)))/(2*a);
	double result2 = (-b-(Math.Pow(b*b-4*a*c,0.5)))/(2*a);

	Console.Write("\n\n");
	Console.Write(result1 + ", " + result2+ "\n");
}
	else{
	Console.WriteLine("No real solution");
	}
	await();

}




public static void calcular()
{
Console.WriteLine("For decimals use full stop symbol (.). Use \"root\" for roots and put the root degree in the second value.\n ");
System.Threading.Thread.Sleep(500);
Console.WriteLine("\nInsert first value.");

num1 = Convert.ToDouble(Console.ReadLine());
System.Threading.Thread.Sleep(100);
Console.WriteLine("Insert second value");
num2 = Convert.ToDouble(Console.ReadLine());
System.Threading.Thread.Sleep(100);
Console.WriteLine("Insert operation.");
Operator = Console.ReadLine();
System.Threading.Thread.Sleep(100);

switch(Operator)
{
case "+":
result = num1 + num2;
printResult();
break;
case "-" :
result = num1 - num2;
printResult();
break;
case "*":
result = num1 * num2;
printResult();
break;
case "/":
result = num1 / num2;
printResult();
break;
case "^":
result = Math.Pow(num1, num2);
printResult();
break;
case "root":
result = Math.Pow(num1, (1/num2));
Console.WriteLine("Root degree " + num2 + " of " + num1 + " is " + result);
break;
default:
Console.WriteLine("Insert valid operators.");
break;
}//END SWITCH DA CALCULADORA

await();
		
}//END CALCULADORA



public static void printResult(){	
	
	Console.WriteLine(calculadora.num1 + calculadora.Operator +calculadora.num2 + " is " + calculadora.result);	
}


public static void restart(){

	Application.Restart();
	
}

public static void await()
{
	Console.WriteLine("Press R to restart app or E to exit.");
	switch(Console.ReadLine())
	{
		case"r":
		restart();
		break;
		case"e":
		Environment.Exit(0);
		break;
		default:
		break;
		
	}
}


}//END CLASS




}//END NAMESPACE