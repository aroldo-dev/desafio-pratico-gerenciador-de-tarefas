using TaskManager.Communication.Interface;
using TaskManager.Communication.Model;
using TaskManager.SharedServices.Interface;

namespace TaskManager.Application.Service.Task
{
    public class TaskDeleteService(ITaskDB taskDB) : ITaskDeleteService
    {
        private readonly ITaskDB taskDB = taskDB;

        public bool Execute(int id)
        {
            var currentTask = taskDB.GetTaskDB().Find(task => task.Id == id);
            if(currentTask == null)
                return false;

            taskDB.GetTaskDB().Remove(currentTask);

            return true;
        }
    }
}
