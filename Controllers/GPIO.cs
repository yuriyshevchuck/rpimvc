using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using rpimvc.Models;
using System.Device.Gpio;

namespace rpimvc.Controllers
{
    public class GPIOController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public GPIOController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public JsonResult TurnOn(int id)
        {
            var res = "Off";
            try
            {
                Program.GpioController.Write(Program.LedPin, PinValue.Low);
                res = "On";
            }
            catch(Exception e)
            {
            }

            return Json(new {id = Program.LedPin, state = res});
        }

        public JsonResult TurnOff(int id)
        {
            var res = "On";
            try
            {
                Program.GpioController.Write(Program.LedPin, PinValue.High);
                res = "Off";
            }
            catch(Exception e)
            {
            }
            return Json(new {id = Program.LedPin, state = res});
        }
    }
}
