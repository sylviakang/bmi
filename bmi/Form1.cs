namespace bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int weight;
            double bmi, height;
            bool r1, r2;
            r1 = double.TryParse(TxtHeight.Text, out height);
            r2 = int.TryParse(TxtWeight.Text, out weight);
            if (r1 && r2)
            {
                if (RbtnCm.Checked == true)
                {
                    height /= 100;  // height = height / 100;
                }
                bmi = weight / (height * height);
                LblMsg.Text = $"BMI值：{bmi:f1}";
            }
            else
                LblMsg.Text = "請輸入整數";
        }
    }
}