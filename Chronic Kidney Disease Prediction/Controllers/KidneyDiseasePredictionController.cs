using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chronic_Kidney_Disease_PredictionML.Model;

namespace Chronic_Kidney_Disease_Prediction.Controllers
{
    public class KidneyDiseasePredictionController : Controller
    {
        private readonly ILogger<KidneyDiseasePredictionController> _logger;

        public KidneyDiseasePredictionController(ILogger<KidneyDiseasePredictionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ModelInput input)
        {
            ModelOutput prediction=ConsumeModel.Predict(input);
            ViewBag.Result = prediction;
            return View();
        }
    }
}
