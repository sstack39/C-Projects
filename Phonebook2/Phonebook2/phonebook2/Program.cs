/*
Name: Sean Stack
COP2360 - Assignment 9 - Phonebook Application 2
Sept 21, 2024
Collaboration Statement: I worked on this alone.
 */


namespace phonebook2
{
    //establish as internal class 
    internal class Program
    {
        //initialize list for phone book entries for user to input and store data.
        public static List<PhoneBookEntry> phoneBookEntries = new();
        static void Main(string[] args)
        {
            string fileName = "phonebook.txt";
            //utilize while loop to operate through menu options for user
            while (true)

            {
                Console.WriteLine(" ");
                Console.WriteLine("Phone Book Menu:");

                Console.WriteLine("1. Add Name");

                Console.WriteLine("2. View Names");

                Console.WriteLine("3. Exit");

                Console.WriteLine(" ");

                Console.Write("Please enter your choice: ");

                string userInput = Console.ReadLine();
                //utilize switch case in order to properly organize stored data within the phonebook entry list
                switch (userInput)

                {

                    case "1":

                        AddName(fileName);

                        break;

                    case "2":

                        ViewNames(fileName);

                        break;

                    case "3":

                        Environment.Exit(0);

                        break;
                    //incorporate error handling within phonebook entry user interface for user.
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Invalid choice. Please try again.");

                        break;

                }

            }
        }

        static void AddName(string fileName)

        {
            //display stored entries to user upon request
            Console.WriteLine(" ");
            Console.Write("Enter name: ");

            string name = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Enter phone number: ");

            string phoneNumber = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Enter contact type - personal (0), business (1), etc (2): ");
            
            int result;
            while (int.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("invalide contact type");
                Console.ReadLine();
            }
            PhoneBookEntry entry = new PhoneBookEntry(name, phoneNumber, (PhoneBookEntry.ContactType)result);
            phoneBookEntries.Add(entry);

            //utilize streamwriter and streamreader attributes for propery file management
            using (StreamWriter writer = new StreamWriter(fileName, true))

            {

                writer.WriteLine($"{name}\t{phoneNumber}\t{result}");

            }

            Console.WriteLine(" ");
            Console.WriteLine("Name added successfully!");

        }

        static void ViewNames(string fileName)

        {

            if (!File.Exists(fileName))

            {

                Console.WriteLine("Phone book is empty.");

                return;

            }

            Console.WriteLine(" ");
            Console.WriteLine("Phone Book Entries: ");
            phoneBookEntries = new();
            using (StreamReader reader = new StreamReader(fileName))

            {

                string line;
                //utilize while loop to properly format entries to be stored and display within the text file
                while ((line = reader.ReadLine()) != null)

                {
                    string Name = line.Split('\t')[0];
                    string PhoneNumber = line.Split('\t')[1];
                    string ContactType = line.Split('\t')[2];
                    int result;
                    if (int.TryParse(ContactType, out result) == false)
                    {
                        result = 0;
                    }
                    PhoneBookEntry entry = new(Name, PhoneNumber, (PhoneBookEntry.ContactType)result);
                    phoneBookEntries.Add(entry);

                    Console.WriteLine($"{entry.Name}\t{entry.PhoneNumber}\t{entry.EntryType}");

                }

            }

        }
    }
}
