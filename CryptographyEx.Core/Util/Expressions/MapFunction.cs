using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CryptographyEx.Core.Util.Expressions
{
    public class MapFunction<T>
    {
        private const char Plus = '+';
        private const char Minus = '-';
        private const char Divide = '/';
        private const char Multiply = '*';
        private const string X_Var = "x";

        private Expression<Func<T, T>> _expr;
        
        public MapFunction(string map)
        {
            if (string.IsNullOrEmpty(map))
            {
                _expr = x => x;
                return;
            }

            ValidateString(map);

            var chars = map.Split(' ');
            var operation = chars[1];

            var operands = chars.Where(x => x != operation).ToArray();

            var xTuple = operands.Select((x, i) => Tuple.Create(i, x))
                .First(x => x.Item2 == X_Var);

            var paramExpression = Expression.Variable(typeof(int), X_Var);

            Expression GetOperandExpression(int index)
             => xTuple.Item1 == index ? paramExpression
             : (Expression)Expression.Constant(int.Parse(operands[index]), typeof(int));

            var leftExpression = GetOperandExpression(0);

            var rightExpression = GetOperandExpression(1);

            Expression GetOperationExpression(Expression left, Expression right, char op)
            {
                switch (op)
                {
                    case Plus:
                        return Expression.Add(left, right);
                    case Divide:
                        return Expression.Divide(left, right);
                    case Multiply:
                        return Expression.Multiply(left, right);
                    case Minus:
                        return Expression.Subtract(left, right);
                }

                return null;
            }

            Expression body = GetOperationExpression
                (leftExpression, rightExpression, operation[0]);

            _expr = Expression.Lambda<Func<T, T>>(body, paramExpression);
            
        }

        void ValidateString(string input)
        {
            // TODO: implement string validation with regex for following cases:
            // "x + 1" or "1 + x"
            // "x - 1" or "1 - x"
            // "x * 1" or "1 * x"
            // "x / 1" or "1 / x" 
        }

        public MapFunction(Expression<Func<T, T>> expr)
        {
            _expr = expr;
        }
        
        public static implicit operator string(MapFunction<T> map) => map._expr.ToString();
        public static implicit operator MapFunction<T>(string map) => new MapFunction<T>(map);
        public static implicit operator MapFunction<T>(Expression<Func<T, T>> expr) => new MapFunction<T>(expr);
        public static implicit operator Func<T, T>(MapFunction<T> mapFunc) 
            => mapFunc._expr.Compile();
        public static implicit operator Expression<Func<T, T>>(MapFunction<T> mapFunction) 
            => mapFunction._expr;
    }
}
