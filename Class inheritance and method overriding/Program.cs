using System;

namespace Class_inheritance_and_method_overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first text: ");
            string firstText = Console.ReadLine();

            Console.Write("Enter the seccond text: ");
            string secondText = Console.ReadLine();

            FirstTextAd firstTextAd = new FirstTextAd(firstText);
            Console.WriteLine(firstTextAd.ToString());

            SecondTextAd secondTextAd = new SecondTextAd(firstText, secondText);
            Console.WriteLine(secondTextAd);

            Console.ReadKey();
        }
    }

     class FirstTextAd
    {
        protected string firstText;

        public override string ToString()
        {
            string txt = "The Value of the class field (fields) and the name of the base class: ";
            txt += firstText+", FirstTextAd";
            return txt;
        }

        public FirstTextAd(string firstText)
        {
            this.firstText = firstText;
        }
    }

     class SecondTextAd : FirstTextAd
    {
        protected string secondText;

        public override string ToString()
        {
            string text = "Field value of class SecondTextAd: ";
            text += secondText;
            return text;
        }
        public SecondTextAd(string firstText, string secondText) : base(firstText)
        {
            this.secondText = secondText;
        }

        public SecondTextAd(string firstText) : base(firstText)
        {
            secondText = "Hello";
        }

    }
}
