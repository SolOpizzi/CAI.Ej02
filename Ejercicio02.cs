namespace CAI.Ej02
{
    public partial class Ejercicio02 : Form
    {

        Ejercicio02Model modelo;
        public Ejercicio02()
        {
            InitializeComponent();
        }


        private void Ejercicio02_Load(object sender, EventArgs e)
        {
            modelo = new Ejercicio02Model(); // tambien lo puedo escribir como modelo = new();
            comboBoxMarca.Items.AddRange(modelo.Marcas);
            //comboBoxMarca.SelectedItem = 0; // ESTO LO PONDRIA SOLO SI NO QUIERO VALIDAR LA ULTIMA PARTE DEL VALIDADOR

            //agrego el nombre y la fecha
            lblNombreUsuario.Text = $"{modelo.NombreReal} ({modelo.NombreUsuario})";
            lblFechaActual.Text = modelo.FechaActual.ToString();


        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Se está por cerrar el formulario, está usted seguro?", "Ejercicio02", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                this.Close(); // se usa this por si tengo dos formularios iguales abiertos
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            modelo.ModeloIngresado = this.txtModelo.Text;
            modelo.AñoIngresado = this.txtAño.Text;
            modelo.PrecioIngresado = this.txtPrecio.Text;

            //new
            modelo.MarcaIngresada = (string)this.comboBoxMarca.SelectedItem;

            //validar
            string mensaje = modelo.Validar();
            MessageBox.Show(mensaje);

        }
    }
}