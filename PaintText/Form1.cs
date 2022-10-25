namespace PaintText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PaintClick(object sender, EventArgs e)
        {
            int r, g, b;
            string str;
            ColorDialog dlg = new ColorDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                str = dlg.Color.Name;
                g = dlg.Color.ToArgb();

                Color myRgbColor = new Color();
                myRgbColor = Color.FromArgb(g);
                this.BackColor = myRgbColor;
                Menuuu.BackColor = myRgbColor;
                
            }
        }


        private void ETXT_Click(object sender, EventArgs e)
        {
            ETXT frm = new ETXT();
            frm.Show();

            this.Hide();
        }


        private void Close_Click_1(object sender, EventArgs e)
        {
            Close();

        }
    }
}