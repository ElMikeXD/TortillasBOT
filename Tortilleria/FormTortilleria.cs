using Librerias;
using Model.DTO;
using System;
using System.Windows.Forms;

namespace Tortilleria
{
    public partial class FormTortilleria : Form
    {
        public FormTortilleria()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DatosElaboracionProducto _oDatosElaboracionProducto = new DatosElaboracionProducto
            {
                cProducto = comboBoxProducto.SelectedItem.ToString(),
                iCantidadProducto = Convert.ToByte(textBoxCantidad.Text),
                iVelocidadMoledor = ObtenerValorHeramienta(panelMoledor),
                iTemperaturaHorno = ObtenerValorHeramienta(panelHorno),
                iTemperaturaFreidora = ObtenerValorHeramienta(panelFreidora)

            };

            string _cIngrediente = comboBoxIngrediente.SelectedItem.ToString();

            ElaborarProductos(_cIngrediente, new ProcesadorProductosDeMaiz(), new ProcesadorProductosHarina(), _oDatosElaboracionProducto);

        }

        /// <summary>
        /// Procesa la elaboración de productos dependiendo del tipo de ingrediente
        /// </summary>
        /// <param name="cIngrediente">Cadena con el nombre del ingrediente</param>
        /// <param name="oProductoMaiz">Objeto para elaborar productos de maíz</param>
        /// <param name="oProductoHarina">Objeto para elaborar productos de Harina</param>
        /// <param name="oDatosElaboracionProducto">Objeto con los parámetros de elaboración</param>
        private void ElaborarProductos(string cIngrediente, IProcesadorProducto oProductoMaiz, IProcesadorProducto oProductoHarina, DatosElaboracionProducto oDatosElaboracionProducto)
        {
            TimeSpan dtTiempoElaboracion = TimeSpan.Zero;

            switch (cIngrediente)
            {
                case "Maiz":
                    dtTiempoElaboracion = oProductoMaiz.ElaborarProducto(oDatosElaboracionProducto);
                    break;

                case "Harina":
                    dtTiempoElaboracion = oProductoHarina.ElaborarProducto(oDatosElaboracionProducto);
                    break;
            }

            IConvertidorTiempo oConvertidorTiempo = new ConvertidorTiempo();

            MostrarMensaje("El producto: " + oDatosElaboracionProducto.cProducto + " tardará: " + oConvertidorTiempo.ObtenerTiempoPreparación(dtTiempoElaboracion));
        }

        private void MostrarMensaje(string cMensaje)
        {
            MessageBox.Show(cMensaje);
        }

        /// <summary>
        /// Obtiene el valor de los RadioButtons
        /// </summary>
        /// <param name="oPanel">Objeto tipo panel</param>
        /// <returns>Entero con el valor del RadioButton</returns>
        private byte ObtenerValorHeramienta(Panel oPanel)
        {
            byte iValorHeramienta = 1;

            foreach (Control c in oPanel.Controls)
            {
                if (c is RadioButton)
                {
                    if (((RadioButton)c).Checked)
                    {
                        iValorHeramienta = Convert.ToByte(((RadioButton)c).Tag);
                    }
                }
            }

            return iValorHeramienta;
        }

        private void FormTortilleria_Load(object sender, EventArgs e)
        {
            comboBoxIngrediente.SelectedIndex = 0;
            comboBoxProducto.SelectedIndex = 0;
            RdoFreidora1.Checked = true;
            RdoHorno1.Checked = true;
            RdoMoledor1.Checked = true;

        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
