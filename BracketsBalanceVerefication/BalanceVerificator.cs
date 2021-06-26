using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketsBalanceVerefication
{
    class IllegalArgumentExeption : ArgumentException
    {
        public IllegalArgumentExeption(string message)
            : base(message)
        {

        }
    }

    class BalanceVerificator
    {
        static void Main(string[] args)
        {
            string brackets = Convert.ToString(Console.ReadLine());
            char[] array = brackets.ToCharArray();
            
            try
            {
                СheckBrackets(array);
            }
            catch (IllegalArgumentExeption)
            {
                Console.WriteLine("Invalid input data");
            }

            Console.ReadLine();
        }

        static void СheckBrackets(char[] array)
        {
            Stack<char> st = new Stack<char>();


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '(' || array[i] == '{' || array[i] == '[' || array[i] == ')' || array[i] == '}' || array[i] == ']')
                {
                    if (array[i] == '(' || array[i] == '{' || array[i] == '[')
                    {
                        st.Push(array[i]);
                    }

                    else if (array[i] == ')')
                    {
                        if (st.Peek() == '(')
                        {
                            st.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }

                    else if (array[i] == '}')
                    {
                        if (st.Peek() == '{')
                        {
                            st.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }

                    else if (array[i] == ']')
                    {
                        if (st.Peek() == '[')
                        {
                            st.Pop();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    throw new IllegalArgumentExeption("ex");
                }
            }


            if (st.Count == 0)
            {
                Console.WriteLine("Balanced " + -1);
            }
            else
            {
                Console.WriteLine("Not balanced " + st.Count);
            }
        }
    }
}


