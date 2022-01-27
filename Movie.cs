using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Movie
    {
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual void Watch()
        {
            Console.WriteLine("You just watched: " + this.Title);
        }
    }

    class RomCom : Movie
    {
        public bool IsHappyEnding { get; set; }

    }

    class Action : Movie
    {
        public string SideKick { get; set; }
    }

    class Anime : Movie
    {
        public string AnimationStyle { get; set; }
    }
}
