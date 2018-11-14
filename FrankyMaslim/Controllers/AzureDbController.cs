using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FrankyMaslim.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
    public class AzureDbController : ControllerBase
    {
		public IConfiguration Configuration { get; set; }

		public IConfigurationSection AzureAPI
		{
			get
			{
				return Configuration.GetSection("ConnectionString").GetSection("AzureAPI");
			}
		}

		public AzureDbController(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		
		// GET: api/AzureDb
		//[Route("api/[controller]")]
		[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

		// GET: api/AzureDb/5
		//[Route("api/[controller]/{id}")]
		[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

		[HttpGet("[action]")]
		public IActionResult Main()
		{
			string apiURL = AzureAPI.GetSection("Main").Value + "1";
			HttpClient client = new HttpClient();
			var result = client.GetAsync(apiURL, HttpCompletionOption.ResponseContentRead);
			var response = result.Result.Content.ReadAsStringAsync();
			return Ok(response);
		}

		[HttpGet("[action]")]
		public IActionResult Qualifications()
		{
			var result = GetResult("Qualifications");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult JobTitles()
		{
			var result = GetResult("JobTitles");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult Education()
		{
			var result = GetResult("Education");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult ExperienceDescriptions()
		{
			var result = GetResult("ExperienceDescriptions");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult Experiences()
		{
			var result = GetResult("Experiences");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult ProjectDescriptions()
		{
			var result = GetResult("ProjectDescriptions");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult Projects()
		{
			var result = GetResult("Projects");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult TechnicalSkillCategories()
		{
			var result = GetResult("TechnicalSkillCategories");
			return Ok(result);
		}

		[HttpGet("[action]")]
		public IActionResult TechnicalSkills()
		{
			var result = GetResult("TechnicalSkills");
			return Ok(result);
		}

		private Task<string> GetResult(string endpointName)
		{
			string apiURL = AzureAPI.GetSection("Main").Value + AzureAPI.GetSection(endpointName).Value;
			HttpClient client = new HttpClient();
			var response = client.GetAsync(apiURL, HttpCompletionOption.ResponseContentRead);
			var result = response.Result.Content.ReadAsStringAsync();
			return result;
		}

		// POST: api/AzureDb
		//[Route("api/[controller]")]
		[HttpPost]
        public void Post([FromBody] string value)
        {
        }

		// PUT: api/AzureDb/5
		//[Route("api/[controller]")]
		[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

		// DELETE: api/ApiWithActions/5
		//[Route("api/[controller]")]
		[HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
