using TaskManager.Communication.Interface;
using TaskManager.Communication.Model;
using TaskManager.Communication.Request;
using TaskManager.SharedServices.Interface;

namespace TaskManager.Application.Service.Task
{
    public class TaskUpdateService(ITaskDB taskDB) : ITaskUpdateService
    {
        private readonly ITaskDB taskDB = taskDB;

        public TMTask? Execute(int id, TMTaskJSON task)
        {
            var currentTask = taskDB.GetTaskDB().Find(task => task.Id == id);
            if(currentTask == null)
                return null;

            currentTask.Name = task.Name;
            currentTask.Description = task.Description;
            currentTask.Priority = task.Priority;
            currentTask.Deadline = task.Deadline;
            currentTask.Status = task.Status;

            return currentTask;
        }
    }
}
