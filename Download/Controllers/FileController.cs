using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Download.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        [Route("File/DownloadFile")]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        [Route("File/DownloadFile")]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            string fileContent = $"{firstName}\n{lastName}";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", $"{fileName}.txt");
            System.IO.File.WriteAllText(filePath, fileContent, Encoding.UTF8);
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/octet-stream", $"{fileName}.txt");
        }


    }
}
