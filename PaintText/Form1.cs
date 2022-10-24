namespace PaintText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaintClick(object sender, EventArgs e)
        {
            int r, g, b;
            string str;
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //lo que quieres que haga, en este caso seria sacar el
                str = dlg.Color.Name;
                g = dlg.Color.ToArgb();

                // Color c = ColorTranslator.FromHtml(str);
                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(g);
                this.BackColor = myRgbColor;
                Menuuu.BackColor = myRgbColor;


                //entrar a la propiedad del form y setearlo
                // esto debes ponerlo en el evento click del segundo boton

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ETXT_Click(object sender, EventArgs e)
        {

        }
    }
}