namespace WebCalculatorExample.CalculatorManager
{
    public interface ICalcManager
    {
       void Addition(int firstValue, int secondValue);
       void Dividing(int firstValue, int secondValue);
       void Multiplying(int firstValue, int secondValue);
       void Substraction(int firstValue, int secondValue);
        void SaveData();
    }
}