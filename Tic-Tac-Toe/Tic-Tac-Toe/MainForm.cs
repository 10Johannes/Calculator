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
		bool isXWin, isOWin;
		void resetter(){
			try {
				for (byte i = 1; i < 10; i++)
				    {
				        string btnName = "btnTic" + i;
				        this.Controls[btnName].Enabled = true;
				        this.Controls[btnName].Text = "";
				        this.Controls[btnName].BackColor = Color.WhiteSmoke;
				    }
				buttonNewGame.Enabled = true;
			} catch (Exception err) {
				MessageBox.Show(err.Message, "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void winnerChecker(){
			Button[] btnArray = {btnTic1, btnTic2, btnTic3,
			btnTic4, btnTic5, btnTic6, btnTic7, btnTic8, btnTic9};
			
			// Horizontal Wins
			for (byte i = 0; i < btnArray.Length; i+=3){
				isXWin = (btnArray[i].Text == "X" &&
				     btnArray[i+1].Text == "X" && btnArray[i+2].Text == "X") ? true : false;
				isOWin = (btnArray[i].Text == "O" &&
				     btnArray[i+1].Text == "O" && btnArray[i+2].Text == "O") ? true : false;
				if (isXWin){
					btnArray[i].BackColor = Color.Chartreuse;
					btnArray[i+1].BackColor = Color.Chartreuse;
				    btnArray[i+2].BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (isOWin){
					btnArray[i].BackColor = Color.Chartreuse;
					btnArray[i+1].BackColor = Color.Chartreuse;
				    btnArray[i+2].BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
			}
			
			// Vertical Wins 
			for (byte i = 0; i < 3; i++){
				isXWin = (btnArray[i].Text == "X" &&
				     btnArray[i+3].Text == "X" && btnArray[i+6].Text == "X") ? true : false;
				isOWin = (btnArray[i].Text == "O" &&
				     btnArray[i+3].Text == "O" && btnArray[i+6].Text == "O") ? true : false;
				if (isXWin){
					btnArray[i].BackColor = Color.Chartreuse;
					btnArray[i+3].BackColor = Color.Chartreuse;
				    btnArray[i+6].BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 1!", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore1.Text);
					labelScore1.Text = Convert.ToString(addScore + 1);
					resetter();
				}
				if (isOWin){
					btnArray[i].BackColor = Color.Chartreuse;
					btnArray[i+3].BackColor = Color.Chartreuse;
				    btnArray[i+6].BackColor = Color.Chartreuse;
					MessageBox.Show("The winner is Player 2!", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
					addScore = int.Parse(labelScore2.Text);
					labelScore2.Text = Convert.ToString(addScore + 1);
					resetter();
				}
			}
			
			//Across Win
			bool isXWinAcross1 = (btnArray[0].Text == "X" &&
				     btnArray[4].Text == "X" && btnArray[8].Text == "X") ? true : false;
			bool isOWinAcross1 = (btnArray[0].Text == "O" &&
				     btnArray[4].Text == "O" && btnArray[8].Text == "O") ? true : false;
			bool isXWinAcross2 = (btnArray[2].Text == "X" &&
				     btnArray[4].Text == "X" && btnArray[6].Text == "X") ? true : false;
			bool isOWinAcross2 = (btnArray[2].Text == "O" &&
				     btnArray[4].Text == "O" && btnArray[6].Text == "O") ? true : false;
			
			if ((isXWinAcross1) || (isXWinAcross2)){
				if(btnArray[0].Text == "X"){
					btnArray[0].BackColor = Color.Chartreuse;
					btnArray[4].BackColor = Color.Chartreuse;
				    btnArray[8].BackColor = Color.Chartreuse;				
				}
				if (btnArray[2].Text == "X"){
					btnArray[2].BackColor = Color.Chartreuse;
					btnArray[4].BackColor = Color.Chartreuse;
				    btnArray[6].BackColor = Color.Chartreuse;				
				}
				MessageBox.Show("The winner is Player 1!", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				addScore = int.Parse(labelScore1.Text);
				labelScore1.Text = Convert.ToString(addScore + 1);
				resetter();
				resetter();
			}
			if ((isOWinAcross1) || (isOWinAcross2)){
				if(btnArray[0].Text == "O"){
					btnArray[0].BackColor = Color.Chartreuse;
					btnArray[4].BackColor = Color.Chartreuse;
				    btnArray[8].BackColor = Color.Chartreuse;				
				}
				if (btnArray[2].Text == "O"){
					btnArray[2].BackColor = Color.Chartreuse;
					btnArray[4].BackColor = Color.Chartreuse;
				    btnArray[6].BackColor = Color.Chartreuse;				
				}
				MessageBox.Show("The winner is Player 2!", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				addScore = int.Parse(labelScore2.Text);
				labelScore2.Text = Convert.ToString(addScore + 1);
				resetter();
			}
			//Draw
			if(btnTic1.Text != "" && btnTic2.Text != "" && btnTic3.Text != "" &&
			  	btnTic4.Text != "" && btnTic5.Text != "" && btnTic6.Text != "" &&
			  	btnTic7.Text != "" && btnTic8.Text != "" && btnTic9.Text != ""){
					MessageBox.Show("It's a draw!", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				for (byte i = 1; i < 10; i++)
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
				MessageBox.Show(err.Message, "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void ButtonQuitClick(object sender, EventArgs e)
		{
			
			try {
				DialogResult quit;
				quit = MessageBox.Show("Do you really want to quit the game?", "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
				if (quit == DialogResult.OK) {
					Application.Exit();
				}
			} catch (Exception err) {
				MessageBox.Show(err.Message, "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		void ButtonResetClick(object sender, EventArgs e)
		{
			try {
				for (byte i = 1; i < 10; i++)
				    {
				        string btnName = "btnTic" + i;
				        this.Controls[btnName].Enabled = true;
				        this.Controls[btnName].Text = "";
				        this.Controls[btnName].BackColor = Color.WhiteSmoke;
				    }
				buttonNewGame.Enabled = true;
			} catch (Exception err) {
				MessageBox.Show(err.Message, "Tic-Tac-Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
