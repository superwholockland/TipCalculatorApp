namespace MauiApp1;

public partial class MainPage : ContentPage
{
	decimal number1 = 0;
	decimal number2 = 0;
    decimal tip = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void Calculate_Tip(object sender, EventArgs e)
	{
		//this function takes in an percentage and a monetary amount, stored as a decimal
		//and outputs a tip in dollar amounts rounded to two decimal places
        //adding in a feature to add calculated tip amount to original bill

        if (Decimal.TryParse(input1.Text, out number1) && Decimal.TryParse(input2.Text, out number2))
		{
            tip = 0;
			tip = (number1 / 100) * number2;
            OutputOne.Text = "= $"+ Math.Round(tip, 2, MidpointRounding.AwayFromZero).ToString();
            Add_Tip_to_Total(number2, tip);
        }
	}

    private void Clear_Calculate_Tip(object sender, EventArgs e)
    {
        input1.Text = null;
        input2.Text = null;
        OutputOne.Text = "= $";
        OutputThree.Text = null;
    }

    private void Add_Tip_to_Total(decimal bill, decimal tipAmount)
    {
            OutputThree.Text = "$" + number2 + " +  tip $" + Math.Round(tip, 2) + " = $" + (number2 + Math.Round(tip, 2)).ToString();
    }

    private void Calculate_Tip_Percentage(object sender, EventArgs e)
    {
        //this function takes in two monetary amounts, stored as a decimal
        //and outputs a percent, which is the first number divided by the second
        //and round the output to 2 decimal places

        if (Decimal.TryParse(input3.Text, out number1) && Decimal.TryParse(input4.Text, out number2))
        {
            tip = 0;
            tip = (number1 / number2) * 100;
            OutputTwo.Text = "= " + Math.Round(tip, 2, MidpointRounding.AwayFromZero).ToString() + "%";
            number1 = 0;
            number2 = 0;
        }
    }

    private void Clear_Tip_Percentage()
    {
        input3.Text = null; 
        input4.Text = null;
        OutputTwo.Text = "= %";
    }
}