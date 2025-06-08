using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Smile___Sunshine_Toy_System.Interface
{
    public partial class Customer_Feedback : Form
    {
        private string connectionString = "server=125.59.53.16;uid=root;database=default;pwd=Vx|T77(6\"&bM;Convert Zero Datetime=true;";

        public Customer_Feedback()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1250, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            UpLoadData();
        }

        private void Customer_Feedback_Load(object sender, EventArgs e)
        {
            ResetButton_Click(sender, e);
        }

        private void UpLoadData()
        {

            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * From afterServiceFeedback";

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable db = new DataTable();
            db.Load(sdr);

            ViewFBData.DataSource = db;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO afterServiceFeedback(clientID, orderID, DataOfFeedback,feedbackType, feedbackDetail, contactType, contactInfo, Interaction,productID , staffID)" +
                            "VALUES(@clientID, @orderID, @DataOfFeedback, @feedbackType, @feedbackDetail, @contactType, @contactInfo, @Interaction, @productID , @staffID)";
                        cmd.Parameters.AddWithValue("@clientID", FBCID.Text.Trim());
                        cmd.Parameters.AddWithValue("@orderID", FBOID.Text.Trim());
                        cmd.Parameters.AddWithValue("@DataOfFeedback", FBDate.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackType", FBType.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackDetail", FBDetail.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactType", FBCType.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactInfo", FBCInfo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Interaction", FBInteraction.Text.Trim());
                        cmd.Parameters.AddWithValue("@productID", FBPID.Text.Trim());
                        cmd.Parameters.AddWithValue("@staffID", FBSID.Text.Trim());
                        cmd.ExecuteNonQuery();

                    }
                }
                MessageBox.Show("Create Feedback Succesaful");
                UpLoadData();
                ResetButton_Click(sender, e);
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult FBExit;
            FBExit = MessageBox.Show("Confirm Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (FBExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FBOID.Clear();
            FBPID.Clear();
            FBCID.Clear();
            FBDate.Value = DateTime.Today;
            FBInteraction.Clear();
            FBType.SelectedIndex = -1;
            FBCType.SelectedIndex = -1;
            FBCInfo.Clear();
            FBDetail.Clear();
        }


        private void FBTSConnectBT_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Connected");
                    }
                    else
                    {
                        MessageBox.Show("Connection Fail");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
        }

        private void ViewFBData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FBOID.Text = ViewFBData.SelectedRows[0].Cells[0].Value.ToString();
                FBPID.Text = ViewFBData.SelectedRows[0].Cells[1].Value.ToString();
                FBCID.Text = ViewFBData.SelectedRows[0].Cells[2].Value.ToString();
                FBDate.Text = ViewFBData.SelectedRows[0].Cells[3].Value.ToString();
                FBInteraction.Text = ViewFBData.SelectedRows[0].Cells[4].Value.ToString();
                FBType.Text = ViewFBData.SelectedRows[0].Cells[5].Value.ToString();
                FBCType.Text = ViewFBData.SelectedRows[0].Cells[6].Value.ToString();
                FBCInfo.Text = ViewFBData.SelectedRows[0].Cells[7].Value.ToString();
                FBDetail.Text = ViewFBData.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "afterServiceFeedback Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE  afterServiceFeedback SET" +
                            "clientID = @clientID," +
                            "orderID = @orderID," +
                            "DataOfFeedback = @DataOfFeedback," +
                            "feedbackType = @feedbackType, " +
                            "feedbackDetail = @feedbackDetail," +
                            "Interaction =  @Interaction," +
                            "contactInfo = @contactInfo" +
                            "contactType = @contactType" +
                            "productID = @productID," +
                            "staffID = @staffID" +
                            "WHERE clientID = @clientID ";
                        cmd.Parameters.AddWithValue("@clientID", FBCID.Text.Trim());
                        cmd.Parameters.AddWithValue("@orderID", FBOID.Text.Trim());
                        cmd.Parameters.AddWithValue("@DataOfFeedback", FBDate.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackType", FBType.Text.Trim());
                        cmd.Parameters.AddWithValue("@feedbackDetail", FBDetail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Interaction", FBInteraction.Text.Trim());
                        cmd.Parameters.AddWithValue("@productID", FBPID.Text.Trim());
                        cmd.Parameters.AddWithValue("@staffID", FBSID.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactType", FBCType.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactInfo", FBCInfo.Text.Trim());

                        cmd.ExecuteNonQuery();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record was updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM afterServiceFeedback WHERE contactInfo = @contactInfo";
                cmd.Parameters.AddWithValue("@contactInfo", FBCInfo.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete Successful");
                    UpLoadData();
                    ResetButton_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No record found to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
            }
            finally
            {
                con.Close();
            }
            UpLoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fromMail = "slt8ky@gmail.com";
            string fromPassword = "eerh wyie iojm nxjr";
            string htmlBody = $@"
            <html>
                <body style='margin: 0; padding: 0; background: #1D1D1D;'>
                    <table width='100%' cellpadding='0' cellspacing='0' style='background: #1D1D1D;'>
                        <tr>
                            <td align='center' style='background: linear-gradient(to right, #6a0dad, #ff7e5f); padding: 20px;'>
                                <h1 style='color: white; font-family: Arial, sans-serif; margin: 0;'>Smile & SunShine Toy</h1>
                            </td>
                        </tr>
                        <tr>
                            <td align='center' style='background: #2c2c2c; color: #eebc85; padding: 40px; border-radius: 10px;'>
                                <h2 style='font-family: Arial, sans-serif; font-weight: lighter; letter-spacing: 5px; margin: 0;'>Service Department</h2>
                                <hr style='border: 1px solid #eebc85; width: 50%; margin: 20px auto;'>
                                <p style='font-family: Arial, sans-serif; color: #eebc85; font-size: 18px; word-break: break-all;'>
                                    {FBInteraction.Text.ToString()}
                                    <br>
                                    If you have any further questions, please feel free to contact us through Gmail - 
                                    <a href='mailto:slt8ky@gmail.com' style='text-decoration: underline; color: #eebc85; margin-top: 20px;'>slt8ky@gmail.com</a>.
                                </p>
                            </td>
                        </tr>
                    </table>
                </body>
            </html>";

            // Create a MailMessage
            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.To.Add(new MailAddress("slt8ky@gmail.com"));
            message.Subject = "Smile & Sunshine Toy";
            message.Body = htmlBody;
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }
    }
}
