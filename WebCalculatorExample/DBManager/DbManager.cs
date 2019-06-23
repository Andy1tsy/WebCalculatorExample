using WebCalculatorExample.Models;
using System;

namespace WebCalculatorExample.DBManager
{
    public class DbManager : IDbManager
    {
        public void AddData(Expression expression)
        {
            using (var expressionContext = new ExpressionContext())
            {
                try
                {
                 expressionContext.Expressions.Add(expression);
                 expressionContext.SaveChanges();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}