using Microsoft.AspNetCore.Mvc;
using MVCX1.Models;
using MVCX1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCX1.Controllers
{
    public class HomeController : Controller
    {

        public GetScore _cards;

        /// <summary>
        /// 构造函数方式注入
        /// </summary>
        /// <param name="cards"></param>
        public HomeController(GetScore cards)
        {
            _cards = cards;
        }
        //public ObjectResult  Index()
        //{
        //    return _cards.getCard("Messi");
        //    return Json(new { Name = "zhangsan",Sex = "Man"});
        //}
        public IActionResult Index(string name)
        {
            //Players goat = _cards.getCard("Messi");
            //ViewData["PageTitle"] = "CF";
            //ViewData["score"] = goat;
            //return View();

            //Players goat = _cards.getCard("Messi");
            //ViewBag.TitleX = "就这？";
            //ViewBag.DataX = goat;
            //return View();

            //强类型转换返回
            //Players goat = _cards.getCard("Messi");
            //return View(goat);

            //viewmodel
            //string cha = "Messi";
            //if (!string.IsNullOrEmpty(name))
            //    cha = name;

            //PlayerExpand goats = new PlayerExpand()
            //{
            //    barca = _cards.getCard(cha),
            //    GOAT = "GOAT"
            //};
            //return View(goats);

            //IEnumerable类型
            var barces = _cards.getAllPlayers();
            return View(barces);
        }




        public IActionResult PlayersIndex()
        {
            Players goat = _cards.getCard("Messi");
            return View(goat);

            //使用指定路径
            //return View("~/ViewsTest/Home/PlayersIndex.cshtml");
        }

        [HttpGet]
        public IActionResult AddFormX()
        {
            ViewBag.Title = "球员卡";
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddFormX(Players player)
        {
            Players newOne = _cards.AddPl(player);
            return RedirectToAction("Index",new { name = newOne .Name});
        }
    }
}
