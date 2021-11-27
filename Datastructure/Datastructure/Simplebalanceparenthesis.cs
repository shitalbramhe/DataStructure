using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Simplebalanceparenthesis
    {
        public bool balanceparenthesis()
        {
            string exp = "{ ( 5 + 6 ) * ( 7 + 8 ) } / { ( 4 + 3 ) ( 5 + 6 ) } * { ( 7 + 8 ) / ( 4 + 3 ) }]";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                {
                    stack.Push(exp[i]);
                }
                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else if ('(' == stack.Peek() && ')'== exp[i])
                    {
                        stack.Pop();
                    }
                    else if ('[' == stack.Peek() && ']' == exp[i])
                    {
                        stack.Pop();
                    }
                    else if ('{' == stack.Peek() && '}' == exp[i])
                    {
                        stack.Pop();
                    }
                }
            }
            return true;
        }
    }
}

