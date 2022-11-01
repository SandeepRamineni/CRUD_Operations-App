using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CRUD_operations
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Department;Data Source=AMPHENOLRENTAL-");
        }

        public void Reset()
        {
            text_DeptID.Text = text_DeptName.Text = text_LocID.Text = "";
            text_DeptID.Focus();

        }
        private void AddNew_Click(object sender, EventArgs e)
        {
            Reset();
            string command = "Select max([DeptID] ) + 10 from Amp_dept";
            cmd = new SqlCommand(command, con);
            con.Open();
            string Id = cmd.ExecuteScalar().ToString();
            con.Close();
            text_DeptID.Text = Id;
        }


        private void Save_Click(object sender, EventArgs e)
        {
            string id = text_DeptID.Text;
            string name = text_DeptName.Text;
            string loc = text_LocID.Text;
            string command = "insert into Amp_dept values (@deptid,@deptname,@locid)";
            cmd = new SqlCommand(command, con);
            cmd.Parameters.Add("@deptid", SqlDbType.Int);
            cmd.Parameters.Add("@deptname", SqlDbType.VarChar);
            cmd.Parameters.Add("@locid", SqlDbType.Int);
            cmd.Parameters["@deptid"].Value = id;
            cmd.Parameters["@deptname"].Value = name;
            cmd.Parameters["@locid"].Value = loc;
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record saved....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Reset();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string id = text_DeptID.Text;
            string command = "select * from Amp_dept where DeptID=@deptid";
            cmd = new SqlCommand(command, con);
            cmd.Parameters.Add("@deptid", SqlDbType.Int);
            cmd.Parameters["@deptid"].Value = id;
          
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                text_DeptName.Text = dr[1].ToString();
                text_LocID.Text = dr["LocationID"].ToString();
            }
            else
            {
                MessageBox.Show("Cannot find the record....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            dr.Close();
            con.Close();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string id = text_DeptID.Text;
            string name = text_DeptName.Text;
            string loc = text_LocID.Text;
            string command = string.Format("update Amp_dept set DeptName=@deptname, LocationID=@locid where DeptID=@deptid");
            cmd = new SqlCommand(command, con);
            cmd.Parameters.Add("@deptid", SqlDbType.Int);
            cmd.Parameters.Add("@deptname", SqlDbType.VarChar);
            cmd.Parameters.Add("@locid", SqlDbType.Int);
            cmd.Parameters["@deptid"].Value = id;
            cmd.Parameters["@deptname"].Value = name;
            cmd.Parameters["@locid"].Value = loc;
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = text_DeptID.Text;
            string command = string.Format("delete from  Amp_dept where DeptID=@deptid");
            cmd = new SqlCommand(command, con);
            cmd.Parameters.Add("@deptid", SqlDbType.Int);
            cmd.Parameters["@deptid"].Value = id;
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /* con.Open();
             cmd = new SqlCommand("select * from Amp_dept", con);
             dr = cmd.ExecuteReader();
             DataTable dt = new DataTable();
             dt.Load(dr);
             dataGridView1.DataSource = dt;
             con.Close();

              try
              {
                  con.Open();
                  MessageBox.Show("Connection Established");
                  con.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }*/
        }

        private void display_button_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select * from Amp_dept", con);
            con.Open();
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
