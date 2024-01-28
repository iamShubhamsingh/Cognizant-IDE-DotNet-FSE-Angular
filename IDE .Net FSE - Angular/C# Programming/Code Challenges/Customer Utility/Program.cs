using System;
using System.Collections.Generic;

/** DO NOT alter/delete this partial code snippet. This is given for your reference **/
public class Customer
{
    int id;
    string name;
    string City;

    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return Id + " " + Name + " " + City;
    }
} 

public class CustomerUtility
{
    public List<Customer> CustList { get; set; }

    public CustomerUtility()
    {
        CustList = new List<Customer>();
    }

    public List<Customer>AddCustomer(Customer customer)
    {
        CustList.Add(customer);
        return CustList;
    }

    public Customer SearchCustomerByID(int customerId)
    {
        return CustList.Find(char => char.Id == customerId);
    }

    public void DisplayAllCustomers()
    {
        foreach(var customer in CustList)
        {
            Console.WriteLine($"{customer.Id} {customer.Name} {customer.City}");
        }
    }

    public void DeleteCustomer(int customerId)
    {
        CustList.RemoveAll(char => char.Id == customerId);
    }
}

public class Program
{
    static void Main()
    {
        CustomerUtility customerUtility = new CustomerUtility();

        while(true)
        {
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Display Customer");
            Console.WriteLine("3. Search Customer");
            Console.WriteLine("4. Delete Customer");
            Console.WriteLine("Enter Your Choice");

            string choice = Console.ReadLine();
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter Customer id, name, and city");
                    int id = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    string city = Console.ReadLine();
                    Customer newCustomer = new Customer {Id = id, Name = name, City = city};
                    customerUtility.AddCustomer(newCustomer);
                    break;
                case 2:
                    customerUtility.DisplayAllCustomers();
                    break;
                case 3:
                    Console.WriteLine("Enter Customer id to search");
                    int searchId = Convert.ToInt32(Console.ReadLine());
                    Customer searchedCustomer = customerUtility.SearchCustomerByID(searchId);
                    if(searchedCustomer != null)
                    {
                        Console.WriteLine($"{SearchedCustomer.Id} {SearchedCustomer.Name} {SearchedCustomer.City}");
                    }
                    else{
                        Console.WriteLine("Customer not found");
                    }
                    break;
                case 4:
                    Console.WriteLine("Enter Customer id to delete");
                    int deleteId = Convert.ToInt32(Console.ReadLine());
                    customerUtility.DeleteCustomer(deleteId);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine("Enter your choice");
        }
    }
}