using TaskManager.Communication.Model;
using TaskManager.Communication.Request;

namespace TaskManager.Communication.Interface;

public interface ITaskDeleteService
{
    public bool Execute(int id);
}
