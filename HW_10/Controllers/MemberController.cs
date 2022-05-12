using Microsoft.AspNetCore.Mvc;
using HW_10.infrastructure.DataAccess;
using HW_10.Models;
namespace HW_10.Controllers
{
    public class MemberController : Controller
    {
        private MemberRepository O_product_R;
        private EF_Repository O_EF_Repository;
        public MemberController()
        {
            O_product_R = new MemberRepository();
            O_EF_Repository = new EF_Repository();
        }
        public IActionResult Index()
        {
            var List_M = O_product_R.GetAllMember();
            return View(List_M);

        }
        public IActionResult Library()
        {
            var List_M = O_EF_Repository.GetAllInfoLibarary();
            return View(List_M);

        }
        [HttpGet]
        public IActionResult AddMember()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddMember(Member item)
        {
            O_product_R.Addmember(item);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var x = O_product_R.GetMemberdatail(id);
            O_product_R.DelteMember(x);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditMember(int id)
        {
            var x = O_product_R.GetMemberdatail(id);
            return View(x);
        }
        [HttpPost]
        public IActionResult EditMember(Member item)
        {

            O_product_R.EditMember(item);
            return RedirectToAction("Index");
        }
        public IActionResult DetailMember(int id)
        {
            var x = O_product_R.GetMemberdatail(id);
            return View(x);

        }
        [HttpGet]
        public IActionResult search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult search(Member item)
        {
            var x = O_product_R.search(item.Name, item.Family);

            return View("resultsearch", x);
        }


    }
}

