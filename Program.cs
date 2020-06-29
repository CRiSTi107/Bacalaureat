using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BAC_Note
{
    /*
     * Image resources taken from:
     * -> https://www.iconfinder.com/icons/3790068/academic_education_graduate_learning_scholar_school_icon
     * -> https://www.iconfinder.com/icons/2316254/degree_diploma_education_graduate_resume_school_university_icon 
     */

    static class Program
    {
        private static Mutex mutex = new Mutex(false, GUID.GetApplicationGUID());

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (mutex.WaitOne(0, false))
                Application.Run(new frm_Main());
        }
    }
}
