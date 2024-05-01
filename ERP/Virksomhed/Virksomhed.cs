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
        Console.WriteLine("Test1");
        Console.WriteLine("Test2");

        Menu menu = new();
        menu.Add(new VirksomhedStart());
        menu.Start(this);
    }
}
