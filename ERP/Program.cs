using ERP;
using TECHCOOL.UI;

ConfigSettings.ReadConfigSettings();
var conn = ConfigSettings.ConnectionString;

Screen.Display(new MainMenu());
