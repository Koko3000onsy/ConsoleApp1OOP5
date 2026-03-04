namespace ConsoleApp1OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1.1 :interface is a contract that defines a set of methods and properties that a class must implement.
            //It specifies what a class can do, not how it does it.
            //It cannot contain any implementation code. Interface = Promise, not implementation
            //Q1.2 : We use interfaces instead of depending on concrete classes to make our code more flexible, maintainable, and scalable.
            //Q1.3 : Enable polymorphism without inheritance , Remove tight coupling between classes , Enable multiple inheritance(behavior)
            //Interfaces allow coding against behavior, not classes
            #endregion
            #region Q2
            //The problem is that both interfaces contain a method with the same name and signature
            //Explicit implementation
            //    interface IEnglishSpeaker
            //{
            //    void Greet();
            //}

            //interface IArabicSpeaker
            //{
            //    void Greet();
            //}

            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //     void IEnglishSpeaker. Greet()
            //    {
            //        Console.WriteLine("Hello ");
            //    }
            //    void IArabicSpeaker.Greet()
            //    {
            //        Console.WriteLine(" Ahlan");
            //    }
            //}
            //we cant call translator.Greet() because it void IArabicSpeaker.Greet() and void IEnglishSpeaker. Greet() are not puplic can access them in interface only
            //translator t = new Translator();
            //IArabicSpeaker arabicSpeaker = t;
            //IEnglishSpeaker englishSpeaker = t;
            //arabicSpeaker.Greet(); // Output: Ahlan
            //englishSpeaker.Greet(); // Output: Hello
            #endregion
        }
    }
}
