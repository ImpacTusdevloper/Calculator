namespace CalculatorLib;

public class Calculator
{
    #region Operations
    public float Divide(List<string> units)
    {
        return LoopOverUnits(units, Divide);
    }

    public float Divide(float unit0, float unit1) {return unit0/unit1;}

    public float Multiply(List<string> units)
    {
        return LoopOverUnits(units, Divide);
    }

    public float Multiply(float unit0, float unit1) {return unit0*unit1;}

    public float Addition(List<string> units)
    {
        return LoopOverUnits(units, Divide);
    }

    public float Addition(float unit0, float unit1) {return unit0+unit1;}

    public float Subtraction(List<string> units)
    {
        return LoopOverUnits(units, Divide);
    }

    public float Subtraction(float unit0, float unit1) {return unit0-unit1;}
    #endregion

    //Helper and private func
    private float LoopOverUnits(List<string> units, Func<float, float, float> func)
    {
        float temp = StrToFlt(units[0]);
        for (int i = 1; i < units.Count(); i++)
            temp = func(temp, StrToFlt(units[i]));

        return temp;
    }
    private float StrToFlt(string arg) {return float.Parse(arg);}
}
