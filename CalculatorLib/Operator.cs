using System.Collections;

namespace CalculatorLib;

public class Operator
{
    public Hashtable operatorTable = new Hashtable();
    Calculator calc = new Calculator();

    //Constructor
    public Operator() => InitOperaters();

    public struct BinOperator(char _symbol, int _pOrder)
    {
        public char symbol = _symbol;
        public int adrs;
        public int pOrder = _pOrder;
    }
    
    public void Operation(List<string> units, char symb)
    {
        if(symb == '/')
            calc.Divide(units);
        else if(symb == '*')
            calc.Multiply(units);
        else if(symb == '+')
            calc.Addition(units);
        else if(symb == '-')
            calc.Subtraction(units);
    }

    private void InitOperaters()
    {
        operatorTable = new Hashtable()
        {
            {'/', new BinOperator('/', _pOrder: 1)},
            {'*', new BinOperator('*', _pOrder: 2)},
            {'+', new BinOperator('+', _pOrder: 3)},
            {'-', new BinOperator('-', _pOrder: 4)}
        };
    }
}
