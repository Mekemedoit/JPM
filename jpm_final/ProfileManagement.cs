using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JPM_Dev
{
    public partial class ProfileManagement : Form
    {
        private Admin adminForm;

        public ProfileManagement(Admin admin)
        {
            InitializeComponent();
            this.adminForm = admin;
        }


        // Load data when the form loads
        private void ProfileManagement_Load(object sender, EventArgs e)
        {
            LoadProfiles();
        }

        // Loads data from UserProfiles table into the DataGridView
        private void LoadProfiles()
        {
            string connectionString = "Data Source=WHELLMIE\\MSSQLSERVER01;Initial Catalog=JPM_Database;Integrated Security=True;";
            string query = "SELECT ProfilePhoto, ProfileID, FirstName, LastName, Email, Role FROM UserProfiles";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    profilesGrid.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profiles: " + ex.Message);
                }
            }
        }

        // Opens AddProfile form and reloads data if a profile was added
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProfile addProfile = new AddProfile(adminForm);
            adminForm.LoadFormInPanel(addProfile);
        }


    }
}
