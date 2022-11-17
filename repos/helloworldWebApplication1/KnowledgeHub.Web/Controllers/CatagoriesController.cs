using KnowledgeHub.Web.Models.Data;
using KnowledgeHub.Web.Models.Entities;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace KnowledgeHub.Web.Controllers
{
    public class CatagoriesController : Controller
    {
        KnowledgeHubDBContext db = new KnowledgeHubDBContext();


        //for create/ saving data  
        //we made two action method using same name so we have to describe when which method will Mapped/called.
        //'httpget' attribute tells that this method is mapped when user click on any hyper link.
        //'httppost' attribute tells that this method should revoked when user post the data in form.

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Catagory catagory)
        {
            //do validation
            if (!ModelState.IsValid)
                return View("Create");



            db.catagories.Add(catagory);
            db.SaveChanges();
            TempData["message"] = $"the entry {catagory.Name} is successfully created ";


            //var message = new MimeMessage();
            //message.From.Add(new MailboxAddress("Pratian", "temporarypratian@gmail.com"));
            //message.To.Add(new MailboxAddress("Siddharth", "tayadesiddharth9@gmail.com"));
            //message.Subject = "New catagory has been Created";
            //message.Body = new TextPart("plain")
            //{
            //    Text = "Hi, there." +
            //    "A new Catagory has been added to the database. kindly check and do the needful!!!"
            //};
            //using (var client = new SmtpClient())
            //{
            //    client.Connect("smtp.gmail.com", 587, false);
            //    client.Authenticate("temporarypratian@gmail.com", "Pratian@123");
            //    client.Send(message);
            //    client.Disconnect(true);
            //}


            return RedirectToAction("Index");
        }



        //fetch the catagory details
        public IActionResult Index(string SearchValue)
        {
            List<Catagory> catagories = null;
            //fetch catagory with filtervdata
            if (SearchValue != null && SearchValue.Length != 0)
            {
                catagories = (from c in db.catagories where c.Name.Contains(SearchValue) || c.Description.Contains(SearchValue) select c).ToList();

                return View(catagories);
            }



             catagories = db.catagories.ToList();

            //for sending this data to the view

            //ViewBag.CatagoryData = catagories;        //'view bag' , view data' , 'tempdata' can be used to send small data to the view

            //ViewData["catagorydata"] = catagories;

            //TempData["catagorydata"] = catagories;    //tempdata is temporary data this we can use to send data between one action method to another action method

            return View(catagories);  //in our case we have structure data /huge data so we send it by passing it to view
        }
        
        
        
        // For delete data in database

        public IActionResult Delete(int id)
        {
            Catagory catagoryToDelete = db.catagories.Find(id);
            if (catagoryToDelete == null)
            {
                return NotFound();
            }
            return View("ConfirmDelete", catagoryToDelete);

        }

        public IActionResult ConfirmDelete(int id)
        {
            Catagory catagoryToDelete = db.catagories.Find(id);
            db.catagories.Remove(catagoryToDelete);
            db.SaveChanges();
            TempData["Message"] = $"Catagory {catagoryToDelete.Name} deleted successfully.";
            return RedirectToAction("Index");
        }



            //for edit data in database
            [HttpGet]
        public IActionResult Edit(int id)
         {
                    Catagory CatagoryToEdit = db.catagories.Find(id);

                    if (CatagoryToEdit == null)
                    {
                        return NotFound();
                    }

                    return View(CatagoryToEdit);


         }
        [HttpPost]
        public IActionResult Edit(Catagory EditedCatagory)
        {
            if (!ModelState.IsValid )
            {
                return View();
            }
            db.Entry(EditedCatagory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            TempData["message"] = $"catagory {EditedCatagory.Name} updated successfully";
            return RedirectToAction("index");
        }







    }
}
