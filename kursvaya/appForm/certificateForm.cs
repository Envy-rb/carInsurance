using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursvaya.appForm
{
    public partial class certificateForm : Form
    {
        Boolean fl = true;
        public certificateForm(record record)
        {
            InitializeComponent();
            if (record != null)
            {
                MarkLabel.Text = record.Car.Model;
                NumberLabel.Text = record.carNumber;
                person person = record.Car.Owner;
                FIOLabel.Text = string.Format("{0} {1} {2}", person.Surname, person.Name, person.MiddleName);
                FIOLabel1.Text = string.Format("{0} {1} {2}", person.Surname, person.Name, person.MiddleName);
                AgeLabel.Text = person.Age.ToString();
                DrivingExpLabel.Text = person.DrivingExperience.ToString();
                TotalPriceLabel.Text = record.InsurancePrice.ToString();
                GetControlScreenshot(this);
                fl = false;
            }
        }

        private void certificateForm_Load(object sender, EventArgs e)
        {
            if (fl)
                Close();
        }

        public void GetControlScreenshot(Control control)
        {
            Size szCurrent = control.Size;
            control.AutoSize = true;

            Bitmap bmp = new Bitmap(control.Width, control.Height);
            control.DrawToBitmap(bmp, control.ClientRectangle);


            control.AutoSize = false;
            control.Size = szCurrent;

            bmp.Save("Cert.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
