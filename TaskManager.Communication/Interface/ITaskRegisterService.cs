using TaskManager.Communication.Model;
using TaskManager.Communication.Request;

namespace TaskManager.Communication.Interface;

public interface ITaskRegisterService
{
    public TMTask Execute(TMTaskJSON taskJson);
}
