using System;
using Composition2Csharp.Entities;

namespace Composition2Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wounderful country!",
                12
                );
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow That's awesome");

            p1.AddComment(c1);
            p1.AddComment(c2);

        }
    }
}
