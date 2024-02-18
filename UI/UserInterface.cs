using BL;
using MDL;
using System.Text.RegularExpressions;

namespace UI
{

    public partial class UserInterface : Form
    {
        BusinessLogic bl = new BusinessLogic();


        public UserInterface()
        {
            InitializeComponent();
        }

        bool ageIsValid = false;
        bool nameIsValid = false;
        bool idIsValid = false;

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

        private void GetBtn_Click(object sender, EventArgs e)
        {
            if (idIsValid == true)
            {
                Task<Person> t2 = Task<Person>.Factory.StartNew(() => bl.GetModel(Int32.Parse(IDBox.Text)));
                t2.Wait();
                Person person = t2.Result;
                IDBox.Text = person.Id.ToString();
                NameBox.Text = person.Name.ToString();
                AgeBox.Text = person.Age.ToString();
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (nameIsValid == true && ageIsValid == true && idIsValid == true)
            {
                Task t3 = Task.Factory.StartNew(() => bl.Update(Int32.Parse(IDBox.Text), NameBox.Text, Int32.Parse(AgeBox.Text)));
                Task<Person> t2 = Task<Person>.Factory.StartNew(() => bl.GetModel(Int32.Parse(IDBox.Text)));
                Task.WaitAll(t2, t3);
                Person person = t2.Result;
                IDBox.Text = person.Id.ToString();
                NameBox.Text = person.Name.ToString();
                AgeBox.Text = person.Age.ToString();
                IDBox.Text = null;
                NameBox.Text = null;
                AgeBox.Text = null;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (nameIsValid == true && ageIsValid == true && idIsValid == true)
            {
                Task t4 = Task.Factory.StartNew(() => bl.AddToList(NameBox.Text, Int32.Parse(AgeBox.Text)));
                t4.Wait();
                IDBox.Text = null;
                NameBox.Text = null;
                AgeBox.Text = null;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (idIsValid == true)
            {
                Task t1 = Task.Factory.StartNew(() => bl.RemoveFromList(Int32.Parse(IDBox.Text)));
                t1.Wait();
                IDBox.Text = null;
                NameBox.Text = null;
                AgeBox.Text = null;
            }
        }

        private bool InputsAreValid(string type, string input)
        {
            if (type == "int")
            {
                return Int32.TryParse(input, out int result);
            }
            if (type == "string")
            {
                if (!string.IsNullOrEmpty(input))
                {
                    string regexStatement = @"^[a-zA-Z]{2,}$";
                    return RegexCheckXAgainstYPattern(input, regexStatement);
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
        private bool RegexCheckXAgainstYPattern(string input, string pattern)
        {
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(input);
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void IDBox_TextChanged_1(object sender, EventArgs e)
        {
            idIsValid = InputsAreValid("int", IDBox.Text);

        }

        private void NameBox_TextChanged_1(object sender, EventArgs e)
        {
            nameIsValid = InputsAreValid("string", NameBox.Text);

        }

        private void AgeBox_TextChanged_1(object sender, EventArgs e)
        {
            ageIsValid = InputsAreValid("int", AgeBox.Text);
        }
    }
}