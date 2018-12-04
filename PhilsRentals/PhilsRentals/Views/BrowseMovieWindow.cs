using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhilsRentals.Views
{
    public partial class BrowseMovieWindow : UserControl
    {
        /// <summary>
        /// Handle to the MainWindowController.
        /// 
        /// This class will only use _mwc.GetMovies()
        /// Refer to these methods in the controller for their parameters
        /// These methods need to be implemented
        /// The return types may need to be changed (If you change them you must also change them in the interface)
        /// </summary>
        IMainWindowController _mwc;

        public BrowseMovieWindow(IMainWindowController mwc)
        {
            InitializeComponent();
            _mwc = mwc;
        }

        private void uxTextBoxTextChanged(object sender, EventArgs e)
        {
            uxButtonGetMovie.Enabled = uxTextBoxMovieTitle.TextLength > 0;
        }

        private void uxButtonGetMovie_Click(object sender, EventArgs e)
        {
            uxTextBoxMovieTitle.Text = "";
        }

        private bool GetMovies()
        {
            return false;
        }

        private void uxListBoxMovies_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}