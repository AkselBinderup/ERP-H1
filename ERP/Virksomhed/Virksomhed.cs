using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace ERP;

public class MainMenu : Screen
{
    public override string Title { get; set; } = "Virksomheder";
    protected override void Draw()
    {

        Menu menu = new();
        menu.Add(new VirksomhedStart());
        menu.Add(new ProductListeStart());
        menu.Add(new KundeListe());
        menu.Start(this);
    }
}
