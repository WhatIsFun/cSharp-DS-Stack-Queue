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



        }
    }
}