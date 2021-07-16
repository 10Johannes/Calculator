using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	public partial class MainForm : Form
	{
		Double result = 0, memory = 0;
		String operation = "";
		bool checkInput = false;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Numbers(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if ((textBoxDisplay.Text == "0") || (checkInput)){
				textBoxDisplay.Text = "";
			}
			checkInput = false;
			
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
				if (Convert.ToInt32(result) != 0){
					buttonEqual.PerformClick();
					checkInput = true;
					operation = btn.Text;
					labelMiniDisplay.Text +=  "  " + currValue + "  " + operation;
				} else {
					operation = btn.Text;
					result = Double.Parse(textBoxDisplay.Text);
					textBoxDisplay.Text = "";
					labelMiniDisplay.Text +=  "  " + currValue + "  " + operation;
				}
			} catch (Exception err) {

			}
		}
		
		void ButtonEqualClick(object sender, EventArgs e)
		{
			String currValue = textBoxDisplay.Text;
			switch (operation){
				case "+":
					textBoxDisplay.Text = (result + Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
				case "-":
					textBoxDisplay.Text = (result - Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
				case "*":
					textBoxDisplay.Text = (result * Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
				case "/":
					textBoxDisplay.Text = (result / Convert.ToDouble(textBoxDisplay.Text)).ToString();
					break;
			}
			result = Convert.ToDouble(textBoxDisplay.Text);
	
			operation = "";
			checkInput = true;
		}
		
		void ButtonClearEntryClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = "0";
		}
		
		void ButtonClearClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = "0";
			labelMiniDisplay.Text = "";
			result = 0;
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
			textBoxDisplay.Text = Convert.ToString((Convert.ToDouble(textBoxDisplay.Text)/100)*result);
		}
		
		void ButtonReciprocateClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = Convert.ToString(1/Convert.ToDouble(textBoxDisplay.Text));
		}
		
		void ButtonMCClick(object sender, EventArgs e)
		{
			memory = 0;
		}
		
		void ButtonMRClick(object sender, EventArgs e)
		{
			textBoxDisplay.Text = Convert.ToString(memory);
		}
		
		void ButtonMSClick(object sender, EventArgs e)
		{
			memory = Convert.ToDouble(textBoxDisplay.Text);
		}
		
		void ButtonMAddClick(object sender, EventArgs e)
		{
			memory += Convert.ToDouble(textBoxDisplay.Text);
		}
		
		void ButtonMSubClick(object sender, EventArgs e)
		{
			memory -= Convert.ToDouble(textBoxDisplay.Text);
		}
	}
}