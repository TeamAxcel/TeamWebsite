using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrganisationWebsite.Models
{
    public class RegMemberViewModel
    {
        public List<organisation> orgs { get; set; }
        public member member { get; set; }

        public RegMemberViewModel()
        {
            orgs = new List<organisation>();
            member = new member();
        }

        public RegMemberViewModel(List<organisation> orgs)
        {
            this.orgs = orgs;
            member = new member();
        }

        public RegMemberViewModel(member member)
        {
            orgs = new List<organisation>();
            this.member = member;
        }

        public RegMemberViewModel(List<organisation> org, member member)
        {
            this.orgs = orgs;
            this.member = member;
        }
    }
}