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

                Console.Write("Add another contact? (y/n) ");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("\nAddress Book:");
            myAddressBook.PrintContacts();
        }
    }
}