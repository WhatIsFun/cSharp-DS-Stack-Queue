using System.Linq.Expressions;

namespace cSharp_DSStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack S = new Stack(5);

            //S.StackAdd(1);
            //S.StackAdd(54);
            //S.StackAdd(7);
            //S.StackAdd(654);
            //S.StackAdd(640);

            //Console.WriteLine("Items are : ");
            //S.Display();
            //S.StackPeek();

            //S.StackRemove();
            //S.StackRemove();
            //S.StackRemove();

            //S.Display();
            //S.StackPeek();



            //Queue Q = new Queue(5);
            //Q.QueueAdd(10);
            //Q.QueueAdd(20);
            //Q.QueueAdd(30);
            //Q.QueueAdd(40);
            //Q.QueueAdd(50);
            //Q.Display();

            //Q.QueueRemove();
            //Q.Display();

            //Q.QueuePeek();
            //Q.QueueRemove();
            //Q.Display();

            // Stack Task:
            //string[] exp = new string[3];
            BalancedBrackets.IsBalanced("[()]{}{[()()]()}");
            BalancedBrackets.IsBalanced("[()]{}{[()()]()}");
            BalancedBrackets.IsBalanced("[(])");
        }

        // Task:
        // Given an expression string exp, write a program to examine whether the pairs and the orders of “{“, “}”, “(“, “)”, “[“, “]” are correct in the given expression.
        // Input: exp = “[()]{}{[()()]()}” 
        // Output: Balanced
        // Explanation: all the brackets are well-formed

        // Input: exp = “[(])” 
        // Output: Not Balanced
        // Explanation: 1 and 4 brackets are not balanced because 
        // there is a closing ‘]’ before the closing ‘(‘
        public class BalancedBrackets
        {
            static bool AreBracketsBalanced(string exp)
            {
                Stack<char> stack = new Stack<char>();
                for (int i = 0; i < exp.Length; i++)
                {
                    char a = exp[i];
                    if (a == '(' || a == '[' || a == '{')
                    {
                        stack.Push(a);
                        continue;
                    }
                    if (stack.Count == 0)
                        return false;
                    char check;
                    switch (a)
                    {
                        case ')':
                            check = stack.Pop();
                            if (check == '{' || check == '[')
                                return false;
                            break;
                        case '}':
                            check = stack.Pop();
                            if (check == '(' || check == '[')
                                return false;
                            break;
                        case ']':
                            check = stack.Pop();
                            if (check == '(' || check == '{')
                                return false;
                            break;
                    }
                }
                return (stack.Count == 0);
            }
            public static void IsBalanced(string input)
            {
                if (AreBracketsBalanced(input))
                {
                    Console.WriteLine($"The '{input}' is balanced ");
                }
                else
                {
                    Console.WriteLine($"The '{input}' is not balanced ");
                }
            }
        }
    }
}