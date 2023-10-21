class Program{

    static void Main(){
        Clerk2 c1 = new Clerk2("Pierre");
        Customer custom = new Customer("Pierre","REY", "10b av JB Fortin", "0689883338");
        c1.AddCustomer(custom);
        c1.CheckingCustomer();
    }
}