using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopRecepti.Web.ViewModels.Home;

namespace TopRecepti.Services.Data
{
    public interface IGetCountsService
    {
        IndexViewModel GetCounts();
    }
}
