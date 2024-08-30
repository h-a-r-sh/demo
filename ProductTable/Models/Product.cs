namespace ProductTable.Models
{
    public class Product  //ORM  implementing orm principle with code first app(class -->> table)
{
    public int ProductID { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public int ProductPrice { get; set; }
}
}