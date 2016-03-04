using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
//using DocuTrackerEF7.DAL;
using DTDataService;
using DTModels;
using DTModels.Interfaces;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IDTReader _reader;
        public HomeController(IDTReader reader)
        {
            _reader = reader;
        }
        public IActionResult Index()
        {
            // person.Photos
            //var photos = person.PersonPhotos.Select(c => c.Photo);
            var answer = _reader.GetAllAnswers();
            var questions = _reader.GetAllQuestions();
            var question_answer = _reader.GetAllQuestionAnswers();

            //var ansList = answer.QuestionAnswer.Select(c => c.Questions);
            var list = _reader.GetAllAnswerTypes();
            return View();
        }

        public IActionResult About()
        {

            //var list = DTDataService.DTReader.

           ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
