using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Goods.DataAccess;
using Goods.Models;
using Microsoft.AspNetCore.Mvc;

namespace Goods.Controllers
{
    public class Goods : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public Goods(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public IActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> Store()
        {
            int quantity = 0;
            int.TryParse(Request.Form["quantity"], out quantity);
            string description = Request.Form["description"];
            this._dbContext.Add(new Good { Desciption =description, Quantity = quantity });
            var affected = await _dbContext.SaveChangesAsync();
            var returnedMessage = affected > 0 ? "Good Saved" : "Save Failed";
            return View(model:returnedMessage);
        }
    }
}
