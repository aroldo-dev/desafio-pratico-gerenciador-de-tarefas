using TaskManager.Communication.Interface;
using TaskManager.Communication.Model;
using TaskManager.SharedServices.Interface;

namespace TaskManager.Application.Service.Task
{
    public class TaskGetAllService(ITaskDB taskDB) : ITaskGetAllService
    {
        private readonly ITaskDB taskDB = taskDB;

        public List<TMTask> Execute()
        {
            return taskDB.GetTaskDB();
        }
    }
}
