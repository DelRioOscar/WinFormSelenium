using PruebaFlujo.Handlers;

namespace PruebaFlujo
{
    public partial class Form1 : Form
    {

        private AppSettings _appSettings;

        public Form1()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            _appSettings = ConfigManager.LoadSettings();
        }

        private void btnQA_CD_CuotaNormal_Click(object sender, EventArgs e)
        {
            var url = "https://cotizadordirecto2.qa.bciseguros.cl/datos-generales?cn=YUswVEo5cnlYVzc4RUNsS1MvM3kxdz09";
            var cotizadorDirecto = new CotizadorDirectoHandler(
                abrirNavegador: cbOpenBrowser.Checked,
                sacarCaptura: cbScreenshot.Checked);

            btnQA_CD_CuotaNormal.Text = "Procesando...";
            BloquearBotones();
            BloquearRadioButtons();
            BloquearCheckBoxes();

            if (rbNuevoQA.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Normal", true);
            }
            else if (rbUsadoQA.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Normal", false);
            }

            DesbloquearBotones();
            DesbloquearRadioButtons();
            DesbloquearCheckBoxes();
            btnQA_CD_CuotaNormal.Text = "Cuota normal";
            MessageBox.Show("Proceso finalizado.");
        }

        private void btnQA_CD_CuotaGratis_Click(object sender, EventArgs e)
        {
            var url = "https://cotizadordirecto2.qa.bciseguros.cl/datos-generales?cn=bGY2QkRPOFNBMXJkaC9FWnU4NjFNdz09";
            var cotizadorDirecto = new CotizadorDirectoHandler(abrirNavegador: cbOpenBrowser.Checked, sacarCaptura: cbScreenshot.Checked);

            if (rbNuevoQA.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Gratis", true);
            }

            if (rbUsadoQA.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Gratis", false);
            }
        }

        private void btnQA_CD_CuotaSimbolica_Click(object sender, EventArgs e)
        {
            var url = "https://ventaasistida.qa.bciseguros.cl/inicio?i=MAA=&ne=RQBqAGUAYwB1AHQAaQB2AG8AIABRAGEA&re=MQAyADIAMgA4ADQANwA5AA==&rd=NAA=&r=MQA4ADcAMwAzADQAOQAzAC0ANAA=&d=NAA=&p=&z=MwA=&e=TwBLAA==&go=RwBPAA==";
            var cotizadorDirecto = new CotizadorDirectoHandler(abrirNavegador: cbOpenBrowser.Checked, sacarCaptura: cbScreenshot.Checked);

            if (rbNuevoQA.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Simbolica", true);
            }

            if (rbUsadoQA.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Simbolica", false);
            }
        }


        private void btnDesa_VA_CuotaNormal_Click(object sender, EventArgs e)
        {
            string url = cbLocalhost.Checked ? $"{_appSettings.UrlLocalhostVA}/inicio?i=MAA=&ne=RQBqAGUAYwB1AHQAaQB2AG8AIABRAGEA&re=MQAyADIAMgA4ADQANwA5AA==&rd=NAA=&r=MQA4ADcAMwAzADQAOQAzAC0ANAA=&d=NAA=&p=YgB4ADkAMQA0ADgA&z=MQA=&e=TwBLAA==&go=RwBPAA=="
              : "http://ventaasistida.desa.bciseguros.cl/inicio?i=MAA=&ne=RQBqAGUAYwB1AHQAaQB2AG8AIABRAGEA&re=MQAyADIAMgA4ADQANwA5AA==&rd=NAA=&r=MQA4ADcAMwAzADQAOQAzAC0ANAA=&d=NAA=&p=YgB4ADkAMQA0ADgA&z=MQA=&e=TwBLAA==&go=RwBPAA==";

            var ventaAsistida = new VentaAsistidaHandler(true, false);
            if (rbNuevoDesa.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", true);
            }

            if (rbUsadoDesa.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", false);
            }
        }

