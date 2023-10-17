namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string arg1;
        private string arg2;

        public Form1(string argumento1, string argumento2)
        {
            InitializeComponent();
            this.arg1 = argumento1;
            this.arg2 = argumento2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(arg1))
            {
                this.Text = arg1; // Establece el título del formulario
            }

            if (!string.IsNullOrEmpty(arg2))
            {
                label1.Text = arg2; // Establece el texto del label
            }

            // Ajusta el tamaño del formulario
            AdjustFormSize();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RepositionControls();
        }

        private void RepositionControls()
        {
            button1.Top = this.ClientSize.Height - button1.Height - 10;  // 20 píxeles de espacio desde el borde inferior
            button1.Left = this.ClientSize.Width - button1.Width - 20;   // 20 píxeles de espacio desde el borde derecho
        }

        private void AdjustFormSize()
        {
            RepositionControls(); // Asegurarse de que los controles estén en la posición correcta

            // Establece un ancho mínimo para el formulario
            int minWidth = 200;

            // Obtiene el ancho necesario para el título
            int titleWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;

            // Establece el ancho del formulario según el valor más grande
            int requiredWidth = Math.Max(minWidth, titleWidth) + 40; // +40 para dar un poco de margen

            // Asegurarse de que no exceda los 600 píxeles de ancho
            if (requiredWidth > 600)
            {
                requiredWidth = 600;
            }

            this.Width = requiredWidth;

            // Ajustar la altura considerando ambos controles: label y botón
            int minHeight = 100; // un valor mínimo para la altura
            int requiredHeight = button1.Bottom + 20; // +20 para dar espacio debajo del botón

            // Si el botón está fuera de la vista, ajusta la altura del formulario
            if (button1.Bottom > this.ClientSize.Height)
            {
                requiredHeight = button1.Bottom + 20;
            }

            this.Height = Math.Max(minHeight, requiredHeight);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
