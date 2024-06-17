using PruebaFlujo.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaFlujo
{
    public partial class Config : Form
    {
        private AppSettings _appSettings;
        public Config()
        {
            InitializeComponent();
            LoadSettings();
            TextBoxPlaceholderManager.SetPlaceholder(txtUrlBaseVA, "Ej: http://localhost:4200");
            TextBoxPlaceholderManager.SetPlaceholder(txtUrlBaseCD, "Ej: http://localhost:5200");
        }

        private void LoadSettings()
        {
            _appSettings = ConfigManager.LoadSettings();
            CargarUrlBase();
            CargarMedioPago();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarUrlBase();
            GuardarMedioPago();
            ConfigManager.SaveSettings(_appSettings);
            MessageBox.Show("Configuraciones guardadas correctamente.");
            this.Close();
        }

        private void CargarUrlBase()
        {
            txtUrlBaseVA.Text = _appSettings.UrlLocalhostVA;
            txtUrlBaseCD.Text = _appSettings.UrlLocalhostCD;
        }

        private void CargarMedioPago()
        {
            if (_appSettings.MedioPago == "Fintoc")
            {
                rbFintoc.Checked = true;
            }
            else if (_appSettings.MedioPago == "Mercado Pago Débito")
            {
                rbMercadoPagoDebito.Checked = true;
            }
            else if (_appSettings.MedioPago == "Mercado Pago Crédito")
            {
                rbMercadoPagoCredito.Checked = true;
            }
            else if (_appSettings.MedioPago == "Klap Débito")
            {
                rbKlapDebito.Checked = true;
            }
            else if (_appSettings.MedioPago == "Klap Crédito")
            {
                rbKlapCredito.Checked = true;
            }
            else if (_appSettings.MedioPago == "PatPass")
            {
                rbPatPass.Checked = true;
            }
        }

        private void GuardarUrlBase()
        {
            _appSettings.UrlLocalhostVA = txtUrlBaseVA.Text;
            _appSettings.UrlLocalhostCD = txtUrlBaseCD.Text;
        }

        private void GuardarMedioPago()
        {
            if (rbFintoc.Checked)
            {
                _appSettings.MedioPago = "Fintoc";
            }
            else if (rbMercadoPagoDebito.Checked)
            {
                _appSettings.MedioPago = "Mercado Pago Débito";
            }
            else if (rbMercadoPagoCredito.Checked)
            {
                _appSettings.MedioPago = "Mercado Pago Crédito";
            }
            else if (rbKlapDebito.Checked)
            {
                _appSettings.MedioPago = "Klap Débito";
            }
            else if (rbKlapCredito.Checked)
            {
                _appSettings.MedioPago = "Klap Crédito";
            }
            else if (rbPatPass.Checked)
            {
                _appSettings.MedioPago = "PatPass";
            }
        }
    }
}
