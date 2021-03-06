using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieMania.Models
{
    public class Episode
    {
        public Episode()
        {
            this.Users = new HashSet<User>();
        }

        public int EpisodeId { get; set; }
        public string Title { get; set; }
        public Serie Serie { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public int DurationHours { get; set; }
        public int DurationMin { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}