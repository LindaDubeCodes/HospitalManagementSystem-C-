using MySql.Data.MySqlClient;
namespace HospitalManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string mysqlcon = " server=localhost;user=root;database=ekuphileni;password=;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("succesfeul");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

            finally
            {
                mySqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 formlogin = new Form1();
            formlogin.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
