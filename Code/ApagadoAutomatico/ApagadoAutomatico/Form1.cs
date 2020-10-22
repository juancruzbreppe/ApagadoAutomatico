using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApagadoAutomatico
{
	public partial class Form1 : Form
	{
		string cadena;
		int seg;
		public Form1()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			dtpHoras.Format = DateTimePickerFormat.Custom;
			dtpHoras.CustomFormat = "HH:mm";
			dtpHoras.ShowUpDown = true;
			reiniciar();
			habilitar(true);
		}

		private void BtnApagar_Click(object sender, EventArgs e)
		{
			seg = (Convert.ToInt32(dtpHoras.Value.Hour) * 3600) + (Convert.ToInt32(dtpHoras.Value.Minute) * 60); //CALCULO PARA PASAR DE HH:MM A SEGUNDOS (LA CMD TOMA EL TIEMPO EN SEGUNDOS) - CALCULATION TO GO FROM HH: MM TO SECONDS (THE CMD TAKES THE TIME IN SECONDS)
			if (seg<10 || seg> 315359999) //VALIDACION - VALIDATION
			{
				MessageBox.Show("Ese tiempo no se puede, inténtalo de nuevo!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
				reiniciar();
				habilitar(true);
			}
			else //CODIGO EN CMD PARA APAGAR LA PC - CODE IN CMD FOR SHUTDOWN THE PC
			{
				cadena = "/c shutdown -s -t " + seg.ToString();
				System.Diagnostics.Process.Start("CMD.exe", cadena);
				reiniciar();
				habilitar(false);
			}
			
		}

		private void BtnCancelar_Click(object sender, EventArgs e) //CODIGO PARA CANCELAR EL APAGADO - CODE FOR CANCEL THE SHUTDOWN
		{
			cadena = "/c shutdown -a";
			System.Diagnostics.Process.Start("CMD.exe", cadena);
			reiniciar();
			habilitar(true);
		}
		public void reiniciar() //REINICIA EL CONTADOR A 00:00 - REBOOT THE COUNT TO 00:00
		{
			dtpHoras.Text = "00:00";
		}
		public void habilitar(bool x) //METODO PARA ACTIVAR Y DESACTIVAR BOTONES - METHOD FOR ACTIVATE AND DESACTIVATE THE BUTTONS
		{
			btnApagar.Enabled = x;
			btnCancelar.Enabled = !x;
		}
	}
}
