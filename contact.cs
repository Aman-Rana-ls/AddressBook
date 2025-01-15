using System;
using System.Collections.Generic;

namespace AddressBookUc
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        public static void DisplayContacts(string bookName)
        {
            if (addressBooks.ContainsKey(bookName))
            {
                var contacts = addressBooks[bookName];
                if (contacts.Count == 0)
                {
                    Console.WriteLine("No contacts to display.");
                    return;
                }

                foreach (var contact in contacts)
                {
                    Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                    Console.WriteLine($"Address: {contact.Address}, {contact.City}, {contact.State}, {contact.Zip}");
                    Console.WriteLine($"Phone: {contact.PhoneNumber}");
                    Console.WriteLine($"Email: {contact.Email}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Address Book not found.");
            }
        }

        public static void EditContact(string bookName)
        {
            if (addressBooks.ContainsKey(bookName))
            {
                var contacts = addressBooks[bookName];
                Console.Write("Enter First Name of contact to edit: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Last Name of contact to edit: ");
                string lastName = Console.ReadLine();

                Contact contactToEdit = null;
                foreach (var contact in contacts)
                {
                    if (contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase))
                    {
                        contactToEdit = contact;
                        break;
                    }
                }

                if (contactToEdit == null)
                {
                    Console.WriteLine("Contact not found.");
                    return;
                }

                bool edit = true;
                while (edit)
                {
                    Console.WriteLine("Select the detail to edit:");
                    Console.WriteLine("1. First Name");
                    Console.WriteLine("2. Last Name");
                    Console.WriteLine("3. Address");
                    Console.WriteLine("4. City");
                    Console.WriteLine("5. State");
                    Console.WriteLine("6. Zip");
                    Console.WriteLine("7. Phone Number");
                    Console.WriteLine("8. Email");
                    Console.WriteLine("9. Exit Editing");

                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("New First Name: ");
                            contactToEdit.FirstName = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("New Last Name: ");
                            contactToEdit.LastName = Console.ReadLine();
                            break;
                        case "3":
                            Console.Write("New Address: ");
                            contactToEdit.Address = Console.ReadLine();
                            break;
                        case "4":
                            Console.Write("New City: ");
                            contactToEdit.City = Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("New State: ");
                            contactToEdit.State = Console.ReadLine();
                            break;
                        case "6":
                            Console.Write("New Zip: ");
                            contactToEdit.Zip = Console.ReadLine();
                            break;
                        case "7":
                            Console.Write("New Phone Number: ");
                            contactToEdit.PhoneNumber = Console.ReadLine();
                            break;
                        case "8":
                            Console.Write("New Email: ");
                            contactToEdit.Email = Console.ReadLine();
                            break;
                        case "9":
                            edit = false;
                            continue;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            continue;
                    }

                    Console.WriteLine("Contact updated successfully.");
            }
        }

}
}