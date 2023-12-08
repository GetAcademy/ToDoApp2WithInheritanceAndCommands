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
            Console.WriteLine("skriv inn navn:");
            var name = Console.ReadLine();
            Console.WriteLine("Skriv inn når skal den være ferdig (dd/mm/yyyy):");
            DateTime dueDate;
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDateFromUser))
            {
                dueDate = dueDateFromUser;
            }
            else
            {
                Console.WriteLine("Ugyldig datoformat. Bruker dagens dato.");
                dueDate = DateTime.Today;
            }
            _todoApp.AddTask(name, dueDate);

        }
    }
}
