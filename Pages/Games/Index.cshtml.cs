using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly FinalProject.Models.GameDbContext _context;

        public string SearchTerm {get; set;}

        public IndexModel(FinalProject.Models.GameDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        [BindProperty(SupportsGet =true)]
        public int PageNum {get; set;} =1;
        public int PageSize {get; set;} =10;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}


        public async Task OnGetAsync()
        {
            var query = _context.Games.Select(g => g);
            
            switch (CurrentSort)
            {
                case "genre_asc":
                    query =query.OrderBy(g => g.Genre);
                    break;
                case "genre_desc":
                    query = query.OrderByDescending(g =>g.Genre);
                    break;
            }
            switch (CurrentSort)
            {
                case "title_asc":
                    query =query.OrderBy(g => g.Title);
                    break;
                case "title_desc":
                    query = query.OrderByDescending(g =>g.Title);
                    break;
            }
            Game = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
