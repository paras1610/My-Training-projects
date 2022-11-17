using MailKit.Net.Smtp;
using MimeKit;

using KnowledgeHub.Web.Models.Entities;
using KnowledgeHub.Web.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace KnowledgeHub.Web.Controllers
{
    public class ArticlesController : Controller
    {
        KnowledgeHubDBContext db = new KnowledgeHubDBContext();

        //public IActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]        
        public IActionResult Create()
        {
            ViewBag.CatagoryID = from c in db.catagories
                                 select new SelectListItem 
                                 {
                                     Text = c.Name, 
                                     Value = c.CatagoryID.ToString() 
                                 } ;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Article article)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Create");


            article.DateSubmitted = DateTime.Now;
            article.PostedBy = "paras"; //User.Identity.Name;
            article.IsApproved = false;
            db.articles.Add(article);
            db.SaveChanges();
            TempData["message"] = $"New article {article.Title} is added";
            return RedirectToAction("Create");
        }

        public IActionResult Index()
        {
            List<Article> articles = null;
            //fetch catagory with filtervdata
            
                articles = (from art in db.articles where art.IsApproved == true || art.IsApproved==false   select art).ToList();

                return View(articles);
           


            articles = db.articles.ToList();

           
            return View(articles);
        }
    }
}
