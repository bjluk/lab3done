using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SinExWebApp20315827v2.Models;

namespace SinExWebApp20315827v2.Controllers
{
    public class DestinationsController : Controller
    {
        // GET: Destinations
        public ActionResult Index()
        {
            return View(PopulateDestination());
        }

        private List<Destinations> PopulateDestination()
        {
            var destinations = new List<Destinations>();
            destinations.Add(new Destinations { City = "Beijing", ProvinceCode = "BJ" });
            destinations.Add(new Destinations { City = "Changchun", ProvinceCode = "JL" });
            destinations.Add(new Destinations { City = "Changsha", ProvinceCode = "HN" });
            destinations.Add(new Destinations { City = "Chengdu", ProvinceCode = "SC" });
            destinations.Add(new Destinations { City = "Chongqing", ProvinceCode = "CQ" });
            destinations.Add(new Destinations { City = "Fuzhou", ProvinceCode = "JX" });
            destinations.Add(new Destinations { City = "Golmud", ProvinceCode = "QH" });
            destinations.Add(new Destinations { City = "Guangzhou", ProvinceCode = "GD" });
            destinations.Add(new Destinations { City = "Guiyang", ProvinceCode = "GZ" });
            destinations.Add(new Destinations { City = "Haikou", ProvinceCode = "HI" });
            destinations.Add(new Destinations { City = "Hailar", ProvinceCode = "NM" });
            destinations.Add(new Destinations { City = "Hangzhou", ProvinceCode = "ZJ" });
            destinations.Add(new Destinations { City = "Harbin", ProvinceCode = "HL" });
            destinations.Add(new Destinations { City = "Hefei", ProvinceCode = "AH" });
            destinations.Add(new Destinations { City = "Hohhot", ProvinceCode = "NM" });
            destinations.Add(new Destinations { City = "Hong Kong", ProvinceCode = "HK" });
            destinations.Add(new Destinations { City = "Hulun Buir", ProvinceCode = "NM" });
            destinations.Add(new Destinations { City = "Jinan", ProvinceCode = "SD" });
            destinations.Add(new Destinations { City = "Kashi", ProvinceCode = "XJ" });
            destinations.Add(new Destinations { City = "Kunming", ProvinceCode = "YN" });
            destinations.Add(new Destinations { City = "Lanzhou", ProvinceCode = "GS" });
            destinations.Add(new Destinations { City = "Lhasa", ProvinceCode = "XZ" });
            destinations.Add(new Destinations { City = "Macau", ProvinceCode = "MC" });
            destinations.Add(new Destinations { City = "Nanchang", ProvinceCode = "JX" });
            destinations.Add(new Destinations { City = "Nanjing", ProvinceCode = "JS" });
            destinations.Add(new Destinations { City = "Nanning", ProvinceCode = "JX" });
            destinations.Add(new Destinations { City = "Qiqihar", ProvinceCode = "HL" });
            destinations.Add(new Destinations { City = "Shanghai", ProvinceCode = "SH" });
            destinations.Add(new Destinations { City = "Shenyang", ProvinceCode = "LN" });
            destinations.Add(new Destinations { City = "Shijiazhuang", ProvinceCode = "HE" });
            destinations.Add(new Destinations { City = "Taipei", ProvinceCode = "TW" });
            destinations.Add(new Destinations { City = "Taiyuan", ProvinceCode = "SX" });
            destinations.Add(new Destinations { City = "Tianjin", ProvinceCode = "HE" });
            destinations.Add(new Destinations { City = "Urumqi", ProvinceCode = "XJ" });
            destinations.Add(new Destinations { City = "Wuhan", ProvinceCode = "HB" });
            destinations.Add(new Destinations { City = "Xi'an", ProvinceCode = "SN" });
            destinations.Add(new Destinations { City = "Xining", ProvinceCode = "QH" });
            destinations.Add(new Destinations { City = "Yinchuan", ProvinceCode = "NX" });
            destinations.Add(new Destinations { City = "Yumen", ProvinceCode = "GS" });
            destinations.Add(new Destinations { City = "Zhengzhou", ProvinceCode = "HA" });
            return (destinations);
        }

    }
}