namespace MySQL_CSharp_XAMPP_Winforms
{
	partial class FormUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtCmdBox = new System.Windows.Forms.TextBox();
			this.btnExecQuery = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCmdBox
			// 
			this.txtCmdBox.Location = new System.Drawing.Point(12, 12);
			this.txtCmdBox.Multiline = true;
			this.txtCmdBox.Name = "txtCmdBox";
			this.txtCmdBox.Size = new System.Drawing.Size(789, 171);
			this.txtCmdBox.TabIndex = 0;
			// 
			// btnExecQuery
			// 
			this.btnExecQuery.Location = new System.Drawing.Point(807, 12);
			this.btnExecQuery.Name = "btnExecQuery";
			this.btnExecQuery.Size = new System.Drawing.Size(163, 61);
			this.btnExecQuery.TabIndex = 1;
			this.btnExecQuery.Text = "Executive Query";
			this.btnExecQuery.UseVisualStyleBackColor = true;
			this.btnExecQuery.Click += new System.EventHandler(this.btnExecQuery_Click);
			// 
			// FormUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 556);
			this.Controls.Add(this.btnExecQuery);
			this.Controls.Add(this.txtCmdBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "FormUI";
			this.Text = "MySQL C# XAMPP Winforms";
			this.Load += new System.EventHandler(this.FormUI_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCmdBox;
		private System.Windows.Forms.Button btnExecQuery;
	}
}

