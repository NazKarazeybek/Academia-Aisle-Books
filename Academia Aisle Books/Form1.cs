using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //required to commands like Thread.Sleep();
using System.Media; //required to use media in properties (audio, etc.)

namespace Academia_Aisle_Books
{
    public partial class BackgroundImage : Form
    {

        //setting prices for the books (shared)

        double horrorBookPrice = 9.25;
        double romanceBookPrice = 7.75;
        double fantasyBookPrice = 12.50;

        //turning # of objects into integer(int)

        int numOfHorrorBook;
        int numOfRomanceBook;
        int numOfFantasyBook;

        //setting tax rate and creating double variables

        double taxRate = 0.13;
        double subtotal;
        double taxAmount;
        double totalPrice;
        double tenderedAmount;
        double changeAmount;



        public BackgroundImage()
        {
            InitializeComponent();

            // Set the icon for the form
            //this.Icon = new System.Drawing.Icon("bookstoreicon.ico");

            // Disabling buttons except for the initial Calculate button
            printReceiptButton.Enabled = false;
            calculateChangeButton.Enabled = false;
            calculateTotalButton.Enabled = true; // Initial button enabled


            //changing the opacity of the panel
            registerPanel.BackColor = Color.FromArgb(145, Color.AntiqueWhite);

        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            //adding sound effects
            SoundPlayer player = new SoundPlayer(Properties.Resources.pageFlipSound);
            player.Play();

            try
            {
                tenderedAmount = Convert.ToInt32(tenderedInput.Text);

                //if statement(i watched a video) if tendered amount is less then total price show a message box error
                if (tenderedAmount < totalPrice)
                {
                    MessageBox.Show("Tendered amount must be greater than or equal to the total amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method
                }


                changeAmount = tenderedAmount - totalPrice;
                changeOutputLabel.Text = $"{changeAmount.ToString("C")}";

                // Enable the next operation button
                printReceiptButton.Enabled = true;
            }
            catch
            {
                changeOutputLabel.Text = "ERROR";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {

            //adding sound effects
            SoundPlayer player = new SoundPlayer(Properties.Resources.printReceiptSound);
            player.Play();

            //added a pause (it worked better for the design part)
            Thread.Sleep(500);

            //initializing variables and constructing receipt output text


            string shopName = "\n\n           Academia Aisle Books";
            string receiptNumber = "Receipt Number 2024";
            string receiptDate = "February 24, 2024";
            string endingPhrase1 = "    Thank You For Your Purchase!";
            string endingPhrase2 = "             Have A Lovely Day!";


            receiptOutputLabel.Text =

        $"{shopName}\n" +
        $"\n\n{receiptNumber}\n" +
        $"{receiptDate}\n\n\n" +
        $"Fantasy Books ↬      🕮{numOfFantasyBook}    {fantasyBookPrice * numOfFantasyBook:C}\n" +
        $"Romance Books ↬   🕮{numOfRomanceBook}    {romanceBookPrice * numOfRomanceBook:C}\n" +
        $"Horror Books ↬       🕮{numOfHorrorBook}    {horrorBookPrice * numOfHorrorBook:C}\n\n\n" +
        $"Subtotal:                             {subtotal:C}\n" +
        $"Tax:                                    {taxAmount:C}\n" +
        $"Total:                                  {totalPrice:C}\n\n" +
        $"\nTendered:                            {tenderedAmount:C}\n" +
        $"Change:                              {changeAmount:C}\n\n" +
        $"\n{endingPhrase1}" +
        $"\n{endingPhrase2}\n";
             

        }


        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            //adding sound effects
            SoundPlayer player = new SoundPlayer(Properties.Resources.pageFlipSound);
            player.Play();

            // Enable the next operation button
            calculateChangeButton.Enabled = true;


            try
            {

                //convert text to integers
                numOfFantasyBook = Convert.ToInt32(fantasyBookInput.Text);
                numOfRomanceBook = Convert.ToInt32(romanceBookInput.Text);
                numOfHorrorBook = Convert.ToInt32(horrorBookInput.Text);

                // Calculate subtotal, tax amount, and total price
                subtotal = fantasyBookPrice * numOfFantasyBook + romanceBookPrice * numOfRomanceBook + horrorBookPrice * numOfHorrorBook;
                taxAmount = taxRate * subtotal;
                totalPrice = subtotal + taxAmount;

                //to make it two decimals
                subtotalOutputLabel.Text = $"{subtotal.ToString("C")}";
                taxOutputLabel.Text = $"{taxAmount.ToString("C")}";
                totalOutputLabel.Text = $"{totalPrice.ToString("C")}";

            }
            //If an exception occurs, it sets the subtotalOutputLabel to display "ERROR" and clears the taxOutputLabel and totalOutputLabel.
            catch
            {
                subtotalOutputLabel.Text = "ERROR";
                taxOutputLabel.Text = string.Empty;
                totalOutputLabel.Text = string.Empty;
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {

            //adding sound effects
            SoundPlayer player = new SoundPlayer(Properties.Resources.pageFlipSound);
            player.Play();


            // Clear input boxes
            fantasyBookInput.Text = "";
            romanceBookInput.Text = "";
            horrorBookInput.Text = "";
            tenderedInput.Text = "";

            // Clear output areas
            subtotalOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";
            changeOutputLabel.Text = "";
            receiptOutputLabel.Text = "";

            // Reset variables to 0
            numOfHorrorBook = 0;
            numOfRomanceBook = 0;
            numOfFantasyBook = 0;
            subtotal = 0;
            taxAmount = 0;
            totalPrice = 0;
            tenderedAmount = 0;
            changeAmount = 0;
        }

        private void closeShopButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}