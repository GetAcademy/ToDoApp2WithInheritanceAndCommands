using System.Xml.Linq;

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
            Console.WriteLine("Hvilken oppgave vil du markere fullført? (skriv inn nr til oppgaven)");
            var taskNoStr = Console.ReadLine();
            var taskNo = Convert.ToInt32(taskNoStr);
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
