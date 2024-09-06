namespace CV_bin.Models
{
    public class ResumeModels
    {
        // Personal Details
        public string Name { get; set; } = "Ifeoluwa Ibukun-ojo";
        public string Email { get; set; } = "ifeoluwa758@gmail.com";
        public string Phone { get; set; } = "07037164268";
        public string Location { get; set; } = "Lagos, Nigeria";
        public string LinkedIn { get; set; } = "linkedin.com/in/ifeoluwa-ibukun-ojo";
        public string GitHub { get; set; } = "https://github.com/Noblebloodjane";

        // Skills
        public List<string> Languages { get; set; } = new List<string> { "C#", "SQL", "Python", "JavaScript", "Typescript", "HTML", "CSS" };
        public List<string> Technologies { get; set; } = new List<string> { "ASP.NET Core", "Git", "Azure", "SQL Server", "PostgreSQL", "React", "Flutter" };

        // Professional Experience
        public List<Experience> Experiences { get; set; } = new List<Experience>
        {
            new Experience
            {
                Title = "Business Intelligence Analyst (Contract)",
                Company = "Mount foodji",
                Duration = "07/2024 – 08/2024",
                Location = "Lagos, Nigeria",
                Responsibilities = new List<string>
                {
                    "Analyzed 10,000+ transaction records using Python and pandas, identifying top-selling items and increasing sales by 15%",
                    "Implemented data-driven inventory management, reducing waste by 30%",
                    "Performed competitor analysis of 15 local restaurants using web scraping techniques, identifying key market opportunities"
                }
            },
            new Experience
            {
                Title = "Junior Software Engineer",
                Company = "Cittanuvola",
                Duration = "01/2023 – 12/2023",
                Location = "Lagos, Nigeria",
                Responsibilities = new List<string>
                {
                    "Architected and implemented scalable backend systems for educational and real estate sectors, significantly improving operational efficiency",
                    "Developed RESTful APIs for inventory tracking, enabling seamless integration with existing business processes and enhancing data accessibility",
                    "Designed and developed a mobile application for inventory management, facilitating real-time data synchronization and supporting data-driven decision-making"
                }
            }
        };

        // Education
        public List<Education> Education { get; set; } = new List<Education>
        {
            new Education
            {
                Degree = "BSc. Computer Software Engineering",
                Institution = "Babcock University",
                Duration = "09/2020 – 07/2024",
                Location = "Ogun, Nigeria",
                Project = "Final Year Project: Design and Implementation of a Clinical Databank Request System"
            }
        };
        public List<string> Certifications { get; set; } = new List<string> { "Associate Data Engineer in SQL" };

        // Awards and Volunteer Work
        public List<string> Awards { get; set; } = new List<string>
        {
            "Femmetech Exhibition, Babcock - Led the development of a job site catering to blue-collar workers, enhancing job accessibility"
        };
        public List<string> VolunteerWork { get; set; } = new List<string>
        {
            "Statistics without borders - 02/2024 – present",
            "Enactus - 05/2022 – 11/2023, Ogun, Nigeria"
        };
    }

    public class Experience
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }
        public List<string> Responsibilities { get; set; }
    }

    public class Education
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
        public string Duration { get; set; }
        public string Location { get; set; }
        public string Project { get; set; }
    }
}
