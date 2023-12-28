using System;
using System.Windows.Forms;

namespace ArraySorter
{
    public partial class MainForm : Form
    {
        private TextBox inputBox;
        private Button sortButton;
        private Label resultLabel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            inputBox = new TextBox();
            sortButton = new Button();
            resultLabel = new Label();

            Text = "Array Sorter";
            Size = new System.Drawing.Size(300, 200);

            inputBox.Location = new System.Drawing.Point(20, 20);
            inputBox.Size = new System.Drawing.Size(200, 20);

            sortButton.Text = "Sort";
            sortButton.Location = new System.Drawing.Point(20, 50);
            sortButton.Click += SortButton_Click;

            resultLabel.Location = new System.Drawing.Point(20, 80);

            Controls.Add(inputBox);
            Controls.Add(sortButton);
            Controls.Add(resultLabel);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            SortArray();
        }

        private void SortArray()
        {
            try
            {
              string[] numbers = inputBox.Text.Split(',');
                int[] intArray = Array.ConvertAll(numbers, int.Parse);

                // Sort the array
                Array.Sort(intArray);

               resultLabel.Text = "Sorted Array: " + string.Join(", ", intArray);
            }
            catch (Exception ex)
            {
                resultLabel.Text = "Error: " + ex.Message;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
