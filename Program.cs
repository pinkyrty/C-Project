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
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Form targetForm = null;
                switch (login.TargetFormType)
                {
                    case Login.FormType.ITForm:
                        targetForm = new IT_Form();
                        break;
                    case Login.FormType.RNDForm:
                        targetForm = new RnD_Form();
                        break;
                    case Login.FormType.FIForm:
                        targetForm = new FinanceDepartment();
                        break;
                    case Login.FormType.SCMForm:
                        targetForm = new Sales_MarketingForm();
                        break;
                    default:
                        return;
                }
                Application.Run(targetForm);
            }
        }
    }
}