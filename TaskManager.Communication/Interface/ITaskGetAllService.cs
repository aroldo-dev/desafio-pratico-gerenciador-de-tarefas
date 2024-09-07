using TaskManager.Communication.Model;

namespace TaskManager.Communication.Interface;

public interface ITaskGetAllService
{
    public List<TMTask> Execute();
}
