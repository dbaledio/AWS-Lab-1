using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LambdaShoppingListWebAPI.Models;
using LambdaShoppingListWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LambdaShoppingListWebAPI.Controllers
{
    [Route("v1/shoppingList")]
    public class ShoppingListController : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingListController(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var results = _shoppingListService.GetItemsFromShoppingList();
            
            return Ok(results);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItemsToShoppingList(shoppingList);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemsFromShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);

            return Ok();
        }
    }
}