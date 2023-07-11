namespace cSharp_DSStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack(5);

            S.StackAdd(1);
            S.StackAdd(54);
            S.StackAdd(7);
            S.StackAdd(654);
            S.StackAdd(640);

            Console.WriteLine("Items are : ");
            S.Display();
            S.StackPeek();

            S.StackRemove();
            S.StackRemove();
            S.StackRemove();

            S.Display();
            S.StackPeek();
        }
    }
}