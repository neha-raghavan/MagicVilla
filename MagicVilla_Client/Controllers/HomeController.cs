using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_Client.Models;
using System.Data;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace MagicVilla_Client.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    string BaseUrl = "https://localhost:7188/api/VillaAPI";
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<ActionResult> Index()
    {
        DataTable dt= new DataTable();
        using(var client= new HttpClient())
        {
            client.BaseAddress=new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage getData = await client.GetAsync("");

            if(getData.IsSuccessStatusCode)
            {
                string Results=getData.Content.ReadAsStringAsync().Result;
                dt=JsonConvert.DeserializeObject<DataTable>(Results);
            }
            else
            {
                Console.WriteLine("Error in calling web api");
            }
            ViewData.Model= dt;
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
