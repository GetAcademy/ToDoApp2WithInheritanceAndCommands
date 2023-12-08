namespace ToDoApp.Commands
{
    internal class AddTaskCommand : Command
    {
        public AddTaskCommand(TodoApp todoApp)
        : base(todoApp, "Legg til ny")
        {
        }

        public override void Run()
        {
            var name = AskForString("skriv inn navn:");
            var dateTime = AskForDateTime("Skriv inn når skal den være ferdig (dd/mm/yyyy):")
            _todoApp.AddTask(name, dateTime);

        }
    }
}
