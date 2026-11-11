using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using PlantillaExamen.Modelos;

namespace PlantillaExamen.Vista.Dialogo
{
    public partial class VentanaSecundaria : MetroWindow
    {
        public RegistroItem? NuevoRegistro { get; private set; }

        public VentanaSecundaria()
        {
            InitializeComponent();
        }

        private async void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModalNombre.Text))
            {
                await this.ShowMessageAsync("Campo obligatorio", "Por favor, introduce el nombre del elemento.");
                return;
            }

            string categoria = (cmbModalCategoria.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "General";

            NuevoRegistro = new RegistroItem
            {
                Nombre = txtModalNombre.Text.Trim(),
                Categoria = categoria,
                Fecha = DateTime.Now.ToString("dd/MM/yyyy"),
                Importe = numModalImporte.Value ?? 0,
                Activo = true
            };

            DialogResult = true;
            Close();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
