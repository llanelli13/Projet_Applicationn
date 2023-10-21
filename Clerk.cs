using System;
using System.Collections.Generic;


class Clerk {
    public string Name { get; set; }
    public List<Customer> customers { get; private set; }
    public Clerk( string name)
    {
        this.Name = name;
        this.customers = new List<Customer>();
    }


    public void CheckingCustomer(){
        Console.WriteLine("Welcome to our restaurant !");
        Console.Write("Is it your first order in our restaurant ? Y/N");
        string isFirstOrder = Console.ReadLine();
        if (isFirstOrder.ToLower() == "y"){
            Customer customer = new Customer();
            Console.WriteLine("What is your first name ?");
            customer.firstname = Console.ReadLine();
            Console.WriteLine("What is your last name ?");
            customer.surname = Console.ReadLine();
            Console.WriteLine("What is your address ?");
            customer.address = Console.ReadLine();
            Console.WriteLine("What is your phone number?");
            customer.phone = Console.ReadLine();
        }
        else if (isFirstOrder.ToLower() == "n"){
            Console.WriteLine("What is your phone number ?");
            string phoneNumber = Console.ReadLine();
            Customer DoesCustomerExist = customers.Find(c => c.phone == phoneNumber);

            if (DoesCustomerExist != null){
                Console.WriteLine($"Welcome back, {DoesCustomerExist.firstname} {DoesCustomerExist.surname}");
                Console.WriteLine($"Can you confirm that your address is {DoesCustomerExist.address} ? Y/N");
            }
            else {
                Console.WriteLine("Customer not found, please enter your details");
            }
        }else{
            Console.WriteLine("Invalid input");
        }
    }

    public void MakingOrder(){

    }
}