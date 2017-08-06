using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkIt_Assesment.Models
{
	public class UserRepository : IUserRepository
	{
		private List<User> users = new List<User>();
		private int _nextId = 1;

		public UserRepository()
		{
			Add(new User { Id = 1, Name = "Tom", ForeName = "Groceries", SurName = "Heer", Created = DateTime.Now });
			Add(new User { Id = 2, Name = "Tom1", ForeName = "Groceries", SurName = "Heer", Created = DateTime.Now });
			Add(new User { Id = 3, Name = "Tom2", ForeName = "Groceries", SurName = "Heer", Created = DateTime.Now });
		}

		public IEnumerable<User> GetAll()
		{
			return users;
		}

		public User Get(int id)
		{
			return users.Find(p => p.Id == id);
		}

		public User Add(User item)
		{
			item.Created = DateTime.Now;
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			item.Id = _nextId++;
			users.Add(item);
			return item;
		}

		public void Remove(int id)
		{
			users.RemoveAll(p => p.Id == id);
		}

		public bool Update(User item)
		{
			item.Created = DateTime.Now;
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			int index = users.FindIndex(p => p.Id == item.Id);
			if (index == -1)
			{
				return false;
			}
			users.RemoveAt(index);
			users.Add(item);
			return true;
		}
	}
}