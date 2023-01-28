using System;

class Program
{
    static void Main(string[] args)

    
    { 
        Entry entries1 = new Entry();
        entries1._userPrompt = "Who is the most intresting person you ment today";
        entries1._endProgram = 0;
        
        Entry entries2 = new Entry();
        entries2._userPrompt = "Where did you see the Lords hand in your life?";
        entries2._endProgram = 0;

        Entry entries3 = new Entry();
        entries3._userPrompt = "What is something you wish to do differently next time?";
        entries3._endProgram = 0;

        Entry entries4 = new Entry();
        entries4._userPrompt = "What was the highlight of your day?";
        entries4._endProgram = 0;

        Entry entries5 = new Entry();
        entries5._userPrompt = "Why still keeping the journal?";
        entries5._endProgram = 0;
        




        Journal myJournal = new Journal();
        myJournal._entries.Add(entries1);
        myJournal._entries.Add(entries2);
        myJournal._entries.Add(entries3);
        myJournal._entries.Add(entries4);
        myJournal._entries.Add(entries5);

        myJournal.Display();

    }

}
