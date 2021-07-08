/*
 * Created by SharpDevelop.
 * User: www.rica.com
 * Date: 5/21/2021
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button buttonPoint;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDivide;
		private System.Windows.Forms.Button buttonMultiply;
		private System.Windows.Forms.Button buttonSubtract;
		private System.Windows.Forms.Button buttonEqual;
		private System.Windows.Forms.Button buttonPercent;
		private System.Windows.Forms.Button buttonReciprocate;
		private System.Windows.Forms.Button buttonSquareRoot;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonClearEntry;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxDisplay;
		private System.Windows.Forms.Button buttonSign;
		private System.Windows.Forms.Button buttonMAdd;
		private System.Windows.Forms.Button buttonMSub;
		private System.Windows.Forms.Button buttonMS;
		private System.Windows.Forms.Button buttonMR;
		private System.Windows.Forms.Button buttonMC;
		private System.Windows.Forms.Label labelMiniDisplay;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.buttonPoint = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDivide = new System.Windows.Forms.Button();
			this.buttonMultiply = new System.Windows.Forms.Button();
			this.buttonSubtract = new System.Windows.Forms.Button();
			this.buttonEqual = new System.Windows.Forms.Button();
			this.buttonPercent = new System.Windows.Forms.Button();
			this.buttonReciprocate = new System.Windows.Forms.Button();
			this.buttonSquareRoot = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonClearEntry = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxDisplay = new System.Windows.Forms.TextBox();
			this.buttonSign = new System.Windows.Forms.Button();
			this.buttonMAdd = new System.Windows.Forms.Button();
			this.buttonMSub = new System.Windows.Forms.Button();
			this.buttonMS = new System.Windows.Forms.Button();
			this.buttonMR = new System.Windows.Forms.Button();
			this.buttonMC = new System.Windows.Forms.Button();
			this.labelMiniDisplay = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 217);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(33, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Numbers);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(54, 217);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(33, 27);
			this.button2.TabIndex = 1;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Numbers);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(93, 217);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(33, 27);
			this.button3.TabIndex = 2;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Numbers);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(16, 185);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(33, 27);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Numbers);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(54, 185);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(33, 27);
			this.button5.TabIndex = 4;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Numbers);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(93, 185);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(33, 27);
			this.button6.TabIndex = 5;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Numbers);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(16, 153);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(33, 27);
			this.button7.TabIndex = 6;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Numbers);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(54, 153);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(33, 27);
			this.button8.TabIndex = 7;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Numbers);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(93, 153);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(33, 27);
			this.button9.TabIndex = 8;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Numbers);
			// 
			// button0
			// 
			this.button0.Location = new System.Drawing.Point(15, 249);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(72, 27);
			this.button0.TabIndex = 9;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.Numbers);
			// 
			// buttonPoint
			// 
			this.buttonPoint.Location = new System.Drawing.Point(93, 249);
			this.buttonPoint.Name = "buttonPoint";
			this.buttonPoint.Size = new System.Drawing.Size(33, 27);
			this.buttonPoint.TabIndex = 10;
			this.buttonPoint.Text = ".";
			this.buttonPoint.UseVisualStyleBackColor = true;
			this.buttonPoint.Click += new System.EventHandler(this.Numbers);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(132, 249);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(33, 27);
			this.buttonAdd.TabIndex = 14;
			this.buttonAdd.Text = "+";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.Operators);
			// 
			// buttonDivide
			// 
			this.buttonDivide.Location = new System.Drawing.Point(132, 153);
			this.buttonDivide.Name = "buttonDivide";
			this.buttonDivide.Size = new System.Drawing.Size(33, 27);
			this.buttonDivide.TabIndex = 13;
			this.buttonDivide.Text = "/";
			this.buttonDivide.UseVisualStyleBackColor = true;
			this.buttonDivide.Click += new System.EventHandler(this.Operators);
			// 
			// buttonMultiply
			// 
			this.buttonMultiply.Location = new System.Drawing.Point(132, 185);
			this.buttonMultiply.Name = "buttonMultiply";
			this.buttonMultiply.Size = new System.Drawing.Size(33, 27);
			this.buttonMultiply.TabIndex = 12;
			this.buttonMultiply.Text = "*";
			this.buttonMultiply.UseVisualStyleBackColor = true;
			this.buttonMultiply.Click += new System.EventHandler(this.Operators);
			// 
			// buttonSubtract
			// 
			this.buttonSubtract.Location = new System.Drawing.Point(132, 217);
			this.buttonSubtract.Name = "buttonSubtract";
			this.buttonSubtract.Size = new System.Drawing.Size(33, 27);
			this.buttonSubtract.TabIndex = 11;
			this.buttonSubtract.Text = "-";
			this.buttonSubtract.UseVisualStyleBackColor = true;
			this.buttonSubtract.Click += new System.EventHandler(this.Operators);
			// 
			// buttonEqual
			// 
			this.buttonEqual.Location = new System.Drawing.Point(171, 217);
			this.buttonEqual.Name = "buttonEqual";
			this.buttonEqual.Size = new System.Drawing.Size(33, 59);
			this.buttonEqual.TabIndex = 15;
			this.buttonEqual.Text = "=";
			this.buttonEqual.UseVisualStyleBackColor = true;
			this.buttonEqual.Click += new System.EventHandler(this.ButtonEqualClick);
			// 
			// buttonPercent
			// 
			this.buttonPercent.Location = new System.Drawing.Point(171, 151);
			this.buttonPercent.Name = "buttonPercent";
			this.buttonPercent.Size = new System.Drawing.Size(33, 27);
			this.buttonPercent.TabIndex = 17;
			this.buttonPercent.Text = "%";
			this.buttonPercent.UseVisualStyleBackColor = true;
			// 
			// buttonReciprocate
			// 
			this.buttonReciprocate.Location = new System.Drawing.Point(171, 184);
			this.buttonReciprocate.Name = "buttonReciprocate";
			this.buttonReciprocate.Size = new System.Drawing.Size(33, 27);
			this.buttonReciprocate.TabIndex = 16;
			this.buttonReciprocate.Text = "1/x";
			this.buttonReciprocate.UseVisualStyleBackColor = true;
			// 
			// buttonSquareRoot
			// 
			this.buttonSquareRoot.Location = new System.Drawing.Point(171, 120);
			this.buttonSquareRoot.Name = "buttonSquareRoot";
			this.buttonSquareRoot.Size = new System.Drawing.Size(33, 27);
			this.buttonSquareRoot.TabIndex = 22;
			this.buttonSquareRoot.Text = "√";
			this.buttonSquareRoot.UseVisualStyleBackColor = true;
			this.buttonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRootClick);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(94, 120);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(33, 27);
			this.buttonClear.TabIndex = 20;
			this.buttonClear.Text = "C";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
			// 
			// buttonClearEntry
			// 
			this.buttonClearEntry.Location = new System.Drawing.Point(55, 120);
			this.buttonClearEntry.Name = "buttonClearEntry";
			this.buttonClearEntry.Size = new System.Drawing.Size(33, 27);
			this.buttonClearEntry.TabIndex = 19;
			this.buttonClearEntry.Text = "CE";
			this.buttonClearEntry.UseVisualStyleBackColor = true;
			this.buttonClearEntry.Click += new System.EventHandler(this.ButtonClearEntryClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(16, 120);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(33, 27);
			this.buttonDelete.TabIndex = 18;
			this.buttonDelete.Text = "←";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// textBoxDisplay
			// 
			this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDisplay.Location = new System.Drawing.Point(15, 36);
			this.textBoxDisplay.Multiline = true;
			this.textBoxDisplay.Name = "textBoxDisplay";
			this.textBoxDisplay.Size = new System.Drawing.Size(188, 39);
			this.textBoxDisplay.TabIndex = 23;
			this.textBoxDisplay.Text = "0";
			this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxDisplay.TextChanged += new System.EventHandler(this.TextBoxDisplayTextChanged);
			// 
			// buttonSign
			// 
			this.buttonSign.Location = new System.Drawing.Point(132, 120);
			this.buttonSign.Name = "buttonSign";
			this.buttonSign.Size = new System.Drawing.Size(33, 27);
			this.buttonSign.TabIndex = 24;
			this.buttonSign.Text = "±";
			this.buttonSign.UseVisualStyleBackColor = true;
			this.buttonSign.Click += new System.EventHandler(this.ButtonSignClick);
			// 
			// buttonMAdd
			// 
			this.buttonMAdd.Location = new System.Drawing.Point(132, 87);
			this.buttonMAdd.Name = "buttonMAdd";
			this.buttonMAdd.Size = new System.Drawing.Size(33, 27);
			this.buttonMAdd.TabIndex = 29;
			this.buttonMAdd.Text = "M+";
			this.buttonMAdd.UseVisualStyleBackColor = true;
			// 
			// buttonMSub
			// 
			this.buttonMSub.Location = new System.Drawing.Point(171, 87);
			this.buttonMSub.Name = "buttonMSub";
			this.buttonMSub.Size = new System.Drawing.Size(33, 27);
			this.buttonMSub.TabIndex = 28;
			this.buttonMSub.Text = "M-";
			this.buttonMSub.UseVisualStyleBackColor = true;
			// 
			// buttonMS
			// 
			this.buttonMS.Location = new System.Drawing.Point(94, 87);
			this.buttonMS.Name = "buttonMS";
			this.buttonMS.Size = new System.Drawing.Size(33, 27);
			this.buttonMS.TabIndex = 27;
			this.buttonMS.Text = "MS";
			this.buttonMS.UseVisualStyleBackColor = true;
			// 
			// buttonMR
			// 
			this.buttonMR.Location = new System.Drawing.Point(55, 87);
			this.buttonMR.Name = "buttonMR";
			this.buttonMR.Size = new System.Drawing.Size(33, 27);
			this.buttonMR.TabIndex = 26;
			this.buttonMR.Text = "MR";
			this.buttonMR.UseVisualStyleBackColor = true;
			// 
			// buttonMC
			// 
			this.buttonMC.Location = new System.Drawing.Point(16, 87);
			this.buttonMC.Name = "buttonMC";
			this.buttonMC.Size = new System.Drawing.Size(33, 27);
			this.buttonMC.TabIndex = 25;
			this.buttonMC.Text = "MC";
			this.buttonMC.UseVisualStyleBackColor = true;
			// 
			// labelMiniDisplay
			// 
			this.labelMiniDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelMiniDisplay.Location = new System.Drawing.Point(16, 18);
			this.labelMiniDisplay.Name = "labelMiniDisplay";
			this.labelMiniDisplay.Size = new System.Drawing.Size(186, 23);
			this.labelMiniDisplay.TabIndex = 30;
			this.labelMiniDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(220, 293);
			this.Controls.Add(this.labelMiniDisplay);
			this.Controls.Add(this.buttonMAdd);
			this.Controls.Add(this.buttonMSub);
			this.Controls.Add(this.buttonMS);
			this.Controls.Add(this.buttonMR);
			this.Controls.Add(this.buttonMC);
			this.Controls.Add(this.buttonSign);
			this.Controls.Add(this.textBoxDisplay);
			this.Controls.Add(this.buttonSquareRoot);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonClearEntry);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonPercent);
			this.Controls.Add(this.buttonReciprocate);
			this.Controls.Add(this.buttonEqual);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonDivide);
			this.Controls.Add(this.buttonMultiply);
			this.Controls.Add(this.buttonSubtract);
			this.Controls.Add(this.buttonPoint);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
