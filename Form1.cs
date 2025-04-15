namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Black;
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Red;
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Blue;
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt.BackColor = System.Drawing.Color.Green;
        }
    }
}