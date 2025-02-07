using System.Text;

var builder = new HtmlBuilder("ul")
    .AddChild("li", "Sardor")
    .AddChild("li", "Sarvar")
    .AddChild("li", "Sanjar");

Console.WriteLine(builder.ToString());
//< ul >
//    < li > Sardor </ li >
//    < li > Sarvar </ li >
//    < li > Sarjar </ li >
//</ ul >

class HtmlElement
{
    public string Name { get; }
    public string Text { get; set; }
    public List<HtmlElement> Children { get; } = new List<HtmlElement>();

    public HtmlElement(string name, string text = "")
    {
        Name = name;
        Text = text;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"<{Name}>{Text}");
        foreach (var child in Children)
        {
            sb.Append(child.ToString());
        }
        sb.Append($"</{Name}>");
        return sb.ToString();
    }
}

class HtmlBuilder
{
    private HtmlElement root;

    public HtmlBuilder(string rootName)
    {
        root = new HtmlElement(rootName);
    }

    public HtmlBuilder AddChild(string childName, string childText)
    {
        root.Children.Add(new HtmlElement(childName, childText));
        return this;
    }

    public override string ToString() => root.ToString();
}