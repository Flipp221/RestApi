using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.IRest
{
	public class TodoItemManager
	{
		IRestService restService;

		public TodoItemManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<TodoItem>> GetTasksAsync()
		{
			return restService.RefreshDataAsync();
		}
	}
}
