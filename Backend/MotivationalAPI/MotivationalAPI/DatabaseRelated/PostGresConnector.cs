using MotivationalAPI.TaskServices;
using Task = System.Threading.Tasks.Task;

namespace MotivationalAPI.UserServices;

public class PostGresConnector: IDatabase
{
	public Task AddUser(User user, UserInput userInput)
	{
		throw new NotImplementedException();
	}

	public Task<List<User>> GetAllUsers()
	{
		throw new NotImplementedException();
	}

	public Task<User> GetUserById(int id)
	{
		throw new NotImplementedException();
	}

	public void UpdateUser(UserInput userInput, int id)
	{
		throw new NotImplementedException();
	}

	public void DeleteUser(int id)
	{
		throw new NotImplementedException();
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