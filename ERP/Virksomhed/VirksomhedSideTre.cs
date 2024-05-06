﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;
using ERP;
using System.ComponentModel.DataAnnotations;

namespace ERP;

public partial class VirksomhedSideTre : Screen
{
    public override string Title { get; set; } = "Selskab";
    Virksomhed virksomhed = new();

    public VirksomhedSideTre(Virksomhed virksomhed)
    {
        Title = "Redigerer for " + virksomhed.FirmaNavn;
        this.virksomhed = virksomhed;
    }

    protected override void Draw()
    {
        ExitOnEscape();
        Form<Virksomhed> form = new();

        form.TextBox("Name", nameof(virksomhed.FirmaNavn));
        form.TextBox("vej", nameof(virksomhed.Vej));
        form.TextBox("Husnummer", nameof(virksomhed.HusNummer));
        form.TextBox("Postnummer", nameof(virksomhed.PostNummer));
        form.TextBox("By", nameof(virksomhed.By));
        form.TextBox("Land", nameof(virksomhed.Land));
        form.SelectBox("Currency", nameof(virksomhed.Valuta));
        form.AddOption("Currency", "DKK", Currency.DKK);
        form.AddOption("Currency", "EUR", Currency.EUR);
        form.AddOption("Currency", "USD", Currency.USD);
        form.AddOption("Currency", "SEK", Currency.SEK);

        if (form.Edit(virksomhed))
        {
            Database database = new Database();
            database.Update(virksomhed); 
            Console.WriteLine("Ændringerne blev gemt");
        }
        else
        {
            Console.WriteLine("Ingen ændringer");
        }

    }
}