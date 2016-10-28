using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganisationWebsite.Models
{
    public class RegMemberViewModel
    {
        public List<organisations> orgs { get; set; }
        public members member { get; set; }

        public RegMemberViewModel()
        {
            orgs = new List<organisations>();
            member = new members();
        }

        public RegMemberViewModel(List<organisations> orgs)
        {
            this.orgs = orgs;
            member = new members();
        }

        public RegMemberViewModel(members member)
        {
            orgs = new List<organisations>();
            this.member = member;
        }

        public RegMemberViewModel(List<organisations> org, members member)
        {
            this.orgs = orgs;
            this.member = member;
        }
    }
}