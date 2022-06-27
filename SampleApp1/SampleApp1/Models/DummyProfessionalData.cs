using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp1.Models
{
    public static class DummyProfessionalData
    {
        public static List<Professional> GetProfessionals()
        {
            var data = new List<Professional>();
            Random rd = new Random();
            for (int i = 0; i < 15; i++)
            {
                int rand_num = rd.Next(1, 60);
                data.Add(new Professional()
                {
                    Id = (i+1).ToString(),
                    Name = mylist[i],
                    Desigination = mylist[i],
                    Domain = mylist[i],
                    Experience = rand_num.ToString()
                });

            }
            return data;
        }

        static List<string> mylist = new List<string>(new string[] {
                    "Accountant",
            "Actor",
            "Administrator",
            "Aerospace Engineer",
            "Agricultural Engineer",
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
            "Computer Scientist",
            "Conservation Worker",
            "Construction Worker",
            "Cook",
            "Cosmetologist",
            "Craftsperson",
            "Customer Experience Design",
            "Data Analyst",
            "Data Scientist",
            "Dental Assistant",
            "Development Manager",
            "Ecommerce Seller",
            "Electrical Engineer",
            "Emergency Medical Technician",
            "Engineer",
            "Environmental Engineer",
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
            "Import/Export Specialist",
            "Information Design",
            "Information Technology Manager",
            "Interpreter",
            "Laboratory Technician",
            "Landscape Architect",
            "Lawyer",
            "Librarian",
            "Logistics Engineer",
            "Manicurists",
            "Manufacturing Worker",
            "Mathematician",
            "Medical Administration",
            "Medical Technician",
            "Mental Health Counselor",
            "Miner",
            "Nanny",
            "Nurse",
            "Occupational Therapist",
            "Operations Analyst",
            "Optometrist",
            "Personal Care Aid",
            "Photographer",
            "Physicist",
            "Plumber",
            "Politician",
            "Product Design",
            "Professor",
            "Project Manager",
            "Property Manager",
            "Purchasing Manager",
            "Quality Control Analyst",
            "Reporter",
            "Restaurant Manager",
            "Robotics Engineer",
            "Sales Manager",
            "Scientist",
            "Service Manager",
            "Small Business Owner",
            "Sociologist",
            "Software Developer",
            "Space Scientist",
            "Steel Worker",
            "Supervisor",
            "Surveyor",
            "Systems Analyst",
            "Teacher",
            "Technical Writer",
            "Technology Architect",
            "Tour Guide",
            "Transportation Engineer",
            "Tutor",
            "Veterinarian",
            "Waiter",
            "Wind Energy Engineer"
       });
    }
}
