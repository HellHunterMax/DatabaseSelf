namespace DatabaseSelf.Data.Entities;

public class Blog
{
    public int BlogId { get; set; }
    public string Url { get; set; }
    public string MyProperty1 { get; set; }
    public string MyProperty2 { get; set; }
    public string MyProperty3 { get; set; }
    public string MyProperty4 { get; set; }
    public string MyProperty5 { get; set; }
    public string MyProperty6 { get; set; }
    public string MyProperty7 { get; set; }
    public string MyProperty8 { get; set; }
    public string MyProperty9 { get; set; }
    public string MyProperty10 { get; set; }

    public List<Post> Posts { get; } = new();
}
