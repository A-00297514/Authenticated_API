using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthenticatedAPI.Data;
using AuthenticatedModels;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace AuthenticatedAPI.Controllers;

    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

    }