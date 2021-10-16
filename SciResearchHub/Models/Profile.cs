using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SciResearchHub.Models
{
    public class Profile
    {
       /* public Profile(string id, string Name, string Domain, string Ranking, string Imglink, string Link, string DateCreated  string ResearchPaper)
        {
            this.Id = id;
            this.Name = Name;
            this.Domain = Domain;
            this.Ranking = Ranking;
            this.Imglink = imglink;
            this.Link = Link;
            this.DateCreated = DateCreated;
            ResearchPapers.add(ResearchPaper)

        }*/
        public string Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public string Ranking { get; set; }
        public string Imglink { get; set; }
        public string Link { get; set; }
        public string DateCreated { get; set; }
    }
}
