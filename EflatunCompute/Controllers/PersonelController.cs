using EflatunCompute.Models;
using EflatunCompute.Services.Implementation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EflatunCompute.Controllers
{
    public class PersonelController : Controller
    {
        private readonly PersonelService _personelService;
        public PersonelController(PersonelService personelService)
        {
            _personelService = personelService;
        }

        public IActionResult Index()
        {
            var personeller = _personelService.GetAll().Select(personel => new PersonelIndexViewModel
            {
                Id = personel.Id,
                PersonelNo = personel.PersonelNo,
                ImageUrl = personel.ImageUrl,
                AdiSoyadi = personel.AdiSoyadi,
                IseBaslamaTarihi = personel.IseBaslamaTarihi,
                YasadigiSehir = personel.YasadigiSehir

            }).ToList();
            return View(personeller);
        }
    }
}
