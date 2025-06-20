using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace C_Project
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            while (true)
            {
                Login login = new Login();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Login.OpenDepartmentForm(login);
                }
                else
                {
                    break; // 退出程式
                }
            }
        }
    }
}