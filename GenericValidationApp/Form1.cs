namespace GenericValidationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidateValues<double>(); // Puede aquí cambiar el tipo  genérico, por ejemplo, a 'double', 'decimal', etc.
        }

        private void ValidateValues<T>()
        {
            try
            {
                // Intentamos convertir ambos valores ingresados al tipo genérico T
                T value1 = (T)Convert.ChangeType(txtInput1.Text, typeof(T));
                T value2 = (T)Convert.ChangeType(txtInput2.Text, typeof(T));

                lblResult.Text = "Los valores son válidos y del mismo tipo.";
                lblResult.ForeColor = Color.Green;
            }
            catch (InvalidCastException)
            {
                lblResult.Text = "Error: Los valores no son del mismo tipo o no son válidos";
                lblResult.ForeColor = Color.Red;
            }
            catch (FormatException)
            {
                lblResult.Text = "Error: El formato de uno o ambos valores es incorrecto.";
                lblResult.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error inesperado: {ex.Message}";
                lblResult.ForeColor = Color.Red;
            }
        }
    }
}
