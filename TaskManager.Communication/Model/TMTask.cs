using TaskManager.Communication.Enum;

namespace TaskManager.Communication.Model
{
    public class TMTask
    {
        //Uma tarefa deverá ter os seguintes campos:
        //- Um id único pra identificar cada tarefa;
        public int Id { get; set; }
        //- Um nome;
        public string Name { get; set; } = string.Empty;
        //- Uma descrição sobre o que é a tarefa em si;
        public string Description { get; set; } = string.Empty;
        //- Uma prioridade;
        //*Você pode definir se tem prioridade* `alta`, `média` *ou* `baixa`*, por exemplo;*
        public PriorityEnum Priority { get; set; }
        //- Uma data limite para tarefa ser realizada;
        public DateTime Deadline { get; set; }
        //- Um status.
        //*Você pode definir três status:* `concluída`*,* `em andamento` *e* `aguardando`*, por exemplo.*
        public StatusEnum Status { get; set; }


    }
}
