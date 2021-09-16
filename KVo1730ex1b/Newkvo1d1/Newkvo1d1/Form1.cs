using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newkvo1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtAmountAustralian.Text  = "0.00";
            txtAustralianRate.Text = "0.74";
            txtUSDAstralian.Text = "0.00";
            txtAmountBhutan.Text = "0.00";
            txtBhutanRate.Text = "0.014";
            txtUSDBhutan.Text = "0.00";
            TxtAmountColon.Text = "0.00";
            txtColonRate.Text = ".0016";
            txtUSDColon.Text = "0.00";
            txtAmountEuro.Text = "0.00";
            txtEuroRate.Text = "1.18";
            txtUSDEuro.Text = "0.00";
            
        }

        private void AustraliatxtChange(object sender, EventArgs e)
        {
            txtUSDAstralian.Text = (99.99m).ToString("0.00");
        }

        private void txtUSDAstralian_TextChanged(object sender, EventArgs e)
        {

        }

        private void BhutantxtChange(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (99.99m).ToString("0.00");
        }

        private void txtUSDBhutan_TextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                            Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtBhutanRate.Text)
                            ).ToString("0.00");
        }

        private void ColontxtChange(object sender, EventArgs e)
        {
            txtUSDColon.Text = (99.99m).ToString("0.00");
        }

        private void txtUSDColon_TextChanged(object sender, EventArgs e)
        {
            txtUSDColon.Text  = (
                            Convert.ToDecimal(TxtAmountColon.Text) * Convert.ToDecimal(txtColonRate.Text)
                            ).ToString("0.00");
        }


        private void txtUSDEuro_TextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                            Convert.ToDecimal(txtAmountEuro.Text) * Convert.ToDecimal(txtEuroRate.Text)
                            ).ToString("0.00");
        }

        private void txtUSDAstralian_TextChanged_1(object sender, EventArgs e)
        {
            txtUSDAstralian.Text = (Convert.ToDecimal(txtAmountAustralian.Text) * Convert.ToDecimal(txtAustralianRate.Text)).ToString("0.00");
        }

        private void USDtxtChanged(object sender, EventArgs e)
        {
           
        }

        private void USDtextChange(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDAstralian.Text) + Convert.ToDecimal(txtUSDBhutan.Text) + Convert.ToDecimal(txtUSDColon.Text) + Convert.ToDecimal(txtUSDEuro)).ToString("0.00");
        }

        private void EurotxtChange(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (0.00m).ToString("0.00");
        }
    }
}
