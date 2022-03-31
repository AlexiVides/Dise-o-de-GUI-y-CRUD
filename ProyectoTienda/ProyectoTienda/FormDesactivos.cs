using System.Data;
using System.Data.SqlClient;

namespace ProyectoTienda
{
    public partial class FormDesactivos : Form
    {
        public FormDesactivos()
        {
            InitializeComponent();

            
        }
        public DataTable MostrarDato()
        {
            //Realiamos na consulta a la bd para que nos muestre los registros que deseamos

            try
            {

                Conexion.Conectar();
                DataTable dt = new DataTable();
                string consulta = "select codigo, nombreCliente,apellidoCliente,dui,direccion,telefono,estado from  Cliente where estado = 'desactivo'";
                SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch
            {
                //Si se encuentra un error nos lo mostrara
                MessageBox.Show("Error");
            }

            return null;
        }


        private void dGvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtcodigo.Text = dGvMostrar.CurrentRow.Cells[0].Value.ToString();
                txtnombre.Text = dGvMostrar.CurrentRow.Cells[1].Value.ToString();
                txtapellido.Text = dGvMostrar.CurrentRow.Cells[2].Value.ToString();
                txtdui.Text = dGvMostrar.CurrentRow.Cells[3].Value.ToString();
                txtdireccion.Text = dGvMostrar.CurrentRow.Cells[4].Value.ToString();
                txttelefono.Text = dGvMostrar.CurrentRow.Cells[5].Value.ToString();



            }
            catch
            {
                //Si se encuentra un error nos lo mostrara
                MessageBox.Show("Error");
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.Conectar();
                string delete = "UPDATE Cliente SET codigo=@codigo, estado=@estado  WHERE codigo=@codigo";
                SqlCommand sqlCommand = new SqlCommand(delete, Conexion.Conectar());


                sqlCommand.Parameters.AddWithValue("@codigo", txtcodigo.Text);

                sqlCommand.Parameters.AddWithValue("@estado", "activo");

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Se ha activado correctamente");

                dGvMostrar.DataSource = MostrarDato();
            }
            catch
            {
                // Si se encuentra un error nos lo mostrara
                MessageBox.Show("Error");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormDesactivos_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            try
            {

            }
            catch
            {
                MessageBox.Show("Error");
            }

            dGvMostrar.DataSource = MostrarDato();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult opc;
            opc = MessageBox.Show("Desea salir? ", "Salir del formulario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (opc == DialogResult.OK)
            {
                Dispose();
            }
        }
    }
}
