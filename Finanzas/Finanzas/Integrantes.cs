using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas
{
    public partial class lk : Form
    {
        public lk()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lk_Load(object sender, EventArgs e)
        {
            try
            {

                axWindowsMediaPlayer1.URL = @"C:\Users\DELL\OneDrive\Escritorio\Finanzas-main\Finanzas\Finanzas\Resources\WhatsApp Video 2024-07-07 at 3.26.45 PM (1).mp4";
                axWindowsMediaPlayer1.uiMode = "none";
                axWindowsMediaPlayer1.settings.setMode("loop", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el video: " + ex.Message);
            }
        }
    }
}
