namespace BlazorApp4.Data;

public class BoxModel
{
    public int id { get; set; }
    public string name { get; set; }
    public List<Item> items { get; set; }
    
    public BoxModel(int id, string name, List<Item> items)
    {
        this.id = id;
        this.name = name;
        this.items = items;
    }

    public BoxModel(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}