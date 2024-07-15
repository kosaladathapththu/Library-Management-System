using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial Catalog=Library;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string sql = "SELECT MAX (MemberID) FROM Members";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr.GetValue(0) == DBNull.Value)
                        {
                            this.txtmid.Text = "1";
                        }
                        else
                        {
                            this.txtmid.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();
                        }
                    }
                    else
                    {
                        this.txtmid.Text = "1";
                    }
                }
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial Catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO Members(Name,Email,Phone,Address) VALUES(@name, @mail,@phone,@address)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@txtmid", Convert.ToInt32(txtid.Text));
            cmd.Parameters.AddWithValue("@name", txtname.Text);
            cmd.Parameters.AddWithValue("@mail", txtemail.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@address",txtaddress.Text);

            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Member Added Successfully", "Information");
            }
            con.Close();

            // Call to Load Event
           Form2_Load(this, null);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtmid.Clear();
            txtname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtaddress.Clear();
        }
    }
}
