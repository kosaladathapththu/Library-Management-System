using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Book_Registration : Form
    {
        public Book_Registration()
        {
            InitializeComponent();
        }

        private void Book_Registration_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial Catalog=Library;Integrated Security=true";
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();


                string sql = "SELECT MAX (BookID) FROM books";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        if (dr.GetValue(0) == DBNull.Value)
                        {
                            this.txtid.Text = "1";
                        }
                        else
                        {
                            this.txtid.Text = (Convert.ToInt32(dr.GetValue(0).ToString()) + 1).ToString();
                        }
                    }
                    else
                    {
                        this.txtid.Text = "1";
                    }
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=AMKDA-PC;Initial Catalog=Library;Integrated Security=true";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            string sql = "INSERT INTO books(Title,Author,Genre,Availability) VALUES(@Title, @Author,@Genre,@Availability)";
            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@BookID", Convert.ToInt32(txtid.Text));
            cmd.Parameters.AddWithValue("@Title", txttitle.Text);
            cmd.Parameters.AddWithValue("@Author", txtauthor.Text);
            cmd.Parameters.AddWithValue("@Genre", txtgernre.Text);
            cmd.Parameters.AddWithValue("@Availability", cmbyn.SelectedItem.ToString());

            int ret = cmd.ExecuteNonQuery();
            if (ret == 1)
            {
                MessageBox.Show("Book added to the Data Base", "Information");
            }
            con.Close();

            // Call to Load Event
            Book_Registration_Load(this, null);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtid.Clear();
            txttitle.Clear();
            txtauthor.Clear();
            txtgernre.Clear();
            cmbyn.SelectedIndex = -1;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}      
    

