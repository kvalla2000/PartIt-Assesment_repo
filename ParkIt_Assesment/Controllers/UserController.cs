using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ParkIt_Assesment.Models;

namespace ParkIt_Assesment.Controllers
{
	public class UserController:ApiController
	{
		static readonly IUserRepository repository = new UserRepository();

		[Route("api/users")]
		[HttpGet()]
		public IEnumerable<User> GetAllUsers()
		{
			return repository.GetAll();
		}

		[Route("api/users/{id:int}")]
		[HttpGet()]
		public IHttpActionResult GetUser(int id)
		{
			var user = repository.Get(id);
			if (user == null)
			{
				return NotFound();
			}
			return Ok(user);
		}

		[Route("api/users/{id:int}")]
		[HttpPut()]
		public IHttpActionResult SetUser(int id, User user)
		{
			if (repository.Update(user))
				return Ok();
			else
				return NotFound();
		}

		[Route("api/users")]
		[HttpPost()]
		public IHttpActionResult AddUser(User user)
		{
			if (repository.Add(user) != null)
				return Ok();
			else
				return NotFound();
		}

		[Route("api/users/{id:int}")]
		[HttpDelete()]
		public IHttpActionResult Delete(int id)
		{
			repository.Remove(id);
			return Ok();
		}
	}
}
