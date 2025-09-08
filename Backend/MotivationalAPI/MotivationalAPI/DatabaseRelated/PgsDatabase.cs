using MotivationalAPI.TaskServices;
using Npgsql;
using Dapper;
using Microsoft.VisualBasic.CompilerServices;
using Task = System.Threading.Tasks.Task;

namespace MotivationalAPI.UserServices;

public class PgsDatabase : IDatabase
{
	private const string DATABASE_NAME = "sharpenDB";


	private const string CONNECTION_STRING =
		$"Host=sharpenthesawsql.postgres.database.azure.com;Port=5432;Username=sharpenthesaw;Password=neprash1!;Database={DATABASE_NAME};SearchPath=public;";

	private NpgsqlConnection _connection;

	public Task AddUser(User user, UserInput userInput)
	{
		throw new NotImplementedException();
	}

	public async Task<List<User>> GetAllUsers()
	{
		_connection = new NpgsqlConnection(CONNECTION_STRING);
		Console.WriteLine(CONNECTION_STRING);
		_connection.Open();
		string commandText =
			$"SELECT id   AS Id," +
			$"\n   username AS Username," +
			$"     email AS Email," +
			$"     password_hash AS Password," +
			$"\n   role AS Role," +
			$"\n   lifepoint AS Lifepoints," +
			$"\n   weedstones AS Weedstones" +
			$"\n FROM public.users  " +
			$"ORDER BY id";
		var users = _connection.Query<User>(commandText);
		await _connection.CloseAsync();
		return users.ToList();
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

	public async Task<User> GetUserLifePoints(int id)
	{
		_connection = new NpgsqlConnection(CONNECTION_STRING);
		_connection.Open();
		string commandText =
			$"SELECT id   AS Id," +
			$"\n   username AS Username," +
			$"     email AS Email," +
			$"     password_hash AS Password," +
			$"\n   role AS Role," +
			$"\n   lifepoint AS Lifepoints," +
			$"\n   weedstones AS Weedstones" +
			$"\n FROM public.users  " +
			$"\n WHERE id = @Id";
		var points = await _connection.QuerySingleOrDefaultAsync<User>(commandText, new
		{ Id = id });
		await _connection.CloseAsync();
		return points;
	}

	public async Task<User> SetUserLifePoints(int id, UserInput userInput)
	{
		_connection = new NpgsqlConnection(CONNECTION_STRING);
		_connection.Open();
		Console.WriteLine(userInput.Lifepoints);
		string commandText =
			$" UPDATE users  SET  " +
			$"\n   lifepoint = @Lifepoints" +
			$"\n WHERE id = @Id";
		var queryArgs = new
		{ Id = id, Lifepoints = userInput.Lifepoints };
		await _connection.ExecuteAsync(commandText, queryArgs);
		await _connection.CloseAsync();
		return await GetUserLifePoints(id);
	}

	public async Task<User> GetUserWeedStones(int id)
	{
		_connection = new NpgsqlConnection(CONNECTION_STRING);
		_connection.Open();
		string commandText =
			$"SELECT id   AS Id," +
			$"\n   username AS Username," +
			$"     email AS Email," +
			$"     password_hash AS Password," +
			$"\n   role AS Role," +
			$"\n   lifepoint AS Lifepoints," +
			$"\n   weedstones AS Weedstones" +
			$"\n FROM public.users  " +
			$"\n WHERE id = @Id";
		var points = await _connection.QuerySingleOrDefaultAsync<User>(commandText, new
		{ Id = id });
		await _connection.CloseAsync();
		return points;
	}

	public async Task<User> SetUserWeedStones(int id, UserInput userInput)
	{
		_connection = new NpgsqlConnection(CONNECTION_STRING);
		_connection.Open();
		Console.WriteLine(userInput.WeedStones);
		string commandText =
			$" UPDATE users  SET  " +
			$"\n   weedstones = @Weedstones" +
			$"\n WHERE id = @Id";
		var queryArgs = new
		{ Id = id, Weedstones = userInput.WeedStones };
		await _connection.ExecuteAsync(commandText, queryArgs);
		await _connection.CloseAsync();
		return await GetUserWeedStones(id);
	}

	public Task<string> IsUserExists(string name, string password)
	{
		throw new NotImplementedException();
	}	

	public async Task<List<TaskServices.Task>> AddTask(TaskInput taskInput, int userId)
	{
		_connection = new NpgsqlConnection(CONNECTION_STRING);
		_connection.Open();
		string commandText =
			$"WITH id_t AS \n (INSERT INTO tasks ( title) \n VALUES (@Title)\n RETURNING id \n ) \n INSERT INTO user_tasks (user_id, task_id, status) \n SELECT @UserId, id, false FROM  id_t";

		var queryArgs = new
		{ Title = taskInput.Title, UserId = userId };
		await _connection.ExecuteAsync(commandText, queryArgs);
		await _connection.CloseAsync();
		return await GetAllUsersTasks(userId);
	}

	public Task<string> UserLogin(string username, string password)
	{
		throw new NotImplementedException();
	}


	public async Task<List<MotivationalAPI.TaskServices.Task>> GetAllUsersTasks(int id)
	{
		await using var _connection = new NpgsqlConnection(CONNECTION_STRING);
		Console.WriteLine(CONNECTION_STRING);
		await _connection.OpenAsync();
		string commandText =
			$"SELECT f.task_id AS id, z.title,  f.status FROM user_tasks f JOIN tasks z ON f.task_id = z.id \n WHERE f.user_id = @UserId";
		var tasks = await _connection.QueryAsync<TaskServices.Task>(commandText, new { UserId = id });
		await _connection.CloseAsync();
		return tasks.ToList();
	}


	public Task<User> GetTaskById(int id, UserInput userInput)
	{
		throw new NotImplementedException();
	}

	public void UpdateTask(Task task, int id, UserInput userInput)
	{
		throw new NotImplementedException();
	}

	public Task<User> GetTaskById(int id)
	{
		throw new NotImplementedException();
	}


	public void DeleteTask(int id)
	{
		throw new NotImplementedException();
	}
}