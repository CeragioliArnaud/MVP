using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVC.Views;
using MVC.Presenters;

namespace MVC
{
    public partial class Form1 : Form, IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string LengthText { get => txtLength.Text; set => txtLength.Text=value; }
        public string BreadthText { get => txtBreadth.Text; set => txtBreadth.Text=value; }
        public string AreaText { get => textBox3.Text; set => textBox3.Text=value; }

        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }
        
    }
}
