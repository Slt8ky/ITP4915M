using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Material_Requirement_Form
{
    public partial class MaterialRequirementForm : Form
    {
        private string connectionString = "server=125.59.53.16;uid=root;database=default;pwd=Vx|T77(6\"&bM;Convert Zero Datetime=true;";
        public MaterialRequirementForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1250, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void MaterialRequirementForm_Load(object sender, EventArgs e)
        {
            ResetMRForm_Click(sender, e);
        }
        public sealed class Database
        {
            private static readonly Database instance = new Database();
            private MySqlConnection connection;
            private string connectionString = "server=125.59.53.16;uid=root;database=default;pwd=Vx|T77(6\"&bM;Convert Zero Datetime=true;";

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

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }


        }

        private void UpLoadData()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM afterservicefeedback";

                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable db = new DataTable();
                db.Load(sdr);
            }
        }

        private void SubmitMRForm_Click(object sender, EventArgs e)
        {
            try
            {
                int newMaterialFormID;

 
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "SELECT COALESCE(MAX(MaterialFormID), 0) + 1 FROM materialrequirementform";
                        newMaterialFormID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO afterservicefeedback(MaterialFormID ,IssuanceDate, Product_ID,Product_Name,ProductType,Descriptions,Specification,MaterialID,MaterialAmount,PriorityLevel,DeliveryDate,Remarks) " +
                                  "VALUES(@MaterialFormID, @IssuanceDate, @Product_ID,  @Product_Name, @ProductType, @Descriptions, @Specification, @MaterialID, @MaterialAmount, @PriorityLevel, @DeliveryDate, @Remarks)";
                        cmd.Parameters.AddWithValue("@MaterialFormID", newMaterialFormID);
                        cmd.Parameters.AddWithValue("@IssuanceDate", DateTime.TryParse(IsDate.Text.Trim(), out DateTime issuanceDate) ? issuanceDate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Product_ID", MRPID.Text.Trim());
                        cmd.Parameters.AddWithValue("@Product_Name", MRPName.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProductType", MRPType.Text.Trim());
                        cmd.Parameters.AddWithValue("@Descriptions", MRFDescriptions.Text.Trim());
                        cmd.Parameters.AddWithValue("@Specification", MRFSpecification.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaterialID", MRFMID.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaterialAmount", decimal.TryParse(MRDMAmount.Text.Trim(), out decimal materialAmount) ? materialAmount : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@PriorityLevel", MRFPLevel.Text.Trim());
                        cmd.Parameters.AddWithValue("@DeliveryDate", DateTime.TryParse(MRFDDate.Text.Trim(), out DateTime deliveryDate) ? deliveryDate : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Remarks", MRFRemarks.Text.Trim());
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Create Feedback Succesaful");
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
            IsDate.Value = DateTime.Now;
            MRPID.Clear();
            MRPName.Clear();
            MRPType.SelectedIndex = -1;
            MRFDescriptions.Clear();
            MRFSpecification.Clear();
            MRFMID.Clear();
            MRDMAmount.Value = 1;
            MRFPLevel.SelectedIndex = -1;
            MRFDDate.Value = DateTime.Now;
            MRFRemarks.Clear();
        }
    }
}