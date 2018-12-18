using System;
using System.Collections.Generic;
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

        private Expression<Func<T, T>> _expr;
        
        public MapFunction(string map)
        {
            if (string.IsNullOrEmpty(map))
            {
                _expr = x => x;
                return;
            }
            //var operations = new[] { Plus, Minus, Divide, Multiply };

            //Expression operationExpr = null;
            //char delimiter = ' ';

            //foreach (var operation in operations)
            //{
            //    if (map.Contains(operation.ToString()))
            //    {
            //        delimiter = operation;
            //        switch (operation)
            //        {
            //            case Plus:
            //                break;
            //            case Minus:
            //                break;
            //            case Divide:
            //                break;
            //            case Multiply:
            //                break;
            //        }

            //        break;
            //    }
            //}

            //var parts = map.Replace(" ", string.Empty).Split(delimiter);

            //Expression param = Expression.Parameter(typeof(int), "x");
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
