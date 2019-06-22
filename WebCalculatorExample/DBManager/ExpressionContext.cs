using System.Data.Entity;
using WebCalculatorExample.Models;

namespace WebCalculatorExample.DBManager
{
    public class ExpressionContext : DbContext
    {
        public ExpressionContext() : base("DbConnection") { }
        public DbSet<Expression> Expressions { get; set; }
}
}