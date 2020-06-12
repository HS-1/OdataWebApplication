using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Service;
using WebApplication1.Model;

namespace WebApplication1.Pages.Application
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Student studentModel { get; set; }
        private IStudentLogic _studentLogic;

        public EditModel(IStudentLogic studentLogic)
        {
            _studentLogic = studentLogic;
        }

        public async Task OnGetAsync()
        {
            Guid id = new Guid(Request.Query["id"]);
            studentModel =  await _studentLogic.GetStudentAsync(id);
        }

        public IActionResult OnPostUpdateApplication()
        {
            //Todo: update logic
            return RedirectToPage("./Overview");
        }

        public IActionResult OnPostBack()
        {
            return RedirectToPage("./Overview");
        }
    }
}