using System;

namespace Problem_2._Print_Company_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            Company company = new Company(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), new Manager(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
            Console.WriteLine(company.ToString());

        }
    }
    public class Company
    {
        private string name;
        private string address;
        private string phoneNumber;
        private string faxNumber;
        private string website;
        private Manager manager;

        public Company(string name, string address, string phoneNumber, string faxNumber, string website, Manager manager)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.faxNumber = faxNumber;
            this.website = website;
            this.manager = manager;
        }

        public override string ToString()
        {
            
            return String.Format("Company name : {0}{1}Company Address: {2}{1}Company Number: {3}{1}Company Fax: {4}{1}Company Website: {5}{1}Company Manager: {6}{1}Manager Number: {7}", name, Environment.NewLine, address, phoneNumber, faxNumber, website, manager.getName(), manager.getPhoneNumber());
        }
    }

    public class Manager
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public Manager(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public string getName()
        {
            return this.firstName + " " + lastName;
        }
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
