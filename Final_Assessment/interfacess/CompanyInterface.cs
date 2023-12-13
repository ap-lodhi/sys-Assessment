using Final_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment.interfacess
{
    interface CompanyInterface
    {

        ResponseModel saveCompany(CompanyModel C);
        List<ContryModel> getCountryList();
         List<CityModel> getCityList(int id);
        List<StateModel> getStateList( int id);
        List<CompanyModel> getComapnyList();
        CompanyModel editCompany(int id);
        ResponseModel updateCompany(CompanyModel C);
    }
}
