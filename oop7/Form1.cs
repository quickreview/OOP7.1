namespace oop7
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }
        
        private void clsoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

        }
       
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChild formChild = new FormChild();
            formChild.MdiParent = this;
            formChild.Show();

         
           
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close();
            }

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontallyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticallyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
      

        private void paintToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}