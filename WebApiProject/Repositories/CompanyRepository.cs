using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiProject.DataAcces;
using WebApiProject.Interfaces;
using WebApiProject.Models;

namespace WebApiProject.Repositories
{
    public class CompanyRepository : ICompany
    {
        ApplicationContext context;

        public CompanyRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Company> Companies
        {
            get
            {
                return context.Companies;
            }
        }


    }
}
