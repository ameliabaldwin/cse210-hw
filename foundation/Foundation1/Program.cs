using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Painting with bob ross", "Bobross", 1271);

        Comment comment1a = new Comment("bobby", "I love the way you paint");
        Comment comment1b = new Comment("Preston", "I miss bob ross, he was such a good artist");
        Comment comment1c = new Comment("Kaden", "Happy Trees");
        Comment comment1d = new Comment("devon", "Bob ross is lame");

        video1.AddComments(comment1a);
        video1.AddComments(comment1b);
        video1.AddComments(comment1c);
        video1.AddComments(comment1d);


        Video video2 = new Video("Charlie bit my finger", "Charlie", 347);

        Comment comment2a = new Comment("caleb", "Hahaha so funny");
        Comment comment2b = new Comment("mark", "No way he actually bit his finger");
        Comment comment2c = new Comment("trent", "why did charlie do that");
        Comment comment2d = new Comment("stark", "Is the kid's finger okay?");

        video2.AddComments(comment2a);
        video2.AddComments(comment2b);
        video2.AddComments(comment2c);
        video2.AddComments(comment2d);


        Video video3 = new Video("Lavish Music video", "Twenty One Pilots", 179);

        Comment comment3a = new Comment("greg", "This song is such a banger");
        Comment comment3b = new Comment("david", "The new MEN IN BLACK");
        Comment comment3c = new Comment("jason", "The Proctologist line is diabolical. Definitely didn't see it coming but I'm absolutely loving it");
        Comment comment3d = new Comment("riley", "Josh playing virtual drums is so sweet");

        video3.AddComments(comment3a);
        video3.AddComments(comment3b);
        video3.AddComments(comment3c);
        video3.AddComments(comment3d);


        Video video4 = new Video("The MineCraft Movie Trailer", "Warner Bros.Pictures", 254);

        Comment comment4a = new Comment("parker", "Funny prank warner bros, you can release the real teaser now");
        Comment comment4b = new Comment("jeff", "i can already feel the “hes right behind me isnt he” and “well at least its not raining”");
        Comment comment4c = new Comment("forest", "How brave of Warner Bros. leaving the comment section open");
        Comment comment4d = new Comment("thatcher", "Please send this back to the crafting table");

        video4.AddComments(comment4a);
        video4.AddComments(comment4b);
        video4.AddComments(comment4c);
        video4.AddComments(comment4d);

        List<Video> videos =  new List<Video> {video1, video2, video3, video4};

        foreach (var video in videos)
        {
            Console.WriteLine("");
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Time: " + video.GetLength() + " Seconds");
            Console.WriteLine("Comments: " + video.GetNumberOfComments());
            foreach(var comment in video.GetComments())
            {
                Console.WriteLine(comment.GetUsername() + ":" + comment.GetText());
            }
            Console.WriteLine("");
        }

        

    }
}