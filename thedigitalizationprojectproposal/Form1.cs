using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thedigitalizationprojectproposal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hotelOrLodgingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tourismLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel4_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel5_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel6_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel7_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel8_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel9_Click(object sender, EventArgs e)
        {

        }

        private void outputFormulaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel10_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel11_Click(object sender, EventArgs e)
        {

        }

        private void connectToOneStopTourismServicesButton_Click(object sender, EventArgs e)
        {
            string message;
            message = "Hello World of Tourism Components";
            MessageBox.Show(message);

        }

        private void connectToTouristAppButtom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah tourism components can connect to the Worldwide One-Stop Tourist Identity web gate application in here!");
        }

        private void locationAddressTextBox_TextChanged(object sender, EventArgs e)
        {
           //
        }

        private void doubleRoomsOccupiedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void singleRoomsOccupiedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void classificationStandardsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotelStandardRatesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void occupiedRoomsTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void averageDailyRoomRatesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputHotelOrLodgingLabel_Click(object sender, EventArgs e)
        {

        }

        private void tourismLabel1_Click(object sender, EventArgs e)
        {

        }

        private void outputFormulaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //int hotel = 4000;
           //
        }

        private void communicateArticleDescriptionButton_Click(object sender, EventArgs e)
        {
            string hotelOrLodgingArticleDescription;
            hotelOrLodgingArticleDescription = hotelOrLodgingTextBox.Text + " " + classificationStandardsTextBox.Text + " " + hotelStandardRatesTextBox.Text;
            outputHotelOrLodgingLabel.Text = hotelOrLodgingArticleDescription;

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

        private void outputLogoLabel_Click(object sender, EventArgs e)
        {
            outputLogoLabel.Text = "5p-OpEx Group Inc." +" "+ "+1 347 406 2191" + " " + "eleanor@5p-OpExGroup.org";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hotelOrLodgingTextBox.Text = "";
            locationAddressTextBox.Text = "";
            doubleRoomsOccupiedTextBox.Text = "";
            singleRoomsOccupiedTextBox.Text = "";
            classificationStandardsTextBox.Text = "";
            hotelStandardRatesTextBox.Text = "";
            occupiedRoomsTotalTextBox.Text = "";
            averageDailyRoomRatesTextBox.Text = "";
            outputHotelOrLodgingLabel.Text = "";
            outputFormulaLabel2.Text = "";
            outputFormulaLabel3.Text = "";
        }
    }
}
