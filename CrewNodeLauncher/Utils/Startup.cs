using CrewNodeLauncher.UI;
using System.Threading;
using System.Windows.Forms;

namespace CrewNodeLauncher.Utils
{
    class Startup
    {
        private delegate void CloseDelegate();
        private static Preloader splashForm;

        static public void ShowPreloader()
        {
            if (splashForm != null)
                return;

            Thread thread = new Thread(new ThreadStart(ShowForm));
            thread.IsBackground = false;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            splashForm = new Preloader();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            if (splashForm != null)
                splashForm.Invoke(new CloseDelegate(CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
            splashForm = null;
        }
    }
}
