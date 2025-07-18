using System;
class Calculator
{
    
    private float _LastNumber = 0;
    private float _Result = 0;
    private float _previousresult = 0;
    private string _lastoperation = "Clear";

    private bool IsZero(float Number)
    {
        return (Number == 0);
         
    }

    public void Add(float Number)
    {
        _LastNumber = Number;
        _previousresult = _Result;
        _lastoperation = "Adding";

        _Result += Number;
    }

    public void Subtract(float Number)
    {
        _LastNumber = Number;
        _previousresult = _Result;
        _lastoperation = "Subtracting";

        _Result -= Number;  
    }

    public void Multiply(float Number)
    {
        _LastNumber = Number;
        _previousresult = _Result;
        _lastoperation = "Multiling";

        _Result *= Number;  
    }

    public bool Divide(float Number)
    {
        bool succeeded = true;
        _lastoperation = "Dividing";

        if (IsZero(Number))
        {
            _LastNumber = Number;
            _previousresult = _Result;
            _Result /= 1;
            succeeded = false;
        }
        else
        {
            _LastNumber = Number;
            _previousresult = _Result;
            _Result /= Number;
        }
        return succeeded;


    }

    public void Modulo(float Number)
    {
        _LastNumber = Number;
        _previousresult = _Result;
        _lastoperation = "Moduling";
        _Result %= Number;
    }

    public void CancelLastOPeration()
    {
        _LastNumber = 0;
        _Result = _previousresult;

        _lastoperation = "Cancel Last Operation";
    }

    public float GetFinalResult()
    {
        return _Result;
    }

    public void Clear()
    {
        _LastNumber = 0;
        _lastoperation = "Clear";
        _Result = 0;
    }

    public void PrintResult()
    {
        Console.WriteLine("Result After {0} {1} is : {2}", _lastoperation, _LastNumber, _Result);
    }

    
}
    

