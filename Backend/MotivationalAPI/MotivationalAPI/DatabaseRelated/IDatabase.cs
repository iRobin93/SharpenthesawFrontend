using MotivationalAPI.TaskServices;
using Task = System.Threading.Tasks.Task;

namespace MotivationalAPI.UserServices;

public interface IDatabase
{
		public Task AddUser(User user, UserInput userInput);
		public Task<List<User>> GetAllUsers();
		public Task<User> GetUserById(int id);
		public void UpdateUser(UserInput userInput, int id);
		public void DeleteUser(int id);
		public Task AddTask(Task task, TaskInput taskInput);
		public Task<List<User>> GetAllUsersTasks();
		public Task<User> GetTaskById(int id);
		public void UpdateTask(Task task, int id);
		public void DeleteTask(int id);
}