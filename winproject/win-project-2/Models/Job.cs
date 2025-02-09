﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win_project_2.DAO
{
    public class Job
    {
        public int JobID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Salar {  get; set; }
        public string Type { get; set; }
        public string Company {  get; set; }
        public DateTime PostedDate { get; set; }
        public string Status { get; set; }

        public Job(int jobID, string title, string description, string location, string salar, string type, string company, DateTime postedDate, string status)
        {
            JobID = jobID;
            Title = title;
            Description = description;
            Location = location;
            Salar = salar;
            Type = type;
            Company = company;
            PostedDate = postedDate;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Title} - {Location} ({Status})";
        }
    }


}
