namespace UnitsConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            leftTB.SendToBack();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void unitsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] lengthUnits = { "km", "mts", "cm", "mm" };
            string[] massUnits = { "t", "kg", "gr", "mg" };
            string[] temperatureUnits = { "°C", "°F", "K" };

            leftUnitCB.Items.Clear();
            rightUnitCB.Items.Clear();
            if (unitsCB.Text == "Length")
            {
                leftUnitCB.Items.AddRange(lengthUnits);
                rightUnitCB.Items.AddRange(lengthUnits);
            }
            else if (unitsCB.Text == "Mass")
            {
                leftUnitCB.Items.AddRange(massUnits);
                rightUnitCB.Items.AddRange(massUnits);
            }
            else
            {
                leftUnitCB.Items.AddRange(temperatureUnits);
                rightUnitCB.Items.AddRange(temperatureUnits);
            }

        }

        private void leftTB_TextChanged(object sender, EventArgs e)
        {
            executeConversion();
        }

        private void leftTB_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionStart == 0))
            {
                e.Handled = true;
            }
        }

        private void rightUnitCB_SelectedValueChanged(object sender, EventArgs e)
        {
            executeConversion();
        }

        private void leftUnitCB_SelectedValueChanged(object sender, EventArgs e)
        {
            executeConversion();
        }

        private void executeConversion() 
        {
            if (!fieldNotNull())
            {
                if (leftUnitCB.Text == "°C")
                {
                    if (rightUnitCB.Text == "°C") rightTB.Text = leftTB.Text;
                    if (rightUnitCB.Text == "°F") rightTB.Text = ((Convert.ToDouble(leftTB.Text) * 9 / 5) + 32).ToString();
                    if (rightUnitCB.Text == "K") rightTB.Text = (Convert.ToDouble(leftTB.Text) + 273.15).ToString();
                }
                else if (leftUnitCB.Text == "°F")
                {
                    if (rightUnitCB.Text == "°C") rightTB.Text = ((Convert.ToDouble(leftTB.Text) - 32) * 5 / 9).ToString();
                    if (rightUnitCB.Text == "°F") rightTB.Text = leftTB.Text;
                    if (rightUnitCB.Text == "K") rightTB.Text = (((Convert.ToDouble(leftTB.Text) - 32) * 5 / 9 + 273.15)).ToString();
                }
                else if (leftUnitCB.Text == "K")
                {
                    if (rightUnitCB.Text == "°C") rightTB.Text = (Convert.ToDouble(leftTB.Text) - 273.15).ToString();
                    if (rightUnitCB.Text == "°F") rightTB.Text = ((Convert.ToDouble(leftTB.Text) - 273.15) * 9 / 5 + 32).ToString();
                    if (rightUnitCB.Text == "K") rightTB.Text = leftTB.Text;
                }
                
            }
            
        }

        public bool fieldNotNull() 
        {
            return leftTB.Text == "";
        }
    }

}
