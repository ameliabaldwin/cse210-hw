using System;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        // starts up the booting process
        Console.WriteLine("--Powering up--");
        int bootingUp  = 0;
        Loading l = new Loading();
        Console.Write("Booting Up...");
        while(bootingUp != 10)
        {
            l.Loadingdots();
            l.Sleep(200);
            bootingUp += 1;
        }
        Console.WriteLine("");
        Console.Write("Okay what's your name:");
        string yourName = Console.ReadLine();


        string[] names = "Eggs Benedict|Angsty Teen|Exotic Butters".Split('|');
        Random rnd = new Random();
        string newNames = names[rnd.Next(0, names.Length - 1)];
        l.Sleep(200);
        Console.WriteLine($"It seems that you had some trouble with the console input. I see what you were trying to type, and I will autocorrect it for you.\nOne moment Welcome, {newNames}");
        l.Sleep(200);
        bool quit = false;
        while(quit != true)
        {
            l.menu(newNames);
            string activity = Console.ReadLine();
            l.Sleep(200);

            Console.WriteLine("They do not pay me enough for this job... ugh minimum wage I hate it.");
            int interval = 1;
            System.Timers.Timer timer = new System.Timers.Timer(interval);
            if (activity == "1")
            {
                string message1 = "Breathe in...";
                string message2 = "Breathe out...";
                
                Console.WriteLine("How Long are you gonna do this for(seconds): ");
                
                int timeLength = int.Parse(Console.ReadLine());
                
                Breathing br = new Breathing(message1, message2, "Breathing Activity", "This activity will help you clear your mind for more stress", timeLength, timeLength);
                Console.WriteLine(br.GetActivityDetails());

                l.countdown();

                int totalDurationInMillis = br.GetDurationInMilSecs(); // total duration is 1 minute (60,000 ms)
                int elapsedTime = 0;

                //starts an event named timer
                timer.Elapsed += (sender, e) =>
                {
                    //adds interval to elapsed time
                    elapsedTime += interval;
                    //checks if the elapsedTime is greater or equal to totalDurationInMillis
                    if (elapsedTime >= totalDurationInMillis)
                    {
                        timer.Stop();
                        Console.WriteLine("Congratulations! You have completed the Breathing Exercise.");
                    }
                };
                //starts the timer object
                timer.Start();

                while (elapsedTime < totalDurationInMillis)
                {
                    Console.WriteLine(br.GetMessage1());
                    l.Loadingdots();
                    l.Sleep(2000); 

                    Console.WriteLine(br.GetMessage2());
                    l.Loadingdots();
                    l.Sleep(2000); 


                }
            }

            if(activity == "2")
            {

                string[] thinkPrompts = "Think of a time when you stood up for someone else.|Think of a time when you did something really difficult.|Think of a time when you helped someone in need.|Think of a time when you did something truly selfless.".Split('|');
                string[] questionPrompts = "Why was this experience meaningful to you?|Have you ever done anything like this before?|How did you get started?|How did you feel when it was complete?|What made this time different than other times when you were not as successful?|What is your favorite thing about this experience?|What could you learn from this experience that applies to other situations?|What did you learn about yourself through this experience?|How can you keep this experience in mind in the future?".Split('|');
                
                Console.WriteLine("How Long are you gonna do this for(seconds): ");
                int timeLength = int.Parse(Console.ReadLine());
                
                Reflection rf = new Reflection(questionPrompts, thinkPrompts, "Reflection Activity", "This activity will help you remember your dark past and happy memories", timeLength, timeLength);
                Console.WriteLine(rf.GetActivityDetails());
                
                l.countdown();

                int totalDurationInMillis = rf.GetDurationInMilSecs();
                int elapsedTime = 0;

                while (elapsedTime < totalDurationInMillis)
                {
                    Console.WriteLine(rf.GetRandomThinkingPrompt(rnd)); // Get random thinking prompt
                    l.Loadingdots();
                    l.Sleep(200);

                    Console.WriteLine(rf.GetRandomQuestion(rnd)); // Get random question
                    Console.ReadLine(); // Wait for user input before proceeding
                    l.Loadingdots();
                    l.Sleep(200);


                }
                //starts an event named timer
                timer.Elapsed += (sender, e) =>
                {
                    //adds interval to elapsed time
                    elapsedTime += interval;
                    //checks if the elapsedTime is greater or equal to totalDurationInMillis
                    if (elapsedTime >= totalDurationInMillis)
                    {
                        timer.Stop();
                        Console.WriteLine("Congratulations! You have completed the Reflection Exercise.");
                    }
                };
                //starts the timer object
                timer.Start();

            }



            if (activity == "3")
            {
                string[] listPrompts = "Who are people that you appreciate?|What are personal strengths of yours?|Who are people that you have helped this week?|When have you felt the Holy Ghost this month?|Who are some of your personal heroes?".Split('|');
                
                Console.WriteLine("How Long are you gonna do this for(seconds): ");
                int timeLength = int.Parse(Console.ReadLine());
                
                Listing li = new Listing(listPrompts, "Listing Activity", "This activity will help you list all your fears and desires for real, no cap", timeLength, timeLength);
                Console.WriteLine(li.GetActivityDetails());
                
                l.countdown();
                
                int totalDurationInMillis = li.GetDurationInMilSecs();
                int elapsedTime = 0;

                Console.WriteLine(li.GetRandomListing(rnd));


                //starts an event named timer
                timer.Elapsed += (sender, e) =>
                {
                    //adds interval to elapsed time
                    elapsedTime += interval;
                    //checks if the elapsedTime is greater or equal to totalDurationInMillis
                    if (elapsedTime >= totalDurationInMillis)
                    {
                        timer.Stop();
                        Console.WriteLine("Congratulations! you have completed the listing Exercise");
                    }
                };
                //starts the timer object
                timer.Start();

                // Keep the console open until the timer stops
                while (elapsedTime < totalDurationInMillis)
                {
                    Console.ReadLine();
                    l.Loadingdots();
                }

            }
            if(activity == "4")
            {
                quit = true;
            }
        }
    }
}