namespace ApagadoAutomatico
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnApagar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.dtpHoras = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnApagar
			// 
			this.btnApagar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			resources.ApplyResources(this.btnApagar, "btnApagar");
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.UseVisualStyleBackColor = false;
			this.btnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			resources.ApplyResources(this.btnCancelar, "btnCancelar");
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// dtpHoras
			// 
			resources.ApplyResources(this.dtpHoras, "dtpHoras");
			this.dtpHoras.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
			this.dtpHoras.Name = "dtpHoras";
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(this.label2, "label2");
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Name = "label2";
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpHoras);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnApagar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnApagar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DateTimePicker dtpHoras;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

