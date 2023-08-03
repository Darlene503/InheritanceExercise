using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            var hummingbird = new Birds();
            hummingbird.FeatherColor = "Orange";
            hummingbird.CanFly = true;
            hummingbird.CanSing = true;
            hummingbird.WingSpanLength = 3.75;


            Console.WriteLine($"hummingbird Feather Color: {hummingbird.FeatherColor}\nCanFly: {hummingbird.CanFly}\nCanSing: {hummingbird.CanSing}\nWing Span Length: {hummingbird.WingSpanLength}");

            Console.WriteLine("........................");

            var chameleon = new Reptiles();
            
            chameleon.HasScales = true;
            chameleon.IsColdBlooded = true; 
            chameleon.LifeSpan = 7;
            chameleon.Habitat = "the desert";


            Console.WriteLine($"chameleon Has Scales: {chameleon.HasScales}\nIs Cold Blooded: {chameleon.IsColdBlooded}\nLife Span: {chameleon.LifeSpan}\nHabitat: {chameleon.Habitat}"); 







        }


    }

}







    

