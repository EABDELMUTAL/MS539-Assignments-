using Aspose.Pdf.Operators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thedigitalizationprojectproposal
{
    public partial class Form1 : Form
    {
#pragma warning disable CS0169 // The field 'Form1.grossIncome' is never used
        private object grossIncome;
#pragma warning restore CS0169 // The field 'Form1.grossIncome' is never used
        private object outputAnnualRevenueEarnedHotelTotalLabel;

        public decimal costOfGoodsSold { get; private set; }
        public decimal costOfRoomsSold { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void communicateArticleDescriptionButton_Click(object sender, EventArgs e)
        {
            string hotelOrLodgingArticleDescription;
            hotelOrLodgingArticleDescription = hotelOrLodgingTextBox.Text + " " + classificationStandardsTextBox.Text + " " + hotelStandardRatesTextBox.Text;
            outputHotelOrLodgingLabel.Text = hotelOrLodgingArticleDescription;

            MessageBox.Show(hotelOrLodgingArticleDescription);

            outputHotelOrLodgingLabel.BackColor = Color.White;
            outputHotelOrLodgingLabel.ForeColor = Color.Purple;


        }

        private void outputLogoLabel_Click(object sender, EventArgs e)
        {
            outputLogoLabel.Text = "5p-OpEx Group Inc." + " " + "+1 347 406 2191" + " " + "eleanor@5p-OpExGroup.org";
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
            outputAnnualRevenueEarnedHotelTotalLabel1.Text = "";
            outputsalesRevenueTextBox.Text = "";
            costRoomsSalesTotalTextBox.Text = "";
            outputFormulaLabel3.Text = "";
            averageRevenueTextBox.Text = "";

            insertExcessExpensesTextBox.Text = "";

            grossIncomeLabel.Text = "";
            outputCostRoomsSoldTotalLabel.Text = "";

            costRoomsGoodsSoldTotalTextBox.Text = "";



            // Set the focus to nameTextBox.
            //Programmmers control the focus by the following syntax general method
            //ControlName.Focus();
            hotelOrLodgingTextBox.Focus();

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
            singleRooms = int.Parse(singleRoomsOccupiedTextBox.Text); totalRooms = double.Parse(doubleRoomsOccupiedTextBox.Text + singleRoomsOccupiedTextBox.Text);
            totalRooms = (double)doubleRooms + singleRooms;
            outputFormulaLabel4.Text = totalRooms.ToString("n");

            outputFormulaLabel4.BackColor = Color.White;
            outputFormulaLabel4.ForeColor = Color.Purple;

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
            outputFormulaLabel5.Text = modResult.ToString("n");

            outputFormulaLabel5.BackColor = Color.White;
            outputFormulaLabel5.ForeColor = Color.Purple;

        }

        private void outputFormulaLabel5_Click(object sender, EventArgs e)
        {
            //normal format integer
            int modResult = 0;
            MessageBox.Show(modResult.ToString("n"));
        }

        private void calculateRoomRate_Click(object sender, EventArgs e)
        {
            {
                try
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

                    double revenue1;    // To hold revenue year #1
                    double revenue2;    // To hold revenue year #2
                    double revenue3;    // To hold revenue year #3
                    double averageRevenuesGathered; // To hold the average revenue for market research, competition, standards and best price practice  

                    // Get the three revenues.
                    revenue3 = double.Parse(outputFormulaLabel2.Text);
                    revenue2 = double.Parse(outputAnnualRevenueEarnedHotelTotalLabel1.Text);
                    revenue1 = double.Parse(outputsalesRevenueTextBox.Text);

                    // Calculate the average revenue streams on site.
                    averageRevenuesGathered = (revenue3 + revenue2 + revenue1) / 3.0;

                    // Display the average test score, with
                    //The program instruction has rounded the                  
                    //output to 1 decimal point
                    averageRevenueTextBox.Text = averageRevenuesGathered.ToString("n1");

                }
                catch (Exception ex)
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void calculateCostofRoomsSoldTotal_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double costRoomsSalesTotal;
                    double costRoomsGoodsSoldTotal;
                    double costRoomsSoldTotal;
                    costRoomsSalesTotal = double.Parse(costRoomsSalesTotalTextBox.Text);
                    costRoomsGoodsSoldTotal = double.Parse(costRoomsGoodsSoldTotalTextBox.Text);
                    costRoomsSoldTotal = costRoomsSalesTotal + costRoomsGoodsSoldTotal;
                    outputCostRoomsSoldTotalLabel.Text = (costRoomsSoldTotal.ToString("n1"));

                    outputCostRoomsSoldTotalLabel.BackColor = Color.White;
                    outputCostRoomsSoldTotalLabel.ForeColor = Color.Purple;
                }
                catch (Exception ex)
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void calculateCostOfRoomsSoldTotal1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double costRoomsSalesTotal;
                    double costRoomsGoodsSoldTotal;
                    double costRoomsSoldTotal;
                    costRoomsSalesTotal = double.Parse(costRoomsSalesTotalTextBox.Text);
                    costRoomsGoodsSoldTotal = double.Parse(costRoomsGoodsSoldTotalTextBox.Text);
                    costRoomsSoldTotal = costRoomsSalesTotal + costRoomsGoodsSoldTotal;
                    outputCostRoomsSoldTotalLabel.Text = (costRoomsSoldTotal.ToString("n1"));
                }
                catch (Exception ex)
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void calculateCostOfRoomsSoldTotal2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double costRoomsSalesTotal;
                    double costRoomsGoodsSoldTotal;
                    double costRoomsSoldTotal;
                    costRoomsSalesTotal = double.Parse(costRoomsSalesTotalTextBox.Text);
                    costRoomsGoodsSoldTotal = double.Parse(costRoomsGoodsSoldTotalTextBox.Text);
                    costRoomsSoldTotal = costRoomsSalesTotal + costRoomsGoodsSoldTotal;
                    outputCostRoomsSoldTotalLabel.Text = costRoomsSoldTotal.ToString("n1");
                }
                catch (Exception ex)
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void insertOperatingExpenses_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    decimal operatingExpenses;
                    operatingExpenses = decimal.Parse(insertExcessExpensesTextBox.Text);
                    insertExcessExpensesTextBox.Text = (operatingExpenses.ToString("n"));

                }
                catch (Exception ex)
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void calculateAverageRoomRates_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double roomRateYear1;    // To hold room rates year #1
                    double roomRateYear2;    // To hold room rates year #2
                    double roomRateYear3;    // To hold room rates year #3
                    double averageRoomRates; // To hold the average room rates for market research, competition, standards and best price practice  

                    // Get the three test scores.
                    roomRateYear3 = double.Parse(roomRatesTextBoxY4.Text);
                    roomRateYear2 = double.Parse(roomRatesTextBoxY3.Text);
                    roomRateYear1 = double.Parse(roomRatesTextBoxY2.Text);

                    // Calculate the average test score.
                    averageRoomRates = (roomRateYear3 + roomRateYear2 + roomRateYear1) / 3.0;

                    // Display the average test score, with
                    //The program instruction has rounded the                  
                    //output to 1 decimal point
                    priceAverageOutputLabel.Text = averageRoomRates.ToString("n1");

                }
                catch
                {
                    // Display the default error message.
                    MessageBox.Show("The average room rate is an invalid format or characters");
                }
            }
        }

        private void clearButton1_Click(object sender, EventArgs e)
        {
            roomRatesTextBoxY4.Text = "";
            roomRatesTextBoxY3.Text = "";
            roomRatesTextBoxY2.Text = "";
            priceAverageOutputLabel.Text = "";
            roomAverageRateTextBox.Text = "";
            discountPercentageTextBox.Text = "";
            outputRoomSalesRateLabel.Text = "";

            // Set the focus to nameTextBox.
            //Programmmers control the focus by the following syntax general method
            //ControlName.Focus();
            hotelOrLodgingTextBox.Focus();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            //Close the panel form
            this.Close();
        }

        private void calculateRevenueStreamButton_Click(object sender, EventArgs e)
        {
            {

                try
                {

                    int occupiedRooms;
                    decimal averageDailyRates;
                    decimal revenueStream;
                    occupiedRooms = int.Parse(occupiedRoomsTotalTextBox.Text);
                    averageDailyRates = decimal.Parse(averageDailyRoomRatesTextBox.Text);
                    revenueStream = (decimal)occupiedRooms * averageDailyRates;
                    outputFormulaLabel2.Text = (revenueStream.ToString("c"));

                }
                catch
                {
                    MessageBox.Show("Invalid integer.");
                }

                //
                String message;
                message = "It must be your Revenue depth is useful" + " " + "Thank you for telling us your estimate value";
                MessageBox.Show(message.ToString());

                //
                decimal amount = 0;
                MessageBox.Show(amount.ToString("c"));

                ///
                //decimal grossIncome = 00;
                //outputFormulaLabel2.Text = grossIncome.ToString();

                outputFormulaLabel2.BackColor = Color.White;
                outputFormulaLabel2.ForeColor = Color.Purple;
            }

        }


        private void displayOutputRevenue_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int occupiedRooms;
                    decimal averageDailyRates;
                    decimal revenueStream;
                    occupiedRooms = int.Parse(occupiedRoomsTotalTextBox.Text);
                    averageDailyRates = decimal.Parse(averageDailyRoomRatesTextBox.Text);
                    revenueStream = (decimal)occupiedRooms * averageDailyRates;
                    outputAnnualRevenueEarnedHotelTotalLabel1.Text = (revenueStream.ToString("n"));

                    outputAnnualRevenueEarnedHotelTotalLabel1.BackColor = Color.White;
                    outputAnnualRevenueEarnedHotelTotalLabel1.ForeColor = Color.Purple;

                }
                catch
                {
                    // Display the default error message.
                    MessageBox.Show("Invalid Character in Revenue Stream");
                }

            }

        }

        private void grossIncomeButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    decimal revenueStream;
                    decimal costOfRoomsSold;
                    decimal grossIncome;
                    //decimal.TryParse(outputsalesRevenueTextBox.Text, out grossIncome);
                    costOfRoomsSold = decimal.Parse(outputCostRoomsSoldTotalLabel.Text);
                    //string revenueStream = outputAnnualRevenueEarnedHotelTotalLabel1.Text;
                    revenueStream = decimal.Parse(outputAnnualRevenueEarnedHotelTotalLabel1.Text);
                    //grossIncome = decimal.Parse(grossIncomeLabel.Text);
                    grossIncome = revenueStream - costOfRoomsSold;
                    grossIncomeLabel.Text = (grossIncome.ToString("n"));

                    grossIncomeLabel.BackColor = Color.White;
                    grossIncomeLabel.ForeColor = Color.Purple;
                }
                catch
                {
                    // Display the tailored error message.
                    MessageBox.Show("The gross income has an invalid character or format");
                }
            }
        }

        private void calculateNetIncomeButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    decimal grossIncome;
                    decimal operatingExpenses;
                    double netIncome;
                    grossIncome = decimal.Parse(grossIncomeLabel.Text);
                    operatingExpenses = decimal.Parse(insertExcessExpensesTextBox.Text);
                    //netIncome = decimal.Parse(outputFormulaLabel3.Text);
                    netIncome = (double)grossIncome - (double)operatingExpenses;
                    outputFormulaLabel3.Text = (netIncome.ToString("c"));

                    outputFormulaLabel3.BackColor = Color.White;
                    outputFormulaLabel3.ForeColor = Color.Purple;
                }
                catch
                {
                    // Display the tailoed error message.
                    MessageBox.Show("Invalid character or format inputs in calculateNetIncomeButton control");
                }
            }
        }

        private void calculateSalesRevenueButton_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    double revenue1;    // To hold revenue year #1
                    double revenue2;    // To hold revenue year #2
                    double revenue3;    // To hold revenue year #3
                    double averageRevenuesGathered; // To hold the average revenue for market research, competition, standards and best price practice  

                    // Get the three revenues.
                    revenue3 = double.Parse(outputFormulaLabel2.Text);
                    revenue2 = double.Parse(outputAnnualRevenueEarnedHotelTotalLabel1.Text);
                    revenue1 = double.Parse(outputsalesRevenueTextBox.Text);

                    // Calculate the average revenue streams on site.
                    averageRevenuesGathered = (revenue3 + revenue2 + revenue1) / 3.0;

                    // Display the average test score, with
                    //The program instruction has rounded the                  
                    //output to 1 decimal point
                    averageRevenueTextBox.Text = averageRevenuesGathered.ToString("n");

                }
                catch (Exception ex)
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void calculateRoomRate_Click_1(object sender, EventArgs e)
        {

            {
                try
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
                    outputRoomSalesRateLabel.Text = roomSalesRate.ToString("n");

                }
                catch (Exception ex)
                {
                    // Display the default error message.
                    MessageBox.Show(ex.Message);
                }
                //finally
                //{
                //This code always runs
                //outputRoomSalesRateLabel.Text = "the try-catch block has completed.";
                // }
            }
        }

        private void costRoomsSalesTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            {
                //{
                //try
                //{
                //double costRoomsSalesTotal;
                //costRoomsSalesTotal = double.Parse(costRoomsSalesTotalTextBox.Text);
                //costRoomsSalesTotal++;
                //costRoomsSalesTotalTextBox.Text = (costRoomsSalesTotal.ToString("n3"));

                //}
                //catch (Exception ex)
                //{
                // Display the default error message.
                // MessageBox.Show(ex.Message);
                //}
                //}

            }
        }

        private void costRoomsGoodsSoldTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            {
                //try
                //{
                // double costRoomsGoodsSold;
                //costRoomsGoodsSold = double.Parse(costRoomsGoodsSoldTotalTextBox.Text);
                //costRoomsGoodsSold++;
                //costRoomsGoodsSoldTotalTextBox.Text = (costRoomsGoodsSold.ToString("n3"));

                //}
                //catch (Exception ex)
                //{
                // Display the default error message.
                // MessageBox.Show(ex.Message);
                // }
            }
        }

        private void calculateForDevelopment_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    //Names Constants 
                    const decimal MINIMUM_HOTELESTABLISHMENTNETINCOME = 30000000m;
                    const int MINIMUM_YEARS_IN_TOURISMATTRACTIONS = 10;             // More than 
                    const int MINIMUM_YEARS_IN_TOURISTDESTINATIONMARKETS = 10;      // Less than 
                    const double MINIMUM_PERCENTAGE_NETINCOMERETAILTOURISMTRADING = 0.4;

                    // Local variables 
                    decimal hotelEstablishmentNetIncome;
                    int yearsInServiceAsTourismAttractions;
                    int yearsInTouristDestinationMarketsWithValue;
                    double percentageOfNetIncomeFromRetailTourismTradingActivities;

                    // Get values from text boxes 
                    hotelEstablishmentNetIncome = decimal.Parse(hotelEstablishmentNetIncomeTextBox.Text);
                    yearsInServiceAsTourismAttractions = int.Parse(yearsInServiceAsTourismAttractionsTextBox.Text); 
                    yearsInTouristDestinationMarketsWithValue = int.Parse(yearsInTouristDestinationMarketsWithValueTextBox.Text); 
                    percentageOfNetIncomeFromRetailTourismTradingActivities = double.Parse(percentageOfNetIncomeFromRetailTourismTradingActivitesTextBox.Text);

                    // Determine qualification 
                    if (hotelEstablishmentNetIncome >= MINIMUM_HOTELESTABLISHMENTNETINCOME)
                    {
                        if (yearsInServiceAsTourismAttractions >= MINIMUM_YEARS_IN_TOURISMATTRACTIONS)
                        {
                            if (yearsInTouristDestinationMarketsWithValue >= MINIMUM_YEARS_IN_TOURISTDESTINATIONMARKETS)
                            {
                                if (percentageOfNetIncomeFromRetailTourismTradingActivities >= MINIMUM_PERCENTAGE_NETINCOMERETAILTOURISMTRADING)
                                {
                                    // The hotel component of the tourism industry qualifies for development 
                                    decisionLabel.Text = "You qualify for development in this tourism attraction or destination market based on hotel component net income, years as a tourist attraction, years in destination markets, and growth in retail tourism trading activities.";
                                }
                                else
                                {
                                    // Percentage of net income from retail tourism trading activities not met 
                                    decisionLabel.Text = "Percentage of retail tourism trading activities from net income not met. Tourism components do not qualify with this percentage.";
                                }
                            }
                            else
                            {
                                // Number of years in current tourist destination market not met 
                                decisionLabel.Text = "Number of years in current tourist destination market not met. Tourism components do not qualify.";
                            }
                        }
                        else
                        {
                            // Number of years in service as tourism attractions not met 
                            decisionLabel.Text = "Number of years in service as tourism attractions not met. Tourism component does not qualify with those number of years.";
                        }
                    }
                    else
                    {
                        // Minimum net income requirements not met 
                        decisionLabel.Text = "Minimum net income requirements not met.";
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message 
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void clearButton3_Click(object sender, EventArgs e)
        {
            hotelEstablishmentNetIncomeTextBox.Text="";
            yearsInServiceAsTourismAttractionsTextBox.Text = "";
            yearsInTouristDestinationMarketsWithValueTextBox.Text = "";
            percentageOfNetIncomeFromRetailTourismTradingActivitesTextBox.Text = "";
        }

        private void existButton3_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
