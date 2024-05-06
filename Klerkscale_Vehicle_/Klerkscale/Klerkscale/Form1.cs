using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Klerkscale


{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<double>> vehicles = new Dictionary<string, List<double>>();
        private SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();

            // Connection string to SQLite database
            string databasePath = @"C:\Users\Admin\Documents\Klerkscale\Klerkscale\mydatabase.sqlite";
            string connectionString = $"Data Source={databasePath};Version=3;";
            connection = new SQLiteConnection(connectionString);
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            string vehicleName = txtVehicleName.Text.Trim();
            if (!string.IsNullOrEmpty(vehicleName) && !vehicles.ContainsKey(vehicleName))
            {
                vehicles.Add(vehicleName, new List<double>());
                listBoxVehicles.Items.Add(vehicleName);
                txtVehicleName.Clear();
            }
            else
            {
                MessageBox.Show("Invalid vehicle name or vehicle already exists.");
            }
        }

        private void listBoxVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxWeights.Items.Clear();
            if (listBoxVehicles.SelectedItem != null)
            {
                string selectedVehicle = listBoxVehicles.SelectedItem.ToString();
                if (vehicles.ContainsKey(selectedVehicle))
                {
                    foreach (double weight in vehicles[selectedVehicle])
                    {
                        listBoxWeights.Items.Add(weight);
                    }
                }
            }
        }

        private void btnAddWeight_Click(object sender, EventArgs e)
        {
            if (listBoxVehicles.SelectedItem == null)
            {
                MessageBox.Show("Please select a vehicle first.");
                return;
            }

            double weight;
            if (double.TryParse(txtWeight.Text, out weight))
            {
                string selectedVehicle = listBoxVehicles.SelectedItem.ToString();
                vehicles[selectedVehicle].Add(weight);
                listBoxWeights.Items.Add(weight);
                txtWeight.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid weight.");
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // StringBuilder to build the report
            System.Text.StringBuilder report = new System.Text.StringBuilder();

            // Header for the report
            report.AppendLine("Vehicle Weight Report");
            report.AppendLine("======================");

            // Iterate over each vehicle in the dictionary
            foreach (var vehicle in vehicles)
            {
                report.AppendLine($"Vehicle: {vehicle.Key}");
                report.AppendLine("Weights:");

                // Calculate total weight for each vehicle
                double totalWeight = 0;

                // Append each weight to the report
                foreach (double weight in vehicle.Value)
                {
                    report.AppendLine($" - {weight} kg");
                    totalWeight += weight;
                }

                // Append total weight
                report.AppendLine($"Total Weight: {totalWeight} kg");
                report.AppendLine();  // Adding a blank line for better readability
            }

            // Display the report in a MessageBox
            MessageBox.Show(report.ToString(), "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void SaveReportToFile(string report)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, report);
            }
        }


        

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            string registrationDetails = txtRegistrationDetails.Text;

            // Insert registration data into SQLite database
            string insertQuery = "INSERT INTO Registrations (Details) VALUES (@Details)";
            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@Details", registrationDetails);

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred while registering: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Clear the registration details text box after insertion
            txtRegistrationDetails.Clear();
        }
    }
}
