/*
 * Created by SharpDevelop.
 * User: John Rey B. Macascas
 * Date: 5/28/2021
 * Time: 12:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Boolean checker;
		int addScore;
		
		void resetter(){
			try {
				for (int i = 1; i < 10; i++)
				    {
				        string btnName = "btnTic" + i;
				        this.Controls[btnName].Enabled = true;
				        this.Controls[btnName].Text = "";
				        this.Controls[btnName].BackColor = Color.WhiteSmoke;
				    }
				buttonNewGame.Enabled = true;
			} catch (Exception err) {
				MessageBox.Show(err.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void winnerChecker(){
			// Horizontal X Wins 
				if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X"){
					btnTic1.BackColor = Color.Chartreuse;
					btnTic2.BackColor = Color.Chartreuse;
					btnTic3.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X"){
					btnTic4.BackColor = Color.Chartreuse;
					btnTic5.BackColor = Color.Chartreuse;
					btnTic6.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X"){
					btnTic7.BackColor = Color.Chartreuse;
					btnTic8.BackColor = Color.Chartreuse;
					btnTic9.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
			
			// Horizontal O Wins 
				if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O"){
					btnTic1.BackColor = Color.Chartreuse;
					btnTic2.BackColor = Color.Chartreuse;
					btnTic3.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O"){
					btnTic4.BackColor = Color.Chartreuse;
					btnTic5.BackColor = Color.Chartreuse;
					btnTic6.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O"){
					btnTic7.BackColor = Color.Chartreuse;
					btnTic8.BackColor = Color.Chartreuse;
					btnTic9.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
			
			// Vertical X Wins 
				if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X"){
					btnTic1.BackColor = Color.Chartreuse;
					btnTic4.BackColor = Color.Chartreuse;
					btnTic7.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X"){
					btnTic2.BackColor = Color.Chartreuse;
					btnTic5.BackColor = Color.Chartreuse;
					btnTic8.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X"){
					btnTic3.BackColor = Color.Chartreuse;
					btnTic6.BackColor = Color.Chartreuse;
					btnTic9.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
			
			// Vertical O Wins 
				if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O"){
					btnTic1.BackColor = Color.Chartreuse;
					btnTic4.BackColor = Color.Chartreuse;
					btnTic7.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O"){
					btnTic2.BackColor = Color.Chartreuse;
					btnTic5.BackColor = Color.Chartreuse;
					btnTic8.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O"){
					btnTic3.BackColor = Color.Chartreuse;
					btnTic6.BackColor = Color.Chartreuse;
					btnTic9.BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
			
			//Across X Win
				if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X"){
						btnTic1.BackColor = Color.Chartreuse;
						btnTic5.BackColor = Color.Chartreuse;
						btnTic9.BackColor = Color.Chartreuse;
						MessageBox.Show("The winner is Player 1!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
						addScore = int.Parse(labelScore1.Text);
						labelScore1.Text = Convert.ToString(addScore + 1);
						resetter();
				}
			
			//Across O Win
				if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O"){
						btnTic1.BackColor = Color.Chartreuse;
						btnTic5.BackColor = Color.Chartreuse;
						btnTic9.BackColor = Color.Chartreuse;
						MessageBox.Show("The winner is Player 2!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
						addScore = int.Parse(labelScore2.Text);
						labelScore2.Text = Convert.ToString(addScore + 1);
						resetter();
				}
		}
		
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
		void BtnTic1Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic1.Text = "X";
				checker = true;
			}
			else {
				btnTic1.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic1.Enabled = false;
		}
		void BtnTic2Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic2.Text = "X";
				checker = true;
			}
			else {
				btnTic2.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic2.Enabled = false;
		}
		void BtnTic3Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic3.Text = "X";
				checker = true;
			}
			else {
				btnTic3.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic3.Enabled = false;
		}
		void BtnTic4Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic4.Text = "X";
				checker = true;
			}
			else {
				btnTic4.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic4.Enabled = false;
		}
		void BtnTic5Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic5.Text = "X";
				checker = true;
			}
			else {
				btnTic5.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic5.Enabled = false;
		}
		void BtnTic6Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic6.Text = "X";
				checker = true;
			}
			else {
				btnTic6.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic6.Enabled = false;
		}
		void BtnTic7Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic7.Text = "X";
				checker = true;
			}
			else {
				btnTic7.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic7.Enabled = false;
		}
		void BtnTic8Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic8.Text = "X";
				checker = true;
			}
			else {
				btnTic8.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic8.Enabled = false;
		}
		void BtnTic9Click(object sender, EventArgs e)
		{
			if (checker == false){
				btnTic9.Text = "X";
				checker = true;
			}
			else {
				btnTic9.Text = "O";
				checker = false;
			}
			winnerChecker();
			btnTic9.Enabled = false;
		}
		void ButtonNewGameClick(object sender, EventArgs e)
		{
			try {
				for (int i = 1; i < 10; i++)
				    {
				        string btnName = "btnTic" + i;
				        this.Controls[btnName].Enabled = true;
				        this.Controls[btnName].Text = "";
				        this.Controls[btnName].BackColor = Color.WhiteSmoke;
				    }
				labelScore1.Text = "0";
				labelScore2.Text = "0";
				buttonNewGame.Enabled = true;
			} catch (Exception err) {
				MessageBox.Show(err.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void ButtonQuitClick(object sender, EventArgs e)
		{
			try {
				DialogResult quit;
				quit = MessageBox.Show("Do you really want to quit the game?", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (quit == DialogResult.OK) {
					Application.Exit();
				}
			} catch (Exception err) {
				MessageBox.Show(err.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void ButtonResetClick(object sender, EventArgs e)
		{
			try {
				for (int i = 1; i < 10; i++)
				    {
				        string btnName = "btnTic" + i;
				        this.Controls[btnName].Enabled = true;
				        this.Controls[btnName].Text = "";
				        this.Controls[btnName].BackColor = Color.WhiteSmoke;
				    }
				buttonNewGame.Enabled = true;
			} catch (Exception err) {
				MessageBox.Show(err.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
