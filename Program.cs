Console.WriteLine("Sodda kalkulatorga xush kelibsiz!");
Console.WriteLine("1. +, -, *, /, ^ amallari yordamida ish bajarish");
Console.WriteLine("2. Sonning logarifmini topish");

string input = Console.ReadLine();
switch(input)
{
    case "1" :
        {
            Console.Write("Ifodani kiriting : ");
            string ifoda = Console.ReadLine();
            string amal = "";
            if(ifoda.Contains("+"))
            {
                amal = "+";
            }
            else if(ifoda.Contains("-"))
            {
                amal = "-";
            }
            else if(ifoda.Contains("*"))
            {
                amal = "*";
            }
            else if(ifoda.Contains("/"))
            {
                amal = "/";
            }
            else if(ifoda.Contains("^"))
            {
                amal = "^";
            }
            string strNum1 = ifoda.Substring(0, ifoda.IndexOf(amal));
            string strNum2 = ifoda.Substring(ifoda.IndexOf(amal) + 1);
            double firstNumber = Convert.ToDouble(strNum1);
            double secondNumber = Convert.ToDouble(strNum2);
            double natija = amal switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "^" => Math.Pow(firstNumber, secondNumber),
            }; 
            Console.WriteLine($"{ifoda} = {natija}");
        }
        break;
}