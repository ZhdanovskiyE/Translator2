namespace Translator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string line;
            try
            {
                var file = new System.IO.StreamReader("RusData.dat");
                while ((line = file.ReadLine()) != null)
                {
                    Rus_list.Items.Add(line);
                }
                file.Close();
                var file2 = new System.IO.StreamReader("EngData.dat");
                while ((line = file2.ReadLine()) != null)
                {
                    Eng_list.Items.Add(line);
                }
                file2.Close();
            }
            catch (Exception e)
            { }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            Rus_list.Items.Add(Rus_text.Text);
            Eng_list.Items.Add(Eng_text.Text);
            Rus_text.Clear();
            Eng_text.Clear();
            System.IO.StreamWriter SaveFile1 = new System.IO.StreamWriter("RusData.dat");
            foreach (var item in Rus_list.Items)
            {
                SaveFile1.WriteLine(item.ToString());
            }
            SaveFile1.Close();
            System.IO.StreamWriter SaveFile2 = new System.IO.StreamWriter("EngData.dat");
            foreach (var item in Eng_list.Items)
            {
                SaveFile2.WriteLine(item.ToString());
            }
            SaveFile2.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Eng_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rus_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eng_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rus_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ru = new string[File.ReadAllLines("RusData.dat").Length];
            string[] en = new string[File.ReadAllLines("EnData.dat").Length];
            string word = "";
            for (int i = 0; i < ru.Length; i++)
            {
                ru[i] = File.ReadAllLines("RusData.dat")[i];
                en[i] = File.ReadAllLines("EnData.dat")[i];

                if (ru[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                {
                    textBox2.Text = en[i];
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}