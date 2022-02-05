using System;

namespace Lab2
{ 
    class StockItem
    {
        private string description;
        private int ID = 1;
        private double price;
        private int quantity;
        private int lowerPrice;
        private int lowerQuantity;

        Random rnd = new Random();
        public string getDescription()
        {
            return description;
        }
        public string getID()
        {
            return ID;
        }
        public string getPrice()
        {
            return price;
        }
        public string getQuantity()
        {
            return quantity;
        }
        public void setDescription(string newDate)
        {
            description = newdescription;
        }
        public void setID(string newID)
        {
            ID = newID
        }
        public void setPrice(double newPrice)
        {
            if(newPrice < 0.0)
            {
                Console.WriteLine("price is below zero: error");
            }
            else 
            {
                price = newPrice
            }
        }
        public void setQuantity(int newQuantity){
            if(newPrice < 0.0)
            {
                Console.WriteLine("price is below zero: error");
            }
            else 
            {
                quantity = newQuantity
            }
        }
        static void Main(string[] args)
        {
            
        }
        public stockItem (string description, int ID, double price, int quantity)
        {
            this.description = description;
            this.ID = ID;
            this.price = price;
            this.quantity = quantity;
            price = lowerPrice;
            quantity = lowerQuantity;
        }
        public stockItem (string description, double price, int quantity)
        {
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
        stockItem milk = new stockItem("1 gallon of milk", 3.60, 15);
        stockItem bread = new stockItem("1 loaf of bread", 1.98, 30);
        
        public override string toString()
        {
            return "Description: " + description + "ID: " + ID + "Price: " + price + "Quantity: " + Quantity
        }
        public displayMenu()
        {
            Console.WriteLine("1. Sold one Milk");
            Console.WriteLine("2. Sold one Bread");
            Console.WriteLine("3. Change price of Milk");
            Console.WriteLine("4. Change price of Bread");
            Console.WriteLine("5. Add milk to Inventory");
            Console.WriteLine("6. Add Bread to Inventory");
            Console.WriteLine("7. See Inventory");
            Console.WriteLine("8. Quit");
            
        }
        int input = Console.ReadLine();
        
    }
}