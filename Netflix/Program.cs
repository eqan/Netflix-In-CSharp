using System;
using System.Windows.Forms;

namespace Netflix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new VideoPlayer("khalil", "eqan", "Iron Man", 3));
            //Application.Run(new MainPage("khalil", "eqan", 3));
            //Application.Run(new SearchBox("khalil", "eqan", 3));
            //Application.Run(new AccountInfo("khalil", "eqan", 3));
            Application.Run(new IntroPage());
            // Application.Run(new History("khalil", "eqan", 3));
            //Application.Run(new LoginForm());
            //Application.Run(new SignUP());
        }
    }
}
