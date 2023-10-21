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
        // Customer's first order
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
            AddCustomer(customer);
            MakingOrder();
            
        }
        // Customer has already order in our restaurant
        else if (isFirstOrder.ToLower() == "n"){
            Console.WriteLine("What is your phone number ?");
            string phoneNumber = Console.ReadLine();
            Customer DoesCustomerExist = customers.Find(c => c.phone == phoneNumber);

            if (DoesCustomerExist != null){
                Console.WriteLine($"Welcome back, {DoesCustomerExist.firstname} {DoesCustomerExist.surname}");
                Console.WriteLine($"Can you confirm that your address is : {DoesCustomerExist.address} ? Y/N");
                string addressCorrect = Console.ReadLine();
                if (addressCorrect.ToLower()=="y"){
                    MakingOrder();
                }else if (addressCorrect.ToLower()=="n"){
                    Console.WriteLine("Address is incorrect");
                }
            }
            else {
                Console.WriteLine("Customer not found, please enter your details");
            }
        }else{
            Console.WriteLine("Invalid input");
        }
    }

    public void MakingOrder(){
        Console.WriteLine("Je fais la commande");
        List<object> itemList = new List<object>();

        Console.WriteLine("Quelle type de pizza voulez vous ?");
        string ans_type = Console.ReadLine();
        itemList.Add(ans_type);

        Console.WriteLine("Très bien, en quelle taille la voulez-vous ?");
        Console.WriteLine("1. Large");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Small");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    itemList.Add(Pizza.Size.Large);
                    break;
                case 2:
                    itemList.Add(Pizza.Size.Medium);
                    break;
                case 3:
                    itemList.Add(Pizza.Size.Small);
                    break;
                default:
                    Console.WriteLine("Choix invalide. La taille sera réglée sur Medium.");
                    itemList.Add(Pizza.Size.Medium);
                    break;
            }
        }

        Console.WriteLine("Voulez-vous une boisson avec ceci ?");
        Console.WriteLine("1. Oui");
        Console.WriteLine("2. Non");

        int drinkChoice;
        if (int.TryParse(Console.ReadLine(), out drinkChoice))
        {
            if (drinkChoice == 1)
            {
                Console.WriteLine("Choisissez une boisson :");
                Console.WriteLine("1. Eau");
                Console.WriteLine("2. Coca");
                Console.WriteLine("3. Ice Tea");
                Console.WriteLine("4. Fanta");

                int drinkSelection;
                if (int.TryParse(Console.ReadLine(), out drinkSelection))
                {
                    switch (drinkSelection)
                    {
                        case 1:
                            itemList.Add(new Drink(Drink.DrinkName.Water));
                            break;
                        case 2:
                            itemList.Add(new Drink(Drink.DrinkName.Coca));
                            break;
                        case 3:
                            itemList.Add(new Drink(Drink.DrinkName.IceTea));
                            break;
                        case 4:
                            itemList.Add(new Drink(Drink.DrinkName.Fanta));
                            break;
                        default:
                            Console.WriteLine("Boisson invalide. Aucune boisson ajoutée.");
                            break;
                    }
                }
            }
        }
    }

    public void AddCustomer(Customer customer){
        customers.Add(customer);
        Console.WriteLine("Customer ajouté");
    }
}