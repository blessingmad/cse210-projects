using System;
class   Program
{
    static void Main(string[] args)



    {   
        
        DateTime theCurrentTime = DateTime.Today;
        string dateText = theCurrentTime.ToLongDateString();
        Console.WriteLine("...............................");
        Console.WriteLine($"{dateText}");
        Console.WriteLine("...............................");
      
       
        Scripture s1 = new Scripture("John 3:16" , "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.");
        Console.WriteLine(s1.GetVerseInfo());

        Reference r1 = new Reference("Provebs" , 3 , 5-6 );
        Console.WriteLine(" Provebs Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.");
        Console.ReadLine();

        Random random = new Random();
        string[] randomWord= new string[]{"For", "God", "so","love", "the","world", "that", "He","gave","His","Only", "Begotten", "Son ", "that","whosoever","believeth", "in","Him", "should","not","perish","but","have","everlasting", "life"};
        Console.Write(randomWord[random.Next()]);

        Console.WriteLine("Press (Enter) to erase other words or (Quiet) to stop");

    
        

        //while (randomWord != hidden)
        //
        //
        //Console.WriteLine("_ _ _ _")
          
    }

}