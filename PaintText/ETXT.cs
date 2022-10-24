using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintText
{
    public partial class ETXT : Form
    {
        public ETXT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ETXT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();

            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void st_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void abrir_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin Titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }

            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void et_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void formato_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if (frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void choose_size(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse(ComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style);
            }
        }

    }
}
