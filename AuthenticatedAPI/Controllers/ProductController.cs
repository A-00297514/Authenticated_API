using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthenticatedAPI.Data;
using AuthenticatedModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;
namespace AuthenticatedAPI.Controllers;

    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private AppDataContext conte;
        public ProductController(AppDataContext cont){
            this.conte = cont;
        }

        [HttpGet]
        public void GetAllProducts()
        {
            
        }
        
    }