using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.IRest
{
	public interface IRestService
	{
		Task<List<TodoItem>> RefreshDataAsync();
	}
}
