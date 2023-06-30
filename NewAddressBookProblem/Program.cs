namespace NewAddressBookProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact("Pooja", "Date", "Panchvati", "Nashik", "MH", "datepooja07@gmail.com", 422003,7040613418);
            addressBook.ViewContact();
        }
    }
}