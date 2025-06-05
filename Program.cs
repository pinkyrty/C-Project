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
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Form targetForm = null;
                switch (login.TargetFormType)
                {
                    case Login.FormType.RNDForm:
                        targetForm = new RnD_Form();
                        break;
                    case Login.FormType.SMDForm:
                        targetForm = new Sales_MarketingForm();
                        break;
                    case Login.FormType.PDForm:
                        targetForm = new ProductionOrderForm();
                        break;
                    case Login.FormType.CSDForm:
                        targetForm = new CustomerServiceForm();
                        break;
                    case Login.FormType.SCMForm:
                        targetForm = new LogisticForm();
                        break;
                    case Login.FormType.FIForm:
                        targetForm = new FinanceDepartment();
                        break;
                    case Login.FormType.ITForm:
                        var itForm = new IT_Form();
                        itForm.Username = login.Username;
                        itForm.DepartmentName = login.DepartmentName;
                        targetForm = itForm;
                        break;
                    case Login.FormType.DTForm:
                        targetForm = new LogisticTrackingForm();
                        break;
                    default:
                        return;
                }
                Application.Run(targetForm);
            }
        }
    }
}