namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            string argumento1 = args.Length > 1 ? args[1] : null;
            string argumento2 = args.Length > 2 ? args[2] : null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(argumento1, argumento2));
        }

    }
}