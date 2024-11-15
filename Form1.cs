namespace bar
{
    public partial class Form1 : Form
    {
        // List to store the values for the bar graph
        List<float> values = new List<float>();
        // List to store the labels for the bar graph
        List<string> labels = new List<string>();

        // Constructor for the Form1 class
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for button1 click
        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous values and labels
            values.Clear();
            labels.Clear();

            // Get user input from text boxes
            string inputval = txtValues.Text;
            string inputlab = txtlabels.Text;

            // Check if the input for values is empty or whitespace
            if (string.IsNullOrWhiteSpace(inputval))
            {
                MessageBox.Show("Enter at least the values to make graph", "Error");
            }
            else
            {
                // Split input values and labels by comma
                string[] stringLab = inputlab.Split(',');
                string[] stringL = inputval.Split(",");

                // Convert the input values from string to integer array
                int[] inpvalues = Array.ConvertAll(stringL, int.Parse);

                // If labels input is empty, generate labels automatically (A, B, C, etc.)
                if (string.IsNullOrWhiteSpace(inputlab))
                {
                    for (int i = 0; i < inpvalues.Length; i++)
                    {
                        char letter = (char)('A' + i);
                        string l = letter.ToString();
                        labels.Add(l);
                    }
                }
                // Check if the number of labels exceeds the number of values
                else if (stringLab.Length > inpvalues.Length)
                {
                    MessageBox.Show("Enter all the values for labels.");
                    return;
                }
                // Check if the number of labels is less than the number of values
                else if (stringLab.Length < inpvalues.Length)
                {
                    MessageBox.Show("Enter all the labels for values.");
                    return;
                }
                else
                {
                    // Add user-provided labels to the list
                    foreach (string v in stringLab)
                    {
                        labels.Add(v);
                    }
                }

                // Add the input values to the values list
                foreach (int v in inpvalues)
                {
                    values.Add(v);
                }
            }

            // Set the values and labels in the bar graph component
            bar1.set(values, labels);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
