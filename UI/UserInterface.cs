using BL;
using MDL;

namespace UI
{

    public partial class UserInterface : Form
    {
        BusinessLogic bl = new BusinessLogic();


        public UserInterface()
        {
            InitializeComponent();
        }

        public void DeleteTest_Click(object sender, EventArgs e)
        {
            Task t1 = Task.Factory.StartNew(() => bl.RemoveFromList();
        }

        public void GetTest_Click(object sender, EventArgs e)
        {

        }

        public void UpdateTest_Click(object sender, EventArgs e)
        {

        }

        public void AddTest_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}