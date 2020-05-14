using LambdaShoppingListWebAPI.Models;
using System.Collections.Generic;

namespace LambdaShoppingListWebAPI.Services
{
	public interface IShoppingListService
	{
		Dictionary<string, int> GetItemsFromShoppingList();
		void AddItemsToShoppingList(ShoppingListModel shoppingList);
		void RemoveItem(string shoppingListName);
	}

}
