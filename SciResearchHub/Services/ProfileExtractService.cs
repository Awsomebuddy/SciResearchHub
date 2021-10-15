using Microsoft.AspNetCore.Hosting;
using MySqlConnector;
using SciResearchHub.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace SciResearchHub.Services
{
    public class ProfileExtractService

    {
        public ProfileExtractService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public List<Profile> Profiles { get; private set; }
        public IWebHostEnvironment WebHostEnvironment { get; }
        

        public List<Profile> GetProfiles()
        {
                
                using var connection = new MySqlConnection("server=localhost;user=admin;password=password;database=sciresearchubdata");
                try
                {
                    connection.Open();
                    using var command = new MySqlCommand("SELECT * FROM Profiles;", connection);
                    using var reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    List<Profile> Profiles = new List<Profile>();
                    while (reader.Read())
                    {
                        Profile profile = new Profile();
                        profile.Id = reader["Id"].ToString();
                        profile.Name = reader["Name"].ToString();
                        profile.Domain = reader["Domain"].ToString();
                        profile.Ranking = reader["Ranking"].ToString();
                        profile.Imglink = reader["Imglink"].ToString();
                        profile.Link = reader["Link"].ToString();
                        profile.DateCreated = reader["DateCreated"].ToString();
                        profile.ResearchPapers.add(reader["ResearchPapers"].ToString());
                        Profiles.Add(profile);
                    }
                    return Profiles;
                }
                finally
                {
                    connection.Close();
                }
            
        }
    }
}

