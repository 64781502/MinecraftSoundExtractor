using System;
using System.Windows.Forms;

namespace minecraftsoundextractor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUIForm());
        }
    }
}
