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
            #region Q3
            //deep coping copies the object and all nested objects, creating fully independent duplicates.
            // value types are copied by value independently, while reference type new objects created (not shared)
            //shallow coping copies the object but copies references for reference-type fields.
            // value types are copied by value independently, while reference types are shared(inner object same)
            // performance: shallow copy is faster than deep copy because it does not create new objects for reference-type fields.
            //memory usage: shallow copy uses less memory than deep copy because it does not create new objects for reference-type fields.
            //shallow copy use when object is immutable, no nested reference state, performance is critical,
            //while deep copy is used when objects must be isolated, modifications should not affect original.
            //Changing a referenced object in one copy will affect the other copy in shallow copy.
            #endregion
        }
    }
}
