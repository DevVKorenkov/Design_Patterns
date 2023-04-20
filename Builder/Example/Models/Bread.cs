using System.Text;

namespace Builder.Example.Models;

public class Bread
{
    public Flour Flour { get; set; }
    public Salt Salt { get; set; }
    public Additives Additives { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        if(Flour != null)
        {
            sb.Append(Flour.Sort + "\n");
        }
        if(Salt != null)
        {
            sb.Append("Salt \n");
        }
        if(Additives != null)
        {
            sb.Append($"Additives: {Additives.Name} \n");
        }

        return sb.ToString();
    }
}
