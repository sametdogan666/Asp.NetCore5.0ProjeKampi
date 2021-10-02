using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.NetCore5._0ProjeKampi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore5._0ProjeKampi.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName = "Samet"
                },
                new UserComment
                {
                    Id = 2,
                    UserName = "Enes"
                }
            };
            return View(commentValues);
        }
    }
}
