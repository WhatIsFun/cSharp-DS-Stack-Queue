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



            Queue Q = new Queue(5);
            Q.QueueAdd(10);
            Q.QueueAdd(20);
            Q.QueueAdd(30);
            Q.QueueAdd(40);
            Q.QueueAdd(50);
            Q.Display();

            Q.QueueRemove();
            Q.Display();

            Q.QueuePeek();
            Q.QueueRemove();
            Q.Display();

            char[] exp = { '{', '(', ')', '}', '[', ']', '{', '}' };

            //if (AreBracketsBalanced(exp))
            //{
            //    Console.WriteLine("Balanced ");
            //}
            //else
            //{
            //    Console.WriteLine("Not Balanced ");
            //}
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
            public int top = -1;
            public char[] items = new char[100];
            public void ItemPush(char e)
            {
                if (IsFull())
                {
                    Console.WriteLine("Stack is Full");
                    return;
                }
                else
                {
                    items[++top] = e;
                }
            }
            public int ItemPop()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                else
                {
                    char element = items[top];
                    Console.WriteLine("Poped element is: " + items[top]);
                    top--;
                    return element;
                }
            }
            public static Boolean isMatchingPair(char character1, char character2)
            {
                if (character1 == '(' && character2 == ')') { return true; }
                else if (character1 == '{' && character2 == '}') { return true; }
                else if (character1 == '[' && character2 == ']') { return true; }
                else
                {
                    return false;
                }
            }
            public static Boolean AreBracketsBalanced(char[] exp)
            {
                Stack<char> st = new Stack<char>(); // stack

                //  To check matching brackets
                for (int i = 0; i < exp.Length; i++)
                {
                    // If the i is a starting bracket then push it
                    if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
                        st.Push(exp[i]);

                    //  If i is an closing bracket then pop from stack and check if the popped bracket is
                    //  a matching pair
                    if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
                    {

                        // If ending bracket without a pair then return false
                        if (st.Count == 0)
                        {
                            return false;
                        }

                        else if (!isMatchingPair(st.Pop(), exp[i]))
                        {
                            return false;
                        }
                    }
                }

                if (st.Count == 0)
                    return true; // balanced
                else
                {
                    // not balanced
                    return false;
                }
            }

            private bool IsFull()
            {
                return top == 99;
            }

            private bool IsEmpty()
            {
                return top == -1;
            }
        }
    }
}