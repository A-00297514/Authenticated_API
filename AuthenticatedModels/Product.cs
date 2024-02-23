namespace AuthenticatedModels;

public class Product
{
    public int Id {get; set;}
    public decimal Price {get; set;}
    public string? Name {get;set;}
    public string? Description {get;set;}

    public required Category Category{get;set;}

}
