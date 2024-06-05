using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thedigitalizationprojectproposal
{
    public partial class Form1 : Form
    {
        private object grossIncome;

        public decimal costOfGoodsSold { get; private set; }
        public decimal costOfRoomsSold { get; private set; }

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
            //
        }

        private void outputFormulaLabel2_Click(object sender, EventArgs e)
        {
            double grossIncome = 00.00;
            outputFormulaLabel2.Text = grossIncome.ToString();

            String message;
            message = "It must be a double value in Gross Income" + " " + "Thank your for telling us your estimation";
            MessageBox.Show(message.ToString());

            double amount = 93000;
            MessageBox.Show(amount.ToString("c"));

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

            MessageBox.Show(hotelOrLodgingArticleDescription);

        }

        private void calculateGrossIncomeButton_Click(object sender, EventArgs e)
        { 
            //to hold rooms number filled compared to total available roooms
            int occupiedRooms;
            //to hold rates used and take the average
            double averageDailyRates;
            //get the average gross income in that case before calculating
            //the gross revenue and assign to grossIncome
            double grossIncome;
            //get the rooms occupied in whole number and assign it to the occupied rooms variable 
            occupiedRooms = int.Parse(occupiedRoomsTotalTextBox.Text);
            //get the average daily rates in real Number and assign it to the average daily rates variable 
            averageDailyRates = double.Parse(averageDailyRoomRatesTextBox.Text);
            //Calculate gross Income
            grossIncome = (int)occupiedRooms * averageDailyRates;
            //display the grossIncome in the outputFormulaLabel2 control
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

        private void showBackButton_Click(object sender, EventArgs e)
        {
            {
                sitePictureBox.Visible = true;
                logoPictureBox.Visible = false;
            }

        }

        private void showFrontButton_Click(object sender, EventArgs e)
        {
            sitePictureBox.Visible = false;
            logoPictureBox.Visible = true;

        }

        private void calculateRemainingRooms_Click(object sender, EventArgs e)
        {
            int doubleRooms;
            int singleRooms;
            double totalRooms;
            doubleRooms = int.Parse(doubleRoomsOccupiedTextBox.Text);
            singleRooms = int.Parse(singleRoomsOccupiedTextBox.Text);                                                                                                                                                                                                               totalRooms = double.Parse(doubleRoomsOccupiedTextBox.Text + singleRoomsOccupiedTextBox.Text);
            totalRooms = (double)doubleRooms + singleRooms;
            outputFormulaLabel4.Text = totalRooms.ToString();

        }

        private void calculateLeftoverRooms_Click(object sender, EventArgs e)
        {
            //int occupiedRooms; int roomsTotal;
            //int totalRoomsRemainder;
            //occupiedRooms = int.Parse(occupiedRoomsTotalTextBox.Text);
            //roomsTotal = int.Parse(outputFormulaLabel4.Text);
            //totalRoomsRemainder = (int)(roomsTotal / occupiedRooms);
            //outputFormulaLabel5.Text = totalRoomsRemainder.ToString();

            int modResult = 1500 % 300;
            outputFormulaLabel5.Text = modResult.ToString();

        }

        private void outputFormulaLabel5_Click(object sender, EventArgs e)
        {
            //normal format integer
            int modResult = 0;
            MessageBox.Show(modResult.ToString("n"));
        }

        private void calculateRoomRate_Click(object sender, EventArgs e)
        {
            decimal roomAverageRate;      // The Room’s Average Rate
            decimal discountPercentage;   // The discount percentage
            decimal discountAmount;       // The amount of discount
            decimal roomSalesRate;        // The Room’s Sales price

            // Get the room’s average price.
            roomAverageRate = decimal.Parse(roomAverageRateTextBox.Text);

            // Get the discount percentage.
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // Move the percentage's decimal point left two spaces.
            discountPercentage = discountPercentage / 100;

            // Calculate the amount of the discount.
            discountAmount = roomAverageRate * discountPercentage;

            // Calculate the sale price.
            roomSalesRate = roomAverageRate - discountAmount;

            // Display the sale price.
            outputRoomSalesRateLabel.Text = roomSalesRate.ToString("c");

        }

        private void costRoomsSoldTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateCostofRoomsSoldTotal_Click(object sender, EventArgs e)
        {
            decimal costRoomsSalesTotal;
            decimal costRoomsGoodsSoldTotal;
            decimal costRoomsSoldTotal;
            costRoomsSalesTotal = decimal.Parse(costRoomsSalesTotalTextBox.Text);
            costRoomsGoodsSoldTotal = decimal.Parse(costRoomsGoodsSoldTotalTextBox.Text);
            costRoomsSoldTotal = costRoomsSalesTotal + costRoomsGoodsSoldTotal;
            outputCostRoomsSoldTotalLabel.Text = costRoomsSoldTotal.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //decimal averageGrossIncomeTotal;
            //decimal costOfRoomsSoldTotal;
            //double annualSalesRevenueEarnedHotelTotal;

            //averageGrossIncomeTotal = decimal.Parse(outputFormulaLabel2.Text);
            //costOfRoomsSoldTotal = decimal.Parse(outputCostRoomsSoldTotalLabel.Text);
            //annualSalesRevenueEarnedHotelTotal = ((double)(averageGrossIncomeTotal + costOfRoomsSoldTotal));
            //outputAnnualRevenueEarnedHotelTotalLabel.Text = annualSalesRevenueEarnedHotelTotal.ToString("c");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal costRoomsSalesTotal;
            decimal costRoomsGoodsSoldTotal;
            decimal costRoomsSoldTotal;
            costRoomsSalesTotal = decimal.Parse(costRoomsSalesTotalTextBox.Text);
            costRoomsGoodsSoldTotal = decimal.Parse(costRoomsGoodsSoldTotalTextBox.Text);
            costRoomsSoldTotal = costRoomsSalesTotal + costRoomsGoodsSoldTotal;
            outputCostRoomsSoldTotalLabel.Text = costRoomsSoldTotal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal costRoomsSalesTotal;
            decimal costRoomsGoodsSoldTotal;
            decimal costRoomsSoldTotal;
            costRoomsSalesTotal = decimal.Parse(costRoomsSalesTotalTextBox.Text);
            costRoomsGoodsSoldTotal = decimal.Parse(costRoomsGoodsSoldTotalTextBox.Text);
            costRoomsSoldTotal = costRoomsSalesTotal + costRoomsGoodsSoldTotal;
            outputCostRoomsSoldTotalLabel.Text = costRoomsSoldTotal.ToString();
        }

        private void displayOutputRevenue_Click(object sender, EventArgs e)
        {

        }

        private void displayOutputRevenue_Click_1(object sender, EventArgs e)
        {
            decimal salesRevenueInputTotal;
            decimal averageGrossIncomeTotal;
            decimal costOfRoomsSoldTotal;
            averageGrossIncomeTotal = decimal.Parse(outputFormulaLabel2.Text);
            costOfRoomsSoldTotal = decimal.Parse(outputCostRoomsSoldTotalLabel.Text);
            salesRevenueInputTotal = averageGrossIncomeTotal + costOfRoomsSoldTotal;
            outputAnnualRevenueEarnedHotelTotalLabel1.Text = salesRevenueInputTotal.ToString("c");
        }

        private void DisplayGrossIncome2_Click_1(object sender, EventArgs e)
        {
            
           // int occupiedRooms;
            //double averageDailyRates;
            //double grossIncome; 
            //occupiedRooms = int.Parse(occupiedRoomsTotalTextBox.Text);
            //averageDailyRates = double.Parse(averageDailyRoomRatesTextBox.Text);
            //grossIncome = (occupiedRooms * averageDailyRates);
            //outputGrossIncomeDisplay.Text = grossIncome.ToString();
        }

        private void displayGrossIncome2_Click(object sender, EventArgs e)
        {
            decimal salesRevenue;
            decimal costRoomsSalesTotal ;
            decimal costRoomsGoodsSoldTotal;
            decimal costOfRoomsSold;
            decimal grossIncome;
            salesRevenue = decimal.Parse(salesRevenueTextBox.Text);
            costRoomsSalesTotal = decimal.Parse(costRoomsSalesTotalTextBox.Text);
            costRoomsGoodsSoldTotal = decimal.Parse(costRoomsGoodsSoldTotalTextBox.Text);
            costOfRoomsSold = costRoomsSalesTotal + costRoomsGoodsSoldTotal;
            grossIncome = salesRevenue - costOfGoodsSold;
            outputGrossIncomeDisplay.Text = (grossIncome.ToString());
        }

        private void calculateNetIncomeButton_Click(object sender, EventArgs e)
        {
            //decimal salesRevenueInputTotal;
            //decimal costRoomsSalesTotalTextBox;
            //decimal costRoomsGoodsSoldTotalTextBox;
            //decimal costRoomsSoldTotal;
            //decimal hotelNetOperatingIncome;

            //salesRevenueInputTotal = decimal.Parse(outputAnnualRevenueEarnedHotelTotalLabel.Text);
            //costRoomsSoldTotal = decimal.Parse(outputCostRoomsSoldTotalLabel.Text);

            //Calculate cost of rooms sold multiply sales revenue input in total to get the net operating income
            //hotelNetOperatingIncome = (salesRevenueInputTotal - costRoomsSoldTotal);

            //Display net operating income of the Hotel
            //outputFormulaLabel3.Text = hotelNetOperatingIncome.ToString();

        }
    }
}
