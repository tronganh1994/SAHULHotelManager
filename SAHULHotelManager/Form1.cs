using SAHULHotelManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAHULHotelManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CPerson person = new CPerson("Lê Tuấn Đạt", 
                                        (int)CPerson.PersonSex.Male, 
                                        new DateTime(1995, 05, 11), 
                                        "101204749", 
                                        "39 Đại Đồng", 
                                        "0944457247", 
                                        "Kinh");

            txtTemp.Text = person.ToString;
        }
    }
}
