using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Microsoft";
        job1._startYear = 2845;
        job1._endYear = 2848;
        
        //create another job portion
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._jobCompany = "Samsung";
        job2._startYear = 2851;
        job2._endYear = 2855; 


        Resume myResume = new Resume();
        myResume._name = "Blessing Madhuma";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();





    }

}