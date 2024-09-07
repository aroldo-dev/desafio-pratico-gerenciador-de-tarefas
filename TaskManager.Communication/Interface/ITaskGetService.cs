using TaskManager.Communication.Model;

namespace TaskManager.Communication.Interface;

public interface ITaskGetService
{
    public TMTask? Execute(int id);
}
