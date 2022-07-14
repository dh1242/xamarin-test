using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp1.Models
{
    public static class DummyProfessionalData
    {
        static Task task;
        
        // Get data 
        // Data can be fetch from any service for from DB
        // will be written in this function
        public async static Task<List<Professional>> GetProfessionals()
        {
            var data = new List<Professional>();
            task = Task.Run(async () =>
            {
                Random rd = new Random();
                for (int i = 0; i < 35; i++)
                {
                    int rand_num = rd.Next(1, 60);
                    data.Add(new Professional()
                    {
                        Id = (i + 1).ToString(),
                        Name = mylist[i],
                        Desigination = mylist[i],
                        Domain = mylist[i],
                        Experience = rand_num.ToString()
                    });
                }
            });
            await task;
            return data;
        }

        // Dummy list of data
        static List<string> mylist = new List<string>(new string[] {
                    "Accountant",
            "Actor",
            "Administrator",
            "Anthropologist",
            "Architect",
            "Astronomer",
            "Auditor",
            "Banking Analyst",
            "Bartender",
            "Biologist",
            "Blacksmiths",
            "Broker",
            "Buyer",
            "Carpenter",
            "Chef",
            "Chemist",
            "Childcare Worker",
            "Civil Engineer",
            "Clergy",
            "Cook",
            "Cosmetologist",
            "Craftsperson",
            "Data Analyst",
            "Data Scientist",
            "Dental Assistant",
            "Ecommerce Seller",
            "Electrical Engineer",
            "Engineer",
            "Epidemiologist",
            "Event Planner",
            "Farmer",
            "Financial Analyst",
            "Financial Manager",
            "Fishery Worker",
            "Flight Attendant",
            "Forestry Worker",
            "Game Designer",
            "General Manager",
            "Government Worker",
            "Health Educator",
            "Hotel Manager",
            "Information Design",
            "Interpreter",
            "Lawyer",
            "Librarian",
            "Manicurists",
            "Mathematician",
            "Miner",
            "Nanny",
            "Nurse",
            "Optometrist",
            "Photographer",
            "Physicist",
            "Plumber",
            "Politician",
            "Product Design",
            "Professor",
            "Project Manager",
            "Property Manager",
            "Purchasing Manager",
            "Reporter",
            "Restaurant Manager",
            "Robotics Engineer",
            "Sales Manager",
            "Scientist",
            "Service Manager",
            "Sociologist",
            "Software Developer",
            "Space Scientist",
            "Steel Worker",
            "Supervisor",
            "Surveyor",
            "Systems Analyst",
            "Teacher",
            "Technical Writer",
            "Tour Guide",
            "Tutor",
            "Veterinarian",
            "Waiter",
       });
    }
}
