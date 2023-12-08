namespace ToDoApp.Commands
{
    internal class MarkTaskAsDoneCommand : Command
    {
        public MarkTaskAsDoneCommand(TodoApp todoApp) 
            : base(todoApp, "Marker fullført")
        {
        }

        public override void Run()
        {
            var taskNo = AskForInt("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven) ");
            if (taskNo < 1 || taskNo > _todoApp.GetCount())
            {
                Console.WriteLine("Skriv inn et gyldig tall");
            }
            else
            {
                _todoApp.MarkDone(taskNo);
            }
        }
    }
}
