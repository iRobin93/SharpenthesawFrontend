using MotivationalAPI.TaskServices;
using Task = System.Threading.Tasks.Task;

namespace MotivationalAPI.UserServices;

public class UserService(IDatabase repository)
{
	private IDatabase _repository = repository;

	public Task AddUser(User user, UserInput userInput)
	{
		return _repository.AddUser(user, userInput);
	}

	public Task<List<User>> GetAllUsers()
	{
		return _repository.GetAllUsers();
	}

	public Task<User> GetUserById(int id)
	{
		return _repository.GetUserById(id);
	}

	public void DeleteUser(int id)
	{
		_repository.DeleteUser(id);
	}

	public void UpdateUser(UserInput userInput, int id)
	{
		_repository.UpdateUser(userInput, id);
	}
	//
	public Task AddTask(Task task, TaskInput taskInput)
	{
		return _repository.AddTask(task, taskInput);
	}

	public Task<List<User>> GetAllUsersTasks(int UserId)
	{
		return _repository.GetAllUsersTasks();
	}

	public Task<User> GetTaskById(int id)
	{
		return _repository.GetTaskById(id);
	}

	public void DeleteTask(int id)
	{
		_repository.DeleteTask(id);
	}

	public void UpdateTask(Task task, int id)
	{
		_repository.UpdateTask(task, id);
	}
}