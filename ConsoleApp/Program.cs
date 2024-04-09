using System.Collections;
using SupportLib;
using CalculatorLib;

void Main()
{
    //Getting Input
    Support.Separator();
    string inp = Support.Input("Enter equation: ");

    //Variables
    Calculator calc = new Calculator();
    Operator oprat = new Operator();
    List<string> units = Simplify(oprat.operatorTable, inp);

    for (int i = 0; i < units.Count; i++)
    {
        if(oprat.operatorTable.ContainsKey(units[i]))
        {
            
        }
    }
    Console.WriteLine(calc.Divide(units));
}

List<string> Simplify(Hashtable table, string inp)
{
    //Creating units(simplify)
    List<string> units = new List<string>();
    string temp = "";
    foreach (char c in inp)
    {
        if(char.IsDigit(c))
        {
            temp += c;
        }
        else if(table.ContainsKey(c))
        {
            if(temp != "")
            {
                //Pack a unit
                units.Add(temp);
                temp = "";
            }

            temp += c;
            units.Add(temp);
            temp = "";
        }
    }
    if(temp != null)
    {
        units.Add(temp);
        temp = "";
    }
    return units;
}


//Main method call
Main();