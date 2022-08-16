namespace CallbackClasswork
{
    class CallBackExample
    {
        public delegate void MyNumber();
        public static void CallMeBack()
        {
            Console.WriteLine("She is calling you.  Pick your phone!:)");
            Console.Read();
        }
        public static void MetYourCrush(MyNumber number)
        {
            int j;
            Console.WriteLine("is she interested? 1 for yes and 0 for no:");
            var i = Console.ReadLine();
            if (int.TryParse(i, out j))
            {
                var interested = (j == 0) ? false : true;
                if (interested)//event
                {
                    //call his/her number
                    number();
                }
                else
                {
                    Console.WriteLine("Nothing happened! :(");
                    Console.Read();
                }
            }
        }
        static void Main(string[] args)
        {
            MyNumber number = CallMeBack;
            Console.WriteLine("You have just met your crush and given your number");
            MetYourCrush(number);
            Console.Read();
            Console.Read();
        }
    }
}