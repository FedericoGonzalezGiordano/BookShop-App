﻿using BackEnd.Front.Implementation;
using BackEnd.Front.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleFront front;
        public ArticleController()
        {
          front=new ArticleFront();
        }
        [HttpPost("/PostArticle")]
        public IActionResult PostArticule(ArticleModel article) 
        {
            try
            {
                var result = front.ArticleRegistration(article);
                if (result == null)
                {
                    return StatusCode(500, "An error occurred while registering an article");
                }
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
