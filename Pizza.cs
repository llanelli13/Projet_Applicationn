class Pizza {
    public string Type { get; private set; }
    public Size PizzaSize { get; private set; }
    public double Price { get; private set; }

    public Pizza(Size size) {
        this.PizzaSize = size;
        switch (size) {
            case Size.Large:
                Price = 19.99;
                break;
            case Size.Medium:
                Price = 14.99;
                break;
            case Size.Small:
                Price = 9.99;
                break;
        }
    }

    public enum Size {
        Large,
        Medium,
        Small
    }
}
