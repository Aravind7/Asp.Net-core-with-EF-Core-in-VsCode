using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApi.Models;

namespace QuizApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private DBContext _context;

        public QuizController(DBContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IEnumerable<TblMstQuizCategory> getCategory()
        {
            try{
               return _context.TblMstQuizCategory;
            }
            catch(Exception ex)
            {
                 
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
            
        }

         [HttpPost]
         public IEnumerable

    }


}