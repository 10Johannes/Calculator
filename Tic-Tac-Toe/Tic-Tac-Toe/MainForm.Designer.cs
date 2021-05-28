/*
 * Created by SharpDevelop.
 * User: John Rey B. Macascas
 * Date: 5/28/2021
 * Time: 12:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tic_Tac_Toe
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnTic7;
		private System.Windows.Forms.Button btnTic8;
		private System.Windows.Forms.Button btnTic9;
		private System.Windows.Forms.Button btnTic6;
		private System.Windows.Forms.Button btnTic5;
		private System.Windows.Forms.Button btnTic4;
		private System.Windows.Forms.Button btnTic3;
		private System.Windows.Forms.Button btnTic2;
		private System.Windows.Forms.Button btnTic1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label labelScore2;
		private System.Windows.Forms.Label labelPlayer2;
		private System.Windows.Forms.Label labelScore1;
		private System.Windows.Forms.Label labelPlayer1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button buttonQuit;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonNewGame;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTic7 = new System.Windows.Forms.Button();
			this.btnTic8 = new System.Windows.Forms.Button();
			this.btnTic9 = new System.Windows.Forms.Button();
			this.btnTic6 = new System.Windows.Forms.Button();
			this.btnTic5 = new System.Windows.Forms.Button();
			this.btnTic4 = new System.Windows.Forms.Button();
			this.btnTic3 = new System.Windows.Forms.Button();
			this.btnTic2 = new System.Windows.Forms.Button();
			this.btnTic1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelScore2 = new System.Windows.Forms.Label();
			this.labelPlayer2 = new System.Windows.Forms.Label();
			this.labelScore1 = new System.Windows.Forms.Label();
			this.labelPlayer1 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonNewGame = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTic7
			// 
			this.btnTic7.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic7.Location = new System.Drawing.Point(22, 215);
			this.btnTic7.Name = "btnTic7";
			this.btnTic7.Size = new System.Drawing.Size(60, 60);
			this.btnTic7.TabIndex = 0;
			this.btnTic7.UseVisualStyleBackColor = false;
			// 
			// btnTic8
			// 
			this.btnTic8.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic8.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic8.Location = new System.Drawing.Point(88, 215);
			this.btnTic8.Name = "btnTic8";
			this.btnTic8.Size = new System.Drawing.Size(60, 60);
			this.btnTic8.TabIndex = 1;
			this.btnTic8.UseVisualStyleBackColor = false;
			// 
			// btnTic9
			// 
			this.btnTic9.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic9.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic9.Location = new System.Drawing.Point(154, 215);
			this.btnTic9.Name = "btnTic9";
			this.btnTic9.Size = new System.Drawing.Size(60, 60);
			this.btnTic9.TabIndex = 2;
			this.btnTic9.UseVisualStyleBackColor = false;
			// 
			// btnTic6
			// 
			this.btnTic6.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic6.Location = new System.Drawing.Point(154, 149);
			this.btnTic6.Name = "btnTic6";
			this.btnTic6.Size = new System.Drawing.Size(60, 60);
			this.btnTic6.TabIndex = 5;
			this.btnTic6.UseVisualStyleBackColor = false;
			// 
			// btnTic5
			// 
			this.btnTic5.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic5.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic5.Location = new System.Drawing.Point(88, 149);
			this.btnTic5.Name = "btnTic5";
			this.btnTic5.Size = new System.Drawing.Size(60, 60);
			this.btnTic5.TabIndex = 4;
			this.btnTic5.UseVisualStyleBackColor = false;
			// 
			// btnTic4
			// 
			this.btnTic4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic4.Location = new System.Drawing.Point(22, 149);
			this.btnTic4.Name = "btnTic4";
			this.btnTic4.Size = new System.Drawing.Size(60, 60);
			this.btnTic4.TabIndex = 3;
			this.btnTic4.UseVisualStyleBackColor = false;
			// 
			// btnTic3
			// 
			this.btnTic3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic3.Location = new System.Drawing.Point(154, 83);
			this.btnTic3.Name = "btnTic3";
			this.btnTic3.Size = new System.Drawing.Size(60, 60);
			this.btnTic3.TabIndex = 8;
			this.btnTic3.UseVisualStyleBackColor = false;
			// 
			// btnTic2
			// 
			this.btnTic2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic2.Location = new System.Drawing.Point(88, 83);
			this.btnTic2.Name = "btnTic2";
			this.btnTic2.Size = new System.Drawing.Size(60, 60);
			this.btnTic2.TabIndex = 7;
			this.btnTic2.UseVisualStyleBackColor = false;
			// 
			// btnTic1
			// 
			this.btnTic1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnTic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTic1.Location = new System.Drawing.Point(22, 83);
			this.btnTic1.Name = "btnTic1";
			this.btnTic1.Size = new System.Drawing.Size(60, 60);
			this.btnTic1.TabIndex = 6;
			this.btnTic1.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelTitle);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 50);
			this.panel1.TabIndex = 9;
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.Location = new System.Drawing.Point(10, 6);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(338, 31);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Tic-Tac-Toe Game";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(12, 73);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(212, 215);
			this.panel2.TabIndex = 10;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.labelScore2);
			this.panel3.Controls.Add(this.labelPlayer2);
			this.panel3.Controls.Add(this.labelScore1);
			this.panel3.Controls.Add(this.labelPlayer1);
			this.panel3.Location = new System.Drawing.Point(235, 73);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(137, 215);
			this.panel3.TabIndex = 11;
			// 
			// labelScore2
			// 
			this.labelScore2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelScore2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelScore2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelScore2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelScore2.Location = new System.Drawing.Point(12, 146);
			this.labelScore2.Name = "labelScore2";
			this.labelScore2.Size = new System.Drawing.Size(113, 31);
			this.labelScore2.TabIndex = 4;
			this.labelScore2.Text = "0";
			this.labelScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPlayer2
			// 
			this.labelPlayer2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPlayer2.Location = new System.Drawing.Point(12, 115);
			this.labelPlayer2.Name = "labelPlayer2";
			this.labelPlayer2.Size = new System.Drawing.Size(113, 31);
			this.labelPlayer2.TabIndex = 3;
			this.labelPlayer2.Text = "Player 2:";
			this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelScore1
			// 
			this.labelScore1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.labelScore1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelScore1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelScore1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labelScore1.Location = new System.Drawing.Point(12, 54);
			this.labelScore1.Name = "labelScore1";
			this.labelScore1.Size = new System.Drawing.Size(113, 31);
			this.labelScore1.TabIndex = 2;
			this.labelScore1.Text = "0";
			this.labelScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPlayer1
			// 
			this.labelPlayer1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPlayer1.Location = new System.Drawing.Point(12, 23);
			this.labelPlayer1.Name = "labelPlayer1";
			this.labelPlayer1.Size = new System.Drawing.Size(113, 31);
			this.labelPlayer1.TabIndex = 1;
			this.labelPlayer1.Text = "Player 1:";
			this.labelPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.buttonQuit);
			this.panel4.Controls.Add(this.buttonReset);
			this.panel4.Controls.Add(this.buttonNewGame);
			this.panel4.Location = new System.Drawing.Point(12, 299);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(360, 51);
			this.panel4.TabIndex = 12;
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(273, 10);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(75, 31);
			this.buttonQuit.TabIndex = 2;
			this.buttonQuit.Text = "Quit Game";
			this.buttonQuit.UseVisualStyleBackColor = true;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(143, 10);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(75, 31);
			this.buttonReset.TabIndex = 1;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			// 
			// buttonNewGame
			// 
			this.buttonNewGame.Location = new System.Drawing.Point(10, 10);
			this.buttonNewGame.Name = "buttonNewGame";
			this.buttonNewGame.Size = new System.Drawing.Size(75, 31);
			this.buttonNewGame.TabIndex = 0;
			this.buttonNewGame.Text = "New Game";
			this.buttonNewGame.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 362);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnTic3);
			this.Controls.Add(this.btnTic2);
			this.Controls.Add(this.btnTic1);
			this.Controls.Add(this.btnTic6);
			this.Controls.Add(this.btnTic5);
			this.Controls.Add(this.btnTic4);
			this.Controls.Add(this.btnTic9);
			this.Controls.Add(this.btnTic8);
			this.Controls.Add(this.btnTic7);
			this.Controls.Add(this.panel2);
			this.Name = "MainForm";
			this.Text = "Tic-Tac-Toe";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