        private void btnDESA_CD_CuotaNormal_Click(object sender, EventArgs e)
        {
            string url = cbLocalhost.Checked ? $"{_appSettings.UrlLocalhostCD}/datos-generales?cn=YUswVEo5cnlYVzc4RUNsS1MvM3kxdz09"
                : "http://cotizadordirecto2.desa.bciseguros.cl/datos-generales?cn=YUswVEo5cnlYVzc4RUNsS1MvM3kxdz09";

            var cotizadorDirecto = new CotizadorDirectoHandler(true, false);

            if (rbNuevoDesa.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Normal", true);
            }

            if (rbUsadoDesa.Checked)
            {
                cotizadorDirecto.IniciarCuota(url, "Cuota Normal", false);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            var config = new Config();
            config.Show();
        }

        private void btnQA_VA_CuotaNormal_Click(object sender, EventArgs e)
        {
            var url = "https://ventaasistida.qa.bciseguros.cl/inicio?i=MAA=&ne=RQBqAGUAYwB1AHQAaQB2AG8AIABRAGEA&re=MQAyADIAMgA4ADQANwA5AA==&rd=NAA=&r=MQA4ADcAMwAzADQAOQAzAC0ANAA=&d=NAA=&p=YgB4ADkAMQA0ADgA&z=MQA=&e=TwBLAA==&go=RwBPAA==";
            var ventaAsistida = new VentaAsistidaHandler(abrirNavegador: cbOpenBrowser.Checked, sacarCapturaPantalla: cbScreenshot.Checked);

            if (rbNuevoQA.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", true);
            }

            if (rbUsadoQA.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", false);
            }
        }

        private void BloquearBotones()
        {
            btnQA_CD_CuotaNormal.Enabled = false;
            btnQA_CD_CuotaGratis.Enabled = false;
            btnQA_CD_CuotaSimbolica.Enabled = false;
            btnQA_VA_CuotaNormal.Enabled = false;
            btnQA_VA_CuotaGratis.Enabled = false;
            btnQA_VA_CuotaSimbolica.Enabled = false;
            btnDesa_VA_CuotaNormal.Enabled = false;
            btnDESA_CD_CuotaNormal.Enabled = false;

        }

        private void BloquearRadioButtons()
        {
            rbNuevoQA.Enabled = false;
            rbUsadoQA.Enabled = false;
            rbNuevoDesa.Enabled = false;
            rbUsadoDesa.Enabled = false;
        }

        private void BloquearCheckBoxes()
        {
            cbOpenBrowser.Enabled = false;
            cbScreenshot.Enabled = false;
            cbLocalhost.Enabled = false;
        }

        private void DesbloquearBotones()
        {
            btnQA_CD_CuotaNormal.Enabled = true;
            btnQA_CD_CuotaGratis.Enabled = true;
            btnQA_CD_CuotaSimbolica.Enabled = true;
            btnQA_VA_CuotaNormal.Enabled = true;
            btnDesa_VA_CuotaNormal.Enabled = true;
            btnDESA_CD_CuotaNormal.Enabled = true;
            btnQA_VA_CuotaGratis.Enabled = true;
            btnQA_VA_CuotaSimbolica.Enabled = true;
        }

        private void DesbloquearRadioButtons()
        {
            rbNuevoQA.Enabled = true;
            rbUsadoQA.Enabled = true;
            rbNuevoDesa.Enabled = true;
            rbUsadoDesa.Enabled = true;
        }

        private void DesbloquearCheckBoxes()
        {
            cbOpenBrowser.Enabled = true;
            cbScreenshot.Enabled = true;
            cbLocalhost.Enabled = true;
        }

        private void btnQA_VA_CuotaSimbolica_Click(object sender, EventArgs e)
        {
            var url = "https://ventaasistida.qa.bciseguros.cl/inicio?i=MAA=&ne=RQBqAGUAYwB1AHQAaQB2AG8AIABRAGEA&re=MQAyADIAMgA4ADQANwA5AA==&rd=NAA=&r=MQA4ADcAMwAzADQAOQAzAC0ANAA=&d=NAA=&p=YgB4ADkAMQA0ADgA&z=MQA=&e=TwBLAA==&go=RwBPAA==";
            var ventaAsistida = new VentaAsistidaHandler(abrirNavegador: cbOpenBrowser.Checked, sacarCapturaPantalla: cbScreenshot.Checked);

            if (rbNuevoQA.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", true);
            }

            if (rbUsadoQA.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", false);
            }
        }

        private void btnQA_VA_CuotaGratis_Click(object sender, EventArgs e)
        {
            var url = "https://ventaasistida.qa.bciseguros.cl/inicio?i=MAA=&ne=RQBqAGUAYwB1AHQAaQB2AG8AIABRAGEA&re=MQAyADIAMgA4ADQANwA5AA==&rd=NAA=&r=MQA4ADcAMwAzADQAOQAzAC0ANAA=&d=NAA=&p=YgB4ADkAMQA0ADgA&z=MQA=&e=TwBLAA==&go=RwBPAA==";
            var ventaAsistida = new VentaAsistidaHandler(abrirNavegador: cbOpenBrowser.Checked, sacarCapturaPantalla: cbScreenshot.Checked);

            if (rbNuevoQA.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", true);
            }

            if (rbUsadoQA.Checked)
            {
                ventaAsistida.IniciarCuotaNormal(url, "Cuota Normal", false);
            }
        }
    }
}
