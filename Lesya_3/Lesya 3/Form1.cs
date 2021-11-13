using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesya_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Intialize_Insurance_Types();
            Insurances_types.SelectedIndexChanged += Insurances_types_SelectedIndexChanged;
        }

        private void Insurances_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            Intialize_Property_Insurance();
        }

        private void Intialize_Insurance_Types()
        {
            Insurances_types.Items.Clear();
            Insurances_types.TabIndex = 0;
            Insurances_types.Text = "None";
            Insurances_types.Items.Add("Жизни");
            Insurances_types.Items.Add("Имущества");
        }
        private void Intialize_Property_Insurance()
        {
            clearInputTextboxes();
            clearLabels();
            if (Insurances_types.Text == "Жизни")
            {
                Globals.inputTextBoxes.Clear();
                Globals.labels.Clear();
                CreateLabel(130, 105, "Имя");
                CreateMyRichTextBox(220, 100);
                CreateLabel(130, 155, "Риск");
                CreateMyRichTextBox(220, 150);
                CreateLabel(130, 205, "Возраст");
                CreateMyRichTextBox(220, 200);
            }
            if (Insurances_types.Text == "Имущества")
            {
                Globals.inputTextBoxes.Clear();
                Globals.labels.Clear();
                CreateLabel(130, 105, "Имя");
                CreateMyRichTextBox(220, 100);
                CreateLabel(130, 155, "Риск");
                CreateMyRichTextBox(220, 150);
                CreateLabel(130, 205, "Цена");
                CreateMyRichTextBox(220, 200);
            }
            drawInputTextboxes();
            drawLabels();
        }

        private void drawInputTextboxes()
        {
            for (int i = 0; i < Globals.inputTextBoxes.Count; i++)
            {
                this.Controls.Add(Globals.inputTextBoxes[i]);

            }
        }

        private void drawLabels()
        {
            for (int i = 0; i < Globals.labels.Count; i++)
            {
                this.Controls.Add(Globals.labels[i]);

            }
        }

        private void clearLabels()
        {
            for (int i = 0; i < Globals.labels.Count; i++)
            {
                this.Controls.Remove(Globals.labels[i]);

            }
        }

        private void clearInputTextboxes()
        {
            for (int i = 0; i < Globals.inputTextBoxes.Count; i++)
            {
                this.Controls.Remove(Globals.inputTextBoxes[i]);
            }
        }
        public RichTextBox CreateMyRichTextBox(int x, int y)
        {
            RichTextBox NewrichTextBox = new RichTextBox();
            NewrichTextBox.Size = new Size(75, 25);
            NewrichTextBox.Location = new Point(x, y);
            NewrichTextBox.Text = "";
            Globals.inputTextBoxes.Add(NewrichTextBox);
            Console.WriteLine(NewrichTextBox.Text);
            return NewrichTextBox;
        }

        public Label CreateLabel(int x, int y, string text)
        {
            Label NewLabel = new Label();
            NewLabel.Size = new Size(75, 25);
            NewLabel.Location = new Point(x, y);
            NewLabel.Text = text;
            Globals.labels.Add(NewLabel);
            Console.WriteLine(NewLabel.Text);
            return NewLabel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void create_insurance_Click(object sender, EventArgs e)
        {
            payment.Text = "";
            if (Insurances_types.Text == "Жизни")
            {
                Personal_insurance personal_Insurance = new Personal_insurance(
                Globals.inputTextBoxes[0].Text,
                Int32.Parse(Globals.inputTextBoxes[1].Text),
                Int32.Parse(Globals.inputTextBoxes[2].Text));
                payment.Text = personal_Insurance.get_payment().ToString();
                price.Text = personal_Insurance.get_insurance_price().ToString();
            }
            if (Insurances_types.Text == "Имущества")
            {
                Property_insurance property_Insurance = new Property_insurance(
                Globals.inputTextBoxes[0].Text,
                Int32.Parse(Globals.inputTextBoxes[1].Text),
                Int32.Parse(Globals.inputTextBoxes[2].Text));
                payment.Text = property_Insurance.get_payment().ToString();
                price.Text = property_Insurance.get_insurance_price().ToString();
            }
        }
    }
}

