namespace ToDoApp.Commands
{
    internal abstract class Command
    {
        protected TodoApp _todoApp;
        public string Name { get; }
        public abstract void Run();

        protected Command(TodoApp todoApp, string name)
        {
            _todoApp = todoApp;
            Name = name;
        }
    }
}
