using CafeManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    public partial class TransectionForm : Form
    {
        public TransectionForm()
        {
            InitializeComponent();
            TransectiondataGridView.DataSource = TransectionController.ViewTransection();
            
        }
    }
}
