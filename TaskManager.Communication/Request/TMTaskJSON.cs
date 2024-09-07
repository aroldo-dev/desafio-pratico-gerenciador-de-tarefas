using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Request
{
    public class TMTaskJSON
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public PriorityEnum Priority { get; set; }
        public DateTime Deadline { get; set; }
        public StatusEnum Status { get; set; }
    }
}
