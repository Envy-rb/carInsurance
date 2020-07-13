using kursvaya.validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursvaya
{
    public partial class recordForm : Form
    {
        public recordForm()
        {
            InitializeComponent();
        }

        private person getPerson()
        {
            int _age, _drivingExperience;
            int.TryParse(age.Text, out _age);
            int.TryParse(drivingExperience.Text, out _drivingExperience);
            personValidator validator = new personValidator();
            if (validator.stringValidator(name.Text) && validator.stringValidator(surname.Text) && validator.stringValidator(middlename.Text) && validator.ageValidator(_age) && validator.drivingExperienceValidator(_drivingExperience))
            {
                return new person(name.Text, surname.Text, middlename.Text, _age, _drivingExperience);
            }
            else
            {
                label1.BackColor = Color.Red;
                timer1.Start();
                return null;
            }

        }

        private car getCar()
        {
            double _price;
            double.TryParse(price.Text, out _price);
            carValidator validator = new carValidator();
            if (validator.modelValidator(model.Text) && validator.numberValidator(number.Text) && validator.priceValidator(_price))
            {
                return new car(getPerson(), model.Text, number.Text, _price);
            }
            else
            {
                label7.BackColor = Color.Red;
                timer1.Start();
                return null;
            }
        }

        public record getRecord()
        {
            double _insurancePrice;
            record Record = null;
            double.TryParse(insurancePrice.Text, out _insurancePrice);
            if (_insurancePrice > 0)
            {
                return new record(getCar(), _insurancePrice, dateTimePicker.Value);
            }
            else
            {
                label12.BackColor = Color.Red;
                timer1.Start();
                return Record;
            }
            return null;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recordForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.BackColor = Color.Empty;
            label7.BackColor = Color.Empty;
            label12.BackColor = Color.Empty;
            timer1.Enabled = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (getPerson() != null && getCar() != null && getRecord() != null)
            {
                Close();
            }
            else
            {

            }
        }
    }
}
