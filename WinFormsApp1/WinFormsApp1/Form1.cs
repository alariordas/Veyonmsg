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
                this.Text = arg1; // Establece el t�tulo del formulario
            }

            if (!string.IsNullOrEmpty(arg2))
            {
                label1.Text = arg2; // Establece el texto del label
            }

            // Ajusta el tama�o del formulario
            AdjustFormSize();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            RepositionControls();
        }

        private void RepositionControls()
        {
            button1.Top = this.ClientSize.Height - button1.Height - 10;  // 20 p�xeles de espacio desde el borde inferior
            button1.Left = this.ClientSize.Width - button1.Width - 20;   // 20 p�xeles de espacio desde el borde derecho
        }

        private void AdjustFormSize()
        {
            RepositionControls(); // Asegurarse de que los controles est�n en la posici�n correcta

            // Establece un ancho m�nimo para el formulario
            int minWidth = 200;

            // Obtiene el ancho necesario para el t�tulo
            int titleWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;

            // Establece el ancho del formulario seg�n el valor m�s grande
            int requiredWidth = Math.Max(minWidth, titleWidth) + 40; // +40 para dar un poco de margen

            // Asegurarse de que no exceda los 600 p�xeles de ancho
            if (requiredWidth > 600)
            {
                requiredWidth = 600;
            }

            this.Width = requiredWidth;

            // Ajustar la altura considerando ambos controles: label y bot�n
            int minHeight = 100; // un valor m�nimo para la altura
            int requiredHeight = button1.Bottom + 20; // +20 para dar espacio debajo del bot�n

            // Si el bot�n est� fuera de la vista, ajusta la altura del formulario
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
