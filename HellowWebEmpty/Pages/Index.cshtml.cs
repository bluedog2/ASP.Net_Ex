using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HellowWebEmpty.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HellowWebEmpty.Pages
{
    public class IndexModel : PageModel
    {
        // 모델 바인딩 참가 암시
        [BindProperty]
        public HelloMessage helloMsg { get; set; }

        public string Noti { get; set; }

        public void OnGet()
        {
            this.helloMsg = new HelloMessage()
            {
                Message = "Hello Razor page"
            };
        }

        public void OnPost()
        {
            this.Noti = "Message Changed";
        }
    }
}
