using TECHCOOL.UI;

namespace ERP;
public class Program
{
    public static LogWriter logWriter = new LogWriter();

    public static void Main()
    {
        try
        {
            ConfigSettings.ReadConfigSettings();
            Screen.Display(new MainMenu());
        }
        catch (Exception ex)
        {
            logWriter.LogWrite(ex.Message);
        }
    }
}


