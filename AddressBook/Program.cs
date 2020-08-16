using System;
using System.ComponentModel.Design;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            PersonService personService = new PersonService();
            actionService = Initialize(actionService);

            Console.WriteLine("Welcome to AddressBook!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");

                var mainMenu = actionService.GetMenuActionByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                Console.Write($"Select an option from 1 to {mainMenu.Count}: ");

                var operation = Console.ReadKey();   

                Console.WriteLine();

                switch (operation.KeyChar)
                {
                    case '1':
                        var id = personService.AddNewPerson();
                        break;
                    case '2':
                        var detailId = personService.PersonDetailSelectionView();
                        personService.DetailPersonView(detailId);
                        break;
                    case '3':
                        personService.AllPersonsView();
                        break;
                    case '4':
                        var removeId = personService.RemovePersonView();
                        personService.RemovePerson(removeId);
                        break;
                    default:
                        Console.WriteLine("Action you entered does not exist!");
                        break;
                }
            }
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add contact", "Main");
            actionService.AddNewAction(2, "Show details of contact", "Main");
            actionService.AddNewAction(3, "List of contacts", "Main");
            actionService.AddNewAction(4, "Remove contact", "Main");

            return actionService;
        }
    }
}
