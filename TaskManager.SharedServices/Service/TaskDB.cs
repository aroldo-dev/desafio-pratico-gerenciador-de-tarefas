using TaskManager.Communication.Model;
using TaskManager.SharedServices.Interface;

namespace TaskManager.SharedServices
{
    public class TaskDB : ITaskDB
    {
        private readonly List<TMTask> tasks;
        public TaskDB() {
            tasks = [];
        }
        public List<TMTask> GetTaskDB()
        {
            return tasks;
        }
    }
}
