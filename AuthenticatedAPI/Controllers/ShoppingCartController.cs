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
    public class ShoppingCartController : ControllerBase
    {
        private AppDataContext conte;
        public ShoppingCartController(AppDataContext cont){
            this.conte = cont;
        }

        [HttpPost("AddItem/{Id}")]
        public string AddTheItemToShoppingCart(int Id){
            return "Item Added Successfully";
        }

        [HttpGet]
        public void GetAllProductsInUserShoppingCart()
        {
        
        }

        [HttpPost("RemoveItem/{ID}")]
        public string RemoveItemFromCart(int ID){
            return "Item Removed successfully";
        }

    }