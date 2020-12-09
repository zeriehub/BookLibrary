using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooklistRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BooklistRazor.Pages.BookList
{
    public class indexModel : PageModel
    {

        private readonly ApplicationDBContext _db;


        public indexModel(ApplicationDBContext db)
        {
            _db = db;
        }


        public IEnumerable<Book>  Books { get; set; }



        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();

        }
    }
}
