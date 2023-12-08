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

        protected static int AskForInt(string question)
        {
            var answer = AskForString(question);
            return Convert.ToInt32(answer);
        }

        protected static DateTime AskForDateTime(string question)
        {
            var answer = AskForString(question);
            DateTime dueDate;
            if (DateTime.TryParse(answer, out DateTime dueDateFromUser))
            {
               return dueDateFromUser;
            }
            else
            {
                Console.WriteLine("Ugyldig datoformat. Bruker dagens dato.");
                return DateTime.Today;
            }
        }

        protected static string AskForString(string question)
        {
            Console.Write(question);
            var answer = Console.ReadLine();
            return answer;
        }
    }
}
