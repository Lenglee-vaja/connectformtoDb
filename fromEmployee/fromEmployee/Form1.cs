using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fromEmployee
{
    public partial class Form1 : Form
    {
        Dbconnection Q = new Dbconnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name, surname, phone, email, address, noted;
            name = txtEm_Name.Text.ToString();
            surname = txtEm_surname.Text.ToString();
            phone = txtEm_phone.Text.ToString();
            email = txtEm_email.Text.ToString();
            address = txtEm_address.Text.ToString();
            noted = txtEm_noted.Text.ToString();
            Q.Query("insert into tb_Employee (Em_name,Em_Surname,Em_Phone,Em_Email,Em_Address,Noted) " +
                "values ('" + name + "','" + surname + "','" + phone + "','" + email + "','" + address + "','" + noted + "')");
            MessageBox.Show("Emplpyee added!!!","imformation");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String name, surname, phone, email, address, noted;
            name = txtEm_Name.Text.ToString();
            surname = txtEm_surname.Text.ToString();
            phone = txtEm_phone.Text.ToString();
            email = txtEm_email.Text.ToString();
            address = txtEm_address.Text.ToString();
            noted = txtEm_noted.Text.ToString();
            Q.Query("UPDATE tb_Employee SET (Em_Surname ='" + surname + "',Em_Phone='" + phone + "',Em_Emial='" + email + "'" +
                ",Em_Address='" + address + "',Noted='" + noted + "') WHERE Em_name ='" + name + "'");
            MessageBox.Show("Employee Edit","imformation");
        }
    }
}
