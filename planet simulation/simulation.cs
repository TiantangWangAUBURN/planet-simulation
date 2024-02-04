using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planet_simulation
{
    public partial class simulation : Form
    {
        CheckedListBox checkMaster;
        public simulation()
        {
            InitializeComponent();
            this.FormClosing += Simulation_Closing;
            
            checkMaster = new CheckedListBox();
            checkMaster.Location = new Point(250, 300); 
            checkMaster.Size = new Size(300, 100);
            checkMaster.Items.Add("steel");
            checkMaster.Items.Add("alloy");
            checkMaster.Items.Add("High molecular polymer");
            checkMaster.CheckOnClick = true;
            checkMaster.ItemCheck += new ItemCheckEventHandler(checkMaster_ItemCheck);
            checkMaster.Font = new Font(checkMaster.Font.Name, 14);

            this.Controls.Add(checkMaster);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedPlanet = comboBox1.SelectedItem.ToString();
                int size = (int)numericUpDown1.Value;
                int time = (int)numericUpDown2.Value;
                int people = (int)numericUpDown3.Value;


                List<string> selectedResources = new List<string>();
                foreach (object itemChecked in checkMaster.CheckedItems)
                {
                    selectedResources.Add(itemChecked.ToString());
                }

                CalculateSimulation calculator = new CalculateSimulation();
                AllResult result = calculator.CalculateEat(selectedPlanet, size, time, people, selectedResources);

                if (result.Size == 0)
                {
                    MessageBox.Show("error, please enter number of colonial size ");
                }
                else if (result.Time == 0)
                {
                    MessageBox.Show("error, please enter resource of duration ");
                }
                else if (result.People == 0)
                {
                    MessageBox.Show("error, please enter number of people ");
                }
                else if (result.Count == 0)
                {
                    MessageBox.Show("error, please select resource");
                }
                else
                {
                    MessageBox.Show("The calculation result is: \nTotal required: " + result.TotalEat
                    + " kg" + " of which " + result.Consumption + " kg of food was consumed on the way."
                    + "\nTotal Material that we need are " + result.TotalMaterial + " kg of materials");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error, please select planet ");
            }
        }
        private void Simulation_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void checkMaster_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            string item = checkMaster.Items[e.Index].ToString();
            bool isChecked = e.NewValue == CheckState.Checked;
            
            MessageBox.Show(item + (isChecked ? " Selected" : " deselected"));
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void simulation_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "yes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
