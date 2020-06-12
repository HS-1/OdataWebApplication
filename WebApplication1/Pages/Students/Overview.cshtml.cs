using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebApplication1.Model;

namespace WebApplication1.Pages.Students
{
    public class OverviewModel : PageModel
    {
        public IList<Student> students { get; set; }
        public string url { get; set; }
        public async Task OnGetAsync()
        {
            url = "https://localhost:44372/odata/Students";
            //url = "https://localhost:44339/odata/odataApplication";
            //students = await GetDummyServiceAsync();
        }
    }
}