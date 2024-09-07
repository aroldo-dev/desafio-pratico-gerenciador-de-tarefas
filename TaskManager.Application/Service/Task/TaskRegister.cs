using TaskManager.Communication.Interface;
using TaskManager.Communication.Model;
using TaskManager.Communication.Request;
using TaskManager.SharedServices.Interface;

namespace TaskManager.Application.Service.Task
{
    public class TaskRegister(ITaskDB taskDB) : ITaskRegisterService
    {
        private readonly ITaskDB taskDB = taskDB;

        public TMTask Execute(TMTaskJSON taskJson)
        {
            var newTask = new TMTask
            {
                Id = taskDB.GetTaskDB().Count + 1,
                Name = taskJson.Name,
                Description = taskJson.Description,
                Priority = taskJson.Priority,
                Deadline = taskJson.Deadline,
                Status = taskJson.Status
            };

            taskDB.GetTaskDB().Add(newTask);

            return newTask;
        }
    }
}
