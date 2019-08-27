using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Myth
{
    static class Program
    {
        static WindowsMediaPlayer player = new WindowsMediaPlayer();
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OpeningForm());

                
        }
        public static void PlayFile(String url)
        {
            player.URL = url;
            //player.controls.play();
        }


    }
}
