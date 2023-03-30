namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Addess Book ");
            Console.WriteLine("\n**************\n");

            AddressBook myAddressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Edit an existing contact");
                Console.WriteLine("3. Print all contacts");
                Console.WriteLine("4. Delete existing contacts");
                Console.WriteLine("5. Quit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter contact information:");

                        Contacts newContact = new Contacts();

                        Console.Write("First Name: ");
                        newContact.FirstName = Console.ReadLine();

                        Console.Write("Last Name: ");
                        newContact.LastName = Console.ReadLine();

                        Console.Write("Address: ");
                        newContact.Address = Console.ReadLine();

                        Console.Write("City: ");
                        newContact.City = Console.ReadLine();

                        Console.Write("State: ");
                        newContact.State = Console.ReadLine();

                        Console.Write("Zip: ");
                        newContact.Zip = Console.ReadLine();

                        Console.Write("Phone Number: ");
                        newContact.PhoneNumber = Console.ReadLine();

                        Console.Write("Email: ");
                        newContact.Email = Console.ReadLine();

                        myAddressBook.AddContact(newContact);
                        Console.WriteLine("Contact added.");
                        break;

                    case "2":
                        Console.WriteLine("Enter the name of the contact to edit:");

                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();

                        myAddressBook.EditContact(firstName, lastName);
                        break;

                    case "3":
                        myAddressBook.PrintContacts();
                        break;

                    case "4":
                        Console.WriteLine("Enter the name of the contact to delete:");

                        Console.Write("First Name: ");
                        string deleteFirstName = Console.ReadLine();

                        Console.Write("Last Name: ");
                        string deleteLastName = Console.ReadLine();

                        myAddressBook.DeleteContact(deleteFirstName, deleteLastName);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
