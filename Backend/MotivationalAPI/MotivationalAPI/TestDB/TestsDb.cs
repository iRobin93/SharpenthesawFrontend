using MotivationalAPI.TaskServices;
using MotivationalAPI.UserServices;
using Task = System.Threading.Tasks.Task;

namespace MotivationalAPI.TestDB;

public class TestsDb : IDatabase

{
	
	List <User> Users = new List<User>
	{
	new User(1, "Alice", "alice@example.com", "password1", "Admin", 100, 5),
	new User(2, "Bob", "bob@example.com", "password2", "User", 80, 2),
	new User(3, "Charlie", "charlie@example.com", "password3", "Moderator", 90, 3),
	new User(4, "Diana", "diana@example.com", "password4", "User", 70, 1),
	new User(5, "Eve", "eve@example.com", "password5", "Guest", 50, 0)
	};
	public Task AddUser(User user, UserInput userInput)
	{
		Users.Add(user);
		Console.WriteLine(Users.ToString());
		return Task.CompletedTask;
	}

	public Task<List<User>> GetAllUsers()
	{
		return Task.FromResult(new List<User>(Users));
	}

	public Task<User> GetUserById(int id)
	{
		foreach (var user in Users)
		{
			if (user.Id == id)
			{
				return Task.FromResult(user);
			}
		}
		return Task.FromResult<User>(null);
	}

	public void UpdateUser(UserInput userInput, int id)
	{
		foreach (var user in Users)
		{
			if (user.Id == id)
			{
				user.Name = userInput.Name;
				user.Email = userInput.Email;
				user.Password = userInput.Password;
				user.Role = userInput.Role;
				user.Lifepoints = userInput.Lifepoints;
				user.WeedStones = userInput.WeedStones;
				
			}
		}
	}

	public void DeleteUser(int id)
	{
		foreach (var user in Users.Where(user => user.Id == id))
		{
			Users.Remove(user);
		}
	}

	public Task AddTask(Task task, TaskInput taskInput)
	{
		throw new NotImplementedException();
	}

	public Task<List<User>> GetAllUsersTasks()
	{
		throw new NotImplementedException();
	}

	public Task<User> GetTaskById(int id)
	{
		throw new NotImplementedException();
	}

	public void UpdateTask(Task task, int id)
	{
		throw new NotImplementedException();
	}

	public void DeleteTask(int id)
	{
		throw new NotImplementedException();
	}
}