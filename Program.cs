class Program{

    static void Main(){
        Clerk c1 = new Clerk("Pierre");
        Customer custom = new Customer("Pierre","REY", "10b av JB Fortin", "0689883338");
        c1.CheckingCustomer();
    }
}