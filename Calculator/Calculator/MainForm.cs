using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MainForm : Form
	{
		calcVariables calc = new calcVariables();
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Numbers(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if ((textBoxDisplay.Text == "0") || (calc.CheckInput)){
				textBoxDisplay.Text = "";
			}
			calc.CheckInput = false;
			
			if (btn.Text == "."){
				if(!textBoxDisplay.Text.Contains(".")){
					textBoxDisplay.Text = textBoxDisplay.Text + btn.Text;
				}
			} else {
				textBoxDisplay.Text = textBoxDisplay.Text + btn.Text;
			}
		}
		
		void Operators(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			String currValue = textBoxDisplay.Text;
			try {
				if (Convert.ToInt32(calc.Result) != 0){
					buttonEqual.PerformClick();
					calc.CheckInput = true;
					calc.Operation = btn.Text;
					labelMiniDisplay.Text +=  "  " + currValue + "  " + calc.Operation;
				} else {
					calc.Operation = btn.Text;
					calc.Result = Double.Parse(textBoxDisplay.Text);
					textBoxDisplay.Text = "";
					labelMiniDisplay.Text +=  "  " + currValue + "  " + calc.Operation;
				}
			} catch (Exception err) {

			}
		}
		
		void ButtonEqualClick(object sender, EventArgs e)
		{
			String currValue = textBoxDisplay.Text;
			switch (calc.Operation){
				case "+":
					textBoxDisplay.Text = (calc.Result + Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
				case "-":
					textBoxDisplay.Text = (calc.Result - Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
				case "*":
					textBoxDisplay.Text = (calc.Result * Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
				case "/":
					textBoxDisplay.Text = (calc.Result / Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
			}
			calc.Result = Convert.ToDouble(textBoxDisplay.Text);
	
			calc.Operation = "";
			calc.CheckInput = true;
		}
		
		void ButtonClearEntryClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = "0";
		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = "0";
			labelMiniDisplay.Text = "";
			calc.Result = 0;
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			if (textBoxDisplay.Text.Length > 0){
				textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
			}
			
			if (textBoxDisplay.Text == ""){
				textBoxDisplay.Text = "0";
			}
		}
		
		void ButtonSignClick(object sender, EventArgs e)
		{
			if (textBoxDisplay.Text.Contains("-")){
			    textBoxDisplay.Text = textBoxDisplay.Text.Remove(0, 1);
			} else {
				if (textBoxDisplay.Text != "0"){
					textBoxDisplay.Text = "-" + textBoxDisplay.Text;
				}
			}
		}
		
		void ButtonSquareRootClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBoxDisplay.Text)));
		}
		
		void ButtonPercentClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = Convert.ToString((Convert.ToDouble(textBoxDisplay.Text)/100)*calc.Result);
		}
		
		void ButtonReciprocateClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = Convert.ToString(1/Convert.ToDouble(textBoxDisplay.Text));
		}
		
		void ButtonMCClick(object sender, EventArgs e)
		{
			calc.Memory = 0;
		}
		
		void ButtonMRClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = Convert.ToString(calc.Memory);
		}
		
		void ButtonMSClick(object sender, EventArgs e)
		{
			calc.Memory = Convert.ToDouble(textBoxDisplay.Text);
		}
		
		void ButtonMAddClick(object sender, EventArgs e)
		{
			calc.Memory += Convert.ToDouble(textBoxDisplay.Text);
		}
		
		void ButtonMSubClick(object sender, EventArgs e)
		{
			calc.Memory -= Convert.ToDouble(textBoxDisplay.Text);
		}
	}
}