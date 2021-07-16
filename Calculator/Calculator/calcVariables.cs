using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	public partial class calcVariables : Form
	{	private Double result = 0, memory = 0;
		private String operation = "";
		private bool checkInput = false;
		
		public String Operation
		{
			get {return operation;}
			set {operation = value;}
		}
		
		public Double Result
		{
			get {return result;}
			set {result = value;}
		}
		
		public Double Memory
		{
			get {return memory;}
			set {memory = value;}
		}
		
		public bool CheckInput
		{
			get {return checkInput;}
			set {checkInput = value;}
		}
		
		public calcVariables()
		{
			InitializeComponent();
		}
	}
}
