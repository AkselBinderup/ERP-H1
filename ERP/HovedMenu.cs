using TECHCOOL.UI;

namespace ERP;

public class MainMenu : Screen
{
    public override string Title { get; set; } = "LNE Security A/S";

    protected override void Draw()
    {
        Menu menu = new();
        menu.Add(new VirksomhedStart());
        menu.Add(new ProduktListeStart());
        menu.Add(new KundeListe());
        menu.Add(new SalgsOrdreListe());
        menu.Start(this);
    }
}
