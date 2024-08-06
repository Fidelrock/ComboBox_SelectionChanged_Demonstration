using System.Collections.Generic;
using System.Windows;

namespace TransporterVehicleSelection
{
    public partial class MainWindow : Window
    {
        // Sample data
        private Dictionary<string, List<string>> transporterVehicles = new Dictionary<string, List<string>>()
        {
            { "Transporter A", new List<string> { "Vehicle 1", "Vehicle 2", "Vehicle 3" } },
            { "Transporter B", new List<string> { "Vehicle 4", "Vehicle 5" } },
            { "Transporter C", new List<string> { "Vehicle 6", "Vehicle 7", "Vehicle 8", "Vehicle 9" } }
        };

        public MainWindow()
        {
            InitializeComponent();

            // Populate the TransporterComboBox with transporters
            TransporterComboBox.ItemsSource = transporterVehicles.Keys;
        }

        private void TransporterComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            // Clear the vehicle ComboBox first
            VehicleComboBox.ItemsSource = null;
            VehicleComboBox.Items.Clear();

            // Get the selected transporter
            string selectedTransporter = TransporterComboBox.SelectedItem as string;

            if (selectedTransporter != null && transporterVehicles.ContainsKey(selectedTransporter))
            {
                // Populate the VehicleComboBox with vehicles of the selected transporter
                VehicleComboBox.ItemsSource = transporterVehicles[selectedTransporter];
            }
        }
    }
}
