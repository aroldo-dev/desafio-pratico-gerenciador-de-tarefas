using TaskManager.Communication.Interface;
using TaskManager.Communication.Model;
using TaskManager.SharedServices.Interface;

namespace TaskManager.Application.Service.Task
{
    public class TaskGetService(ITaskDB taskDB) : ITaskGetService
    {
        private readonly ITaskDB taskDB = taskDB;

        public TMTask? Execute(int id)
        {
            var currentTask = taskDB.GetTaskDB().Find(task => task.Id == id);
            return currentTask;
        }
    }
}
