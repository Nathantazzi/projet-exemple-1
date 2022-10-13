namespace app1_multicouche
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

        private void button_Click(object sender, EventArgs e)
        {
            if(nom.Text =="admin"||pass.Text =="admin")
            {
                FormUser form = new FormUser();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("nom et mot de passe incorect","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}