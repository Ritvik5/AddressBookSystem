namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookManagement addressBookManager = new AddressBookManagement();

            Console.WriteLine("Welcome to the Address Book Management System");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a new address book");
                Console.WriteLine("2. Add a contact to an address book");
                Console.WriteLine("3. Print contacts from an address book");
                Console.WriteLine("4. Edit a contact in an address book");
                Console.WriteLine("5. Delete a contact from an address book");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the new address book:");
                        string addressBookName = Console.ReadLine();
                        addressBookManager.AddAddressBook(addressBookName);
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of the address book to add a contact to:");
                        string addContactToAddressBook = Console.ReadLine();
                        Console.WriteLine("Enter the contact information:");
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Address: ");
                        string address = Console.ReadLine();
                        Console.Write("City: ");
                        string city = Console.ReadLine();
                        Console.Write("State: ");
                        string state = Console.ReadLine();
                        Console.Write("Zip: ");
                        string zip = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Contacts contact = new Contacts
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Address = address,
                            City = city,
                            State = state,
                            Zip = zip,
                            PhoneNumber = phoneNumber,
                            Email = email
                        };
                        addressBookManager.AddContact(addContactToAddressBook, contact);
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the address book to print contacts from:");
                        string printContactsFromAddressBook = Console.ReadLine();
                        addressBookManager.PrintContacts(printContactsFromAddressBook);
                        break;

                    case 4:
                        Console.WriteLine("Enter the name of the address book to edit a contact in:");
                        string editContactInAddressBook = Console.ReadLine();
                        Console.WriteLine("Enter the first name of the contact to edit:");
                        string firstNameToEdit = Console.ReadLine();
                        Console.WriteLine("Enter the last name of the contact to edit:");
                        string lastNameToEdit = Console.ReadLine();
                        addressBookManager.EditContact(editContactInAddressBook, firstNameToEdit, lastNameToEdit);
                        break;

                    case 5:
                        Console.WriteLine("Enter the name of the address book to delete a contact from:");
                        string deleteContactFromAddressBook = Console.ReadLine();
                        Console.WriteLine("Enter the first name of the contact to delete:");
                        string firstNameToDelete = Console.ReadLine();
                        Console.WriteLine("Enter the last name of the contact to delete:");
                        string lastNameToDelete = Console.ReadLine();
                        addressBookManager.DeleteContact(deleteContactFromAddressBook, firstNameToDelete, lastNameToDelete);
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }


}
