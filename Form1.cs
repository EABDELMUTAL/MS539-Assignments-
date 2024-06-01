using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digitalizingthetourismindusty
{
    public partial class Form1 : Form
    {
        public int occupiedRooms { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }

        private void outputLogoLabel_Click(object sender, EventArgs e)
        {
            outputLogoLabel.Text = "5p-OpEx Group Inc." + "+1 347 406 2191";

        }

        private void connectToOneStopTourismServicesButton_Click(object sender, EventArgs e)
        {
            string message;
            message = "Hello World of Tourism Components";
            MessageBox.Show(message);
        }

        private void connectToTouristAppButtom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah tourism components can connect to the Worldwide One-Stop Tourist Identity web and application development source code from here!");
        }

        private void communicateArticleDescriptionButton_Click(object sender, EventArgs e)
        {
            string hotelOrLodgingArticleDescription;
            hotelOrLodgingArticleDescription = hotelOrLodgingTextBox.Text + " " + classificationStandardsTextBox.Text + " " + hotelStandardRatesTextBox.Text;
            outputHotelOrLodgingLabel.Text = hotelOrLodgingArticleDescription;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void averageDailyRoomRatesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateGrossIncomeButton_Click(object sender, EventArgs e)
        {
            int occupiedRooms;
            double averageDailyRates;
            double grossIncome;
            occupiedRooms = int.Parse(occupiedRoomsTotalTextBox.Text);
            averageDailyRates = double.Parse(averageDailyRoomRatesTextBox.Text);
            grossIncome = (int)occupiedRooms * averageDailyRates;
            outputFormulaLabel2.Text = grossIncome.ToString();
        }

        private void initializeDaysOfWeekControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                ComboBox comboBoxDays = new ComboBox();
                comboBoxDays.Items.AddRange(new string[]{"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"});
                comboBoxDays.SelectedIndex = 0;
                comboBoxDays.Location = new Point(10, 10);
                this.Controls.Add(comboBoxDays);

            }
        }
    }
}
