using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SelfServisUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace SelfServisUI.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        string Baseurl = "https://jsonplaceholder.typicode.com/posts/";
        public IActionResult StudentLogin()
        {
            return View();
        }
        
        public async Task<IActionResult> StudentInfo(int tc)
        {
            StudentModel studentModel = new StudentModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl + tc);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync(Baseurl + tc);
                if (Res.IsSuccessStatusCode)
                {
                    var StudentResponse = Res.Content.ReadAsStringAsync().Result;
                    studentModel = JsonConvert.DeserializeObject<StudentModel>(StudentResponse);
                    
                }
            }
            return View(studentModel);

        }


        public IActionResult StudentPasswordStepOne(StudentModel model)
        {
            return View(model);
        }

        public async Task<IActionResult> StudentPasswordStepTwo(StudentModel model, int phone)
        {
            if (model.Id == phone)
            {
                return View(model);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult StudentPasswordStepThree(StudentModel model, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                var response = client.PostAsJsonAsync<StudentModel>(client.BaseAddress, model);
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult StudentNumberSearch()
        {
            return View();
        }
    }
}
