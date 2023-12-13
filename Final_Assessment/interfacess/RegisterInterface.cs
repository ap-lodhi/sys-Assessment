using Final_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment.interfacess
{
  public  interface RegisterInterface
    {
        ResponseModel SignupUser(RegisterModel objmodel);
        ResponseModel loginUser(RegisterModel objmodel);



    }
}
