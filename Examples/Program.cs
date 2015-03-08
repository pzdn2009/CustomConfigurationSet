using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Examples
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ConfigurationExample());

            DatabaseConfigTest();

        }

        public static void DatabaseConfigTest()
        {
            DatabasesSection dbSection = ConfigurationManager.GetSection("Databases") as DatabasesSection;

            MessageBox.Show(dbSection.Name + Environment.NewLine + dbSection.AllDatabases.Count);

            foreach (DatabaseElement item in dbSection.AllDatabases)
            {
                MessageBox.Show(item.NameType + Environment.NewLine + item.FileNumber + Environment.NewLine + item.ConnString);
            }
        }
    }
}