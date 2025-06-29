using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_System.Interface
{
    public partial class InternalTransferForm : Form
    {
        private string connectionString = "server=125.59.53.16;uid=user;database=default;pwd=f828Q9£C76$U;Convert Zero Datetime=true;";
        public InternalTransferForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1250, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void internaltransferform_Load(object sender, EventArgs e)
        {
            ResetMRForm_Click(sender, e);
        }
        public sealed class Database
        {
            private static readonly Database instance = new Database();
            private MySqlConnection connection;
            private string connectionString = "server=125.59.53.16;uid=user;database=default;pwd=f828Q9£C76$U;Convert Zero Datetime=true;";

            private Database()
            {
                connection = new MySqlConnection(connectionString);
                try
                {
                    connection.Open();
                }
                catch (MySqlException ex)
                {
                    throw new Exception($"Database connection error: {ex.Message}");
                }
            }

            public static Database Instance => instance;

            public MySqlConnection Connection => connection;

            public void CloseConnection()
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void UpLoadData()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM internaltransferform";

                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable db = new DataTable();
                db.Load(sdr);
            }
        }

        private void SubmitITForm_Click(object sender, EventArgs e)
        {
            try
            {
                int newTransferFormNumber;


                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT COALESCE(MAX(TransferFormNumber), 0) + 1 FROM internaltransferform";
                        newTransferFormNumber = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO internaltransferform(TransferFormNumber ,DateOfInitiation, DestinationDepartment,TransferSource,TransferItemType,TransferItemName,TransferAmount,OrderID,Descriptions,Specifications,TransferReason,StaffID) " +
                                  "VALUES(@TransferFormNumber ,@DateOfInitiation, @DestinationDepartment, @TransferSource, @TransferItemType, @TransferItemName, @TransferAmount,OrderID, @Descriptions, @Specifications, @TransferReason, @StaffID)";
                        cmd.Parameters.AddWithValue("@TransferFormNumber", newTransferFormNumber);
                        cmd.Parameters.AddWithValue("@DateOfInitiation", DateTime.TryParse(ITDate.Text.Trim(), out DateTime issuanceDate) ? issuanceDate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@DestinationDepartment", DestinationDepartment.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransferSource", ITSource.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransferItemType", TransferItemType.Text.Trim());
                        cmd.Parameters.AddWithValue("@Descriptions", ITFDescriptions.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransferItemName", TransferItemName.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransferAmount", decimal.TryParse(TransferAmount.Text.Trim(), out decimal materialAmount) ? materialAmount : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@OrderID", OrderID.Text.Trim());
                        cmd.Parameters.AddWithValue("@Specifications", ITFSpecification.Text.Trim());
                        cmd.Parameters.AddWithValue("@TransferReason", ITReason.Text.Trim());
                        cmd.Parameters.AddWithValue("@StaffID", MRFStaffID.Text.Trim());
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Internal Transfer Form submitted");
                UpLoadData();
                ResetMRForm_Click(sender, e);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"SQL Error : {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ResetMRForm_Click(object sender, EventArgs e)
        {
            ITDate.Value = DateTime.Now;
            DestinationDepartment.Clear();
            ITSource.Clear();
            TransferItemType.SelectedIndex = -1;
            ITFDescriptions.Clear();
            TransferItemName.Clear();
            TransferAmount.Value = 1;
            OrderID.Clear();
            ITFSpecification.Clear();
            ITReason.Clear();
        }
    }
}
