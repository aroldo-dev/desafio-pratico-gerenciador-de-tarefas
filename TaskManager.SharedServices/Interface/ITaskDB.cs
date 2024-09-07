using TaskManager.Communication.Model;

namespace TaskManager.SharedServices.Interface
{
    public interface ITaskDB
    {
        public List<TMTask> GetTaskDB();
    }
}
