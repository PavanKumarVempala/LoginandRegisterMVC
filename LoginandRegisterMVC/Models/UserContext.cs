using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InterviewTracker.Models
{
    public class UserContext:DbContext
    {
        public UserContext() : base("Name=Dbconfig")
        {

        }
        public DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<InterviewTracker.Models.Candidate> Candidates { get; set; }
    }
}