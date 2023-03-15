using MVCDevam_0.Models.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDevam_0.Controllers
{
    public class CategoryController : Controller
    {

       

        public CategoryController()
        {
            
        }

       static List<Category> categories = new List<Category>
        {
            new Category
            {
                CategoryName = "Tatlilar",
                Description = "Cok tatlılar"
            },
            new Category
            {
                CategoryName = "Tuzlular",
                Description = "Cok Tuzlular"
            }
        };

       
        public ActionResult ListCategories()
        {
          
            return View(categories);
        }


        #region OnemliNotlar
        //Model göndermek Front end'e göstermek istedigimiz bilgileri Back End'den Front End'e veya Front End'ten almak istedigimiz verileri Front End'den Back End'e göndermenin bir yoludur...Eger bu bilgi string tipte yollanacak ise o zaman string verisinin object'e cast edilerek argüman olarak verilmesi gerekir ("Deneme" as object) 
        #endregion
        public ActionResult AddCategory()
        {
            //Eger bir Action, View'a model göndermiyorsa;ancak buna rağmen View'iniz sanki bir model karşılarmış gibi @model keyword'u ile bir model set etmişse bu demektir ki bir Post request'inde bu View bir Post Action'ına model gönderiyor(veri gönderiyor)
            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(Category cr)
        {

            categories.Add(cr);

           
            return RedirectToAction("ListCategories");
        }

    }
}