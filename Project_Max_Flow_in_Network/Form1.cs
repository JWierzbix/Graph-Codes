using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Max_Flow_in_Network
{
    public partial class Form1 : Form
    {
        OpenFileDialog file;
        string data_path;
        public Form1()
        {
            InitializeComponent();
        }      

        private void b_source_Click(object sender, EventArgs e)
        {
            file = new OpenFileDialog();
            file.Filter = "Text files(*.txt)|*.txt";
            if(file.ShowDialog() == DialogResult.OK)
            {
                data_path = file.FileName;
                path_name.Text = file.FileName;
                Choosen_Path_Display.Text = file.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void path_name_TextChanged(object sender, EventArgs e)
        {
            data_path = path_name.Text;
            path_name.Text = path_name.Text;
            Choosen_Path_Display.Text = path_name.Text;
        }
    }
}
