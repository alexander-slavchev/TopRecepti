namespace TopRecepti.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using TopRecepti.Data;
    using TopRecepti.Data.Common.Repositories;
    using TopRecepti.Data.Models;
    using TopRecepti.Services.Data;
    using TopRecepti.Web.ViewModels;
    using TopRecepti.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService countsService;

        public HomeController(IGetCountsService countsService)
        {
            this.countsService = countsService;
        }
        public IActionResult Index()
        {
            var viewModel = this.countsService.GetCounts();
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
