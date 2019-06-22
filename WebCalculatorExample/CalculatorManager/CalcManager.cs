using WebCalculatorExample.DBManager;


namespace WebCalculatorExample.CalculatorManager
{
    using Models;
    public  class CalcManager : ICalcManager
    {
        private readonly IDbManager _dbManager;
        public Expression Expression { get; set; }

        public CalcManager(IDbManager dbManager)
        {
            this._dbManager = dbManager;
            this.Expression = new Expression();
        }
        public  void Addition(int firstValue, int secondValue)
        {
                Expression.FirstValue = firstValue;
                Expression.SecondValue = secondValue;
                Expression.Operation = Operation.Add;
                Expression.ResultValue = firstValue + secondValue;

            SaveData();
        }

        public  void Substraction(int firstValue, int secondValue)
        {
            Expression.FirstValue = firstValue;
            Expression.SecondValue = secondValue;
            Expression.Operation = Operation.Substract;
            Expression.ResultValue = firstValue - secondValue;

            SaveData();
        }

        public  void Multiplying(int firstValue, int secondValue)
        {
            Expression.FirstValue = firstValue;
            Expression.SecondValue = secondValue;
            Expression.Operation = Operation.Multiply;
            Expression.ResultValue = firstValue * secondValue;

            SaveData();
        }

        public  void Dividing(int firstValue, int secondValue)
        {
            Expression.FirstValue = firstValue;
            Expression.SecondValue = secondValue;
            Expression.Operation = Operation.Divide;
            Expression.ResultValue = (secondValue != 0) ? firstValue / secondValue : (int?)null;

            SaveData();
        }

        public void SaveData()
        {
            _dbManager.AddData(Expression);
        }
    }
}