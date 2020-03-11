using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTestApp
{
    public class ProgressReportModel
    {
        public int percentage { get; set; } = 0;
        public List<WebsiteDataModel> WebSitesDownlaoded { get; set; } = new List<WebsiteDataModel>();
    }
}
