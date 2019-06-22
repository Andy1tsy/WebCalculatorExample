using WebCalculatorExample.Models;

namespace WebCalculatorExample.DBManager
{
    public class DbManager : IDbManager
    {
        public void AddData(Expression expression)
        {
            using (var expressionContext = new ExpressionContext())
            {
                 expressionContext.Expressions.Add(expression);
                 expressionContext.SaveChanges();
            }
        }
    }
}