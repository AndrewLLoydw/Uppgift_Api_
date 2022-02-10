namespace Uppgift_Api_.Models.Update
{
    public class ProductUpdate
    {
        public ProductUpdate(int productNumber, string productName, string productDescription, decimal productPrice )
        {
            ProductNumber = productNumber;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductPrice = productPrice;
        }

        public int ProductNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
