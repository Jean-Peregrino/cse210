using System;

class Program
{
    static void Main(string[] args)
    {
         // Creating the videos and comments
        List <Video> videos = new List<Video>();

        Video video1 = new Video("Tutorial For Beginners & Basics - 1. Installing Visual Studio 2022 & Quick Tips", "Teddy Smith", 1584);
        Comment comment1 = new Comment("brianreichhoff", "You are the man, bro. Nice. Climbing to the top of the C sharp mountain crushing it.");
        Comment comment2 = new Comment("BorisBadenough", "Thank you, great tutorial!");
        Comment comment3 = new Comment("Jean Peregrino", "It is a great tutorial video, thank you very much, I have learned a lot from it.");

        videos.Add(video1);
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Building Your First Arc Reactor", "Iron Man", 1200);
        Comment comment4 = new Comment("Pepper Potts", "Tony, you really shouldn't be encouraging people to build potentially dangerous technology.");
        Comment comment5 = new Comment("Peter Parker", "This is so cool! Do you think I could integrate this into my Spidey suit?");
        Comment comment6 = new Comment("Bruce Banner", "Tony, this is impressive, but have you considered the potential gamma radiation effects?");
        videos.Add(video2);
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Mastering the Lightsaber", "Yoda", 1800);
        Comment comment7 = new Comment("Luke Skywalker", "Remember, the Force will be with you, always.");
        Comment comment8 = new Comment("Chewbacca", "Raaaaaawwwr! (Translation: This video is great!)");
        Comment comment9 = new Comment("R2-D2", "Beep boop beep! (Translation: Excited to give this a try!)");

        videos.Add(video3);
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        Video video4 = new Video("Mastering the Kamehameha", "Goku", 2000);
        Comment comment10 = new Comment("Vegeta", "Kakarot, your technique is impressive, but it's nothing compared to my Galick Gun!");
        Comment comment11 = new Comment("Frieza", "Monkey, you think this makes you powerful? You haven't seen anything yet!");
        Comment comment12 = new Comment("Trunks", "Hey Goten, let's watch this together and practice after school!");

        videos.Add(video4);
        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);

        // Displaying videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
        
}