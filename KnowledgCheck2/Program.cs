namespace KnowledgCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<HandBag>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var handBag = new HandBag();

                Console.WriteLine("Enter the price of the purse ");
                handBag.Price = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Brand of the purse ");
                handBag.Brand = Console.ReadLine();

                Console.WriteLine("Enter the Quantity of purses ");
                handBag.Quantity = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the purse description ");
                handBag.Description = Console.ReadLine();

                Console.WriteLine("is this a purse?(yes/no) ");
                handBag.Purse = Console.ReadLine();


                recordList.Add(handBag);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var handBag in recordList)
            {
                Console.WriteLine(handBag);
            }

        }

        public class Products
        {
            public string Brand { get; set; }
            public string Description { get; set; }
            public int Quantity { get; set; }
            public decimal Price  { get; set; }

            public override string ToString()
            {
                return $"Brand: {Brand}, Description: {Description}, Quantity: {Quantity}, Price: {Price} ";
            }

        }

        public class HandBag : Products
        {
            public string Purse { get; set; }

            public override string ToString()
            {
                return base.ToString() + $"Purse: {Purse}";
            }
        }
    }


}
