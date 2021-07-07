/*
 * Created by SharpDevelop.
 * User: John Rey B. Macascas
 * Date: 5/21/2021
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		float result = 0;
		String operation = "";
		bool checkInput = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void TextBoxDisplayTextChanged(object sender, EventArgs e)
		{
	
		}
		void Numbers(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			if ((textBoxDisplay.Text == "") || (checkInput)){
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
			operation = btn.Text;
			result = float.Parse(textBoxDisplay.Text);
			textBoxDisplay.Text = "";
			labelMiniDisplay.Text = labelMiniDisplay.Text + "  " +System.Convert.ToString(result) + "  " + operation;
		}
	}
}
