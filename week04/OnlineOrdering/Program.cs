using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        // --- Order 1: USA Customer ---
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM-001", 29.99, 2));
        order1.AddProduct(new Product("USB-C Hub", "UC-204", 45.50, 1));
        order1.AddProduct(new Product("Laptop Stand", "LS-309", 34.00, 1));
        orders.Add(order1);

        // --- Order 2: International Customer ---
        Address address2 = new Address("10 Downing Street", "London", "England", "UK");
        Customer customer2 = new Customer("James Bond", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Mechanical Keyboard", "MK-512", 89.99, 1));
        order2.AddProduct(new Product("Monitor Light Bar", "ML-007", 39.99, 2));
        orders.Add(order2);

        // --- Order 3: USA Customer ---
        Address address3 = new Address("1600 Pennsylvania Ave NW", "Washington", "DC", "USA");
        Customer customer3 = new Customer("Clark Kent", address3);
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Webcam HD 1080p", "WC-720", 59.99, 1));
        order3.AddProduct(new Product("Desk Organizer", "DO-101", 19.99, 3));
        orders.Add(order3);

        // Display all orders
        foreach (Order order in orders)
        {
            order.Display();
        }
    }
}