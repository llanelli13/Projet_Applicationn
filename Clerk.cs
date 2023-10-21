class Clerk {
    public string Name { get; set; }
    public int ClerkID { get; private set; }

    public Clerk(int clerkID, string name)
    {
        this.ClerkID = clerkID;
        this.Name = name;
    }
}