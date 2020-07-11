using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OWinSelfHostingLab
{
    public class CategoryController:ApiController
    {
        public List<String> Get()
        {
            return new List<string>() {"Bob","RAM", "Farag" };
        }

    }
}
