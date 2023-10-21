class Customer {
    
    public string firstname {get; set;}
    public string surname {get; set;}
    public string address {get; set;}
    public string phone {get;set;}
    public DateTime FirstOrderDate {get; set;}

    public Customer(string firstname, string surname, string address, string phone){
        this.firstname = firstname;
        this.surname = surname;
        this.address = address;
        this.phone = phone;
        this.FirstOrderDate = DateTime.Now;
    }
    public Customer(){}

}