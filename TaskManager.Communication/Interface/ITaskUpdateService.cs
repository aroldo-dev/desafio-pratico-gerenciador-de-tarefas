using TaskManager.Communication.Model;
using TaskManager.Communication.Request;

namespace TaskManager.Communication.Interface;

public interface ITaskUpdateService
{
    public TMTask? Execute(int id,TMTaskJSON taskJson);
}
