using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XOPOW.Models;

namespace XOPOW.Pages
{
    public class AddModel : PageModel
    {
        private readonly AppDbContext _db;
        public List<Morodec> Morodecs { get; set; }
        [BindProperty]
        public Morodec Morodec { get; set; }
        public AddModel(AppDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Morodecs = _db.Morodci.ToList();

        }

        public ActionResult OnPost()
        {
            _db.Morodci.Add(Morodec);
            _db.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
