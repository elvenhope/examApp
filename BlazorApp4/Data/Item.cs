namespace BlazorApp4.Data;

public class Item
{
    public string name = "";
    public int boxId;
    public string imgLink = "";

    public Item(string name, int boxId, string imgLink)
    {
        this.name = name;
        this.boxId = boxId;
        this.imgLink = imgLink;
    }
}