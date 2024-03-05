using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingSystem
{
    public partial class Main : Form
    {
        private bool enable = true;
        List<Vehicle> parkIn;
        List<Vehicle> parkOut;

        public Main()
        {
            InitializeComponent();
        }
        internal Main(List<Vehicle> parkIn, List<Vehicle> parkOut)
        {
            InitializeComponent();
            this.parkIn = parkIn;
            this.parkOut = parkOut;
            setListBox();
            setHistoryList();
        }


        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login newLogin = new Login(parkIn, parkOut);
            newLogin.Show();
        }

        private void home_Click(object sender, EventArgs e)
        {
            parkInBtn.Visible = enable;
            ParkOutBtn.Visible = enable;
            plateNoH.Visible = !enable;
            timeInH.Visible = !enable;
            timeOutH.Visible = !enable;
            hrsParkedTxt.Visible = !enable;
            hrsParkedBox.Visible = !enable;
            feeText.Visible = !enable;
            feeBox.Visible = !enable;
            parkOutConfirm.Visible = !enable;
            parkOutBack.Visible = !enable;
            timeOutText.Visible = !enable;
            timeOutType.Visible = !enable;
            plateNoTxtPOD.Visible = !enable;
            brandPOD.Visible = !enable;
            timeInText.Visible = !enable;
            timeInBox.Visible = !enable;
            parkOutTxt.Visible = !enable;
            parkOutBoxP.Visible = !enable;
            typeTxt.Visible = !enable;
            typeCB.Visible = !enable;
            brandTxt.Visible = !enable;
            brandCB.Visible = !enable;
            plateNoTxt.Visible = !enable;
            txtbPlateNo.Visible = !enable;
            historyList.Visible = !enable;
            homeBackBtn.Visible = !enable;
            confirmPark.Visible = !enable;
            plateNoPOD.Visible = !enable;
            typePOD.Visible = !enable;
            typeTextPOD.Visible = !enable;
            brandTextPOD.Visible = !enable;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyList.Visible = enable;
            plateNoH.Visible = enable;
            timeInH.Visible = enable;
            timeOutH.Visible = enable;
            hrsParkedTxt.Visible = !enable;
            hrsParkedBox.Visible = !enable;
            feeText.Visible = !enable;
            feeBox.Visible = !enable;
            parkOutConfirm.Visible = !enable;
            parkOutBack.Visible = !enable;
            parkOutTxt.Visible = !enable;
            parkOutBoxP.Visible = !enable;
            timeOutText.Visible = !enable;
            timeOutType.Visible = !enable;
            timeInText.Visible = !enable;
            timeInBox.Visible = !enable;
            typeTxt.Visible = !enable;
            typeCB.Visible = !enable;
            brandTxt.Visible = !enable;
            brandCB.Visible = !enable;
            plateNoTxt.Visible = !enable;
            txtbPlateNo.Visible = !enable;
            homeBackBtn.Visible = !enable;
            parkInBtn.Visible = !enable;
            ParkOutBtn.Visible = !enable;
            confirmPark.Visible = !enable;
            plateNoPOD.Visible = !enable;
            typePOD.Visible = !enable;
            brandPOD.Visible = !enable;
            plateNoTxtPOD.Visible = !enable;
            typeTextPOD.Visible = !enable;
            brandTextPOD.Visible = !enable;
        }

        private void parkInBtn_Click(object sender, EventArgs e)
        {
            typeTxt.Visible = enable;
            typeCB.Visible = enable;
            brandTxt.Visible = enable;
            brandCB.Visible = enable;
            plateNoTxt.Visible = enable;
            txtbPlateNo.Visible = enable;
            homeBackBtn.Visible = enable;
            confirmPark.Visible = enable;
            plateNoH.Visible = !enable;
            timeInH.Visible = !enable;
            timeOutH.Visible = !enable;
            hrsParkedTxt.Visible = !enable;
            hrsParkedBox.Visible = !enable;
            feeText.Visible = !enable;
            feeBox.Visible = !enable;
            parkOutConfirm.Visible = !enable;
            parkOutBack.Visible = !enable;
            timeOutText.Visible = !enable;
            timeOutType.Visible = !enable;
            timeInText.Visible = !enable;
            timeInBox.Visible = !enable;
            historyList.Visible = !enable;
            parkInBtn.Visible = !enable;
            ParkOutBtn.Visible = !enable;
            plateNoPOD.Visible = !enable;
            typePOD.Visible = !enable;
            brandPOD.Visible = !enable;
            plateNoTxtPOD.Visible = !enable;
            typeTextPOD.Visible = !enable;
            brandTextPOD.Visible = !enable;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BackButton();
        }

        private void typeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Types();
        }

        enum bikeBrands
        {
            Kawasaki,
            Honda,
            Yamaha
        }

        enum SUVBrands
        {
            Toyota,
            Suzuki,
            Ferrari
        }

        enum SedanBrands
        {
            Toyota,
            Suzuki,
            Volkswagen,
            Mitsubishi
        }

        void Types()
        {

            switch (typeCB.Text)
            {
                case "Motorbike":
                    brandCB.Items.Clear();
                    foreach (bikeBrands value in Enum.GetValues(typeof(bikeBrands)))
                    {
                        brandCB.Items.Add(value);
                    }
                    break;
                case "SUV":
                    brandCB.Items.Clear();
                    foreach (SUVBrands value in Enum.GetValues(typeof(SUVBrands)))
                    {
                        brandCB.Items.Add(value);
                    }
                    break;
                case "Sedan":
                    brandCB.Items.Clear();
                    foreach (SedanBrands value in Enum.GetValues(typeof(SedanBrands)))
                    {
                        brandCB.Items.Add(value);
                    }
                    break;

            }

        }

        void BackButton()
        { // back button method
            parkInBtn.Visible = enable;
            ParkOutBtn.Visible = enable;
            plateNoH.Visible = !enable;
            timeInH.Visible = !enable;
            timeOutH.Visible = !enable;
            hrsParkedTxt.Visible = !enable;
            hrsParkedBox.Visible = !enable;
            feeText.Visible = !enable;
            feeBox.Visible = !enable;
            parkOutBack.Visible = !enable;
            parkOutConfirm.Visible = !enable;
            parkOutBoxP.Visible = !enable;
            parkOutTxt.Visible = !enable;
            timeOutText.Visible = !enable;
            timeOutType.Visible = !enable;
            timeInText.Visible = !enable;
            timeInBox.Visible = !enable;
            typeTxt.Visible = !enable;
            typeCB.Visible = !enable;
            brandTxt.Visible = !enable;
            brandCB.Visible = !enable;
            txtbPlateNo.Visible = !enable;
            plateNoTxt.Visible = !enable;
            homeBackBtn.Visible = !enable;
            confirmPark.Visible = !enable;
            plateNoPOD.Visible = !enable;
            typePOD.Visible = !enable;
            brandPOD.Visible = !enable;
            plateNoTxtPOD.Visible = !enable;
            typeTextPOD.Visible = !enable;
            brandTextPOD.Visible = !enable;
        }


        private void ParkOutBtn_Click(object sender, EventArgs e)
        {
            timeInText.Visible = enable;
            timeInBox.Visible = enable;
            plateNoTxtPOD.Visible = enable;
            typeTextPOD.Visible = enable;
            brandTextPOD.Visible = enable;
            plateNoPOD.Visible = enable;
            typePOD.Visible = enable;
            brandPOD.Visible = enable;
            parkOutTxt.Visible = enable;
            parkOutBoxP.Visible = enable;
            timeOutText.Visible = enable;
            timeOutType.Visible = enable;
            parkOutBack.Visible = enable;
            parkOutConfirm.Visible = enable;
            hrsParkedTxt.Visible = enable;
            hrsParkedBox.Visible = enable;
            feeText.Visible = enable;
            feeBox.Visible = enable;
            plateNoH.Visible = !enable;
            timeInH.Visible = !enable;
            timeOutH.Visible = !enable;
            parkInBtn.Visible = !enable;
            ParkOutBtn.Visible = !enable;
            confirmPark.Visible = !enable;
        }

        private void parkOutBack_Click(object sender, EventArgs e)
        {
            BackButton();
        }

        public void setListBox()
        {
            parkOutBoxP.Items.Clear();
            foreach (Vehicle v in parkIn)
            {
                parkOutBoxP.Items.Add(v.plateNo);
            }
        }

        bool exists(String plate)
        {
            foreach (Vehicle v in parkIn)
            {
                if (v.plateNo == plate)
                {
                    return true;
                }
            }

            return false;
        }
        bool isValidPlate (string plate)
        {
            if (plate.Length > 5 && plate.Length < 9)
            {
                return true; 
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e) // confirmPark
        {
            string plateNo = txtbPlateNo.Text;
            string type = typeCB.Text;
            string brand = brandCB.Text;

            if (plateNo == "" || type == "Select Vehicle Type" || brand == "Select Vehicle Brand")
            {
                MessageBox.Show("Please Fill Up All The Details.");
                return;
            }

            if (!isValidPlate(plateNo))
            {
                MessageBox.Show("Plate length should be between 6 - 8 characters.");
                return;
            }
            
            if (!exists(plateNo))
            {
                parkIn.Add(new Vehicle(plateNo.ToUpper(), type, brand));
                MessageBox.Show("Vehicle parked in!");
                setListBox();

                txtbPlateNo.Clear();
                typeCB.Text = "Select Vehicle Type";
                brandCB.Text = "Select Vehicle Brand";
            }
            else
            {
                MessageBox.Show("This vehicle is already parked!");
            }
            

        }

        private float getFee(Vehicle v, int hours)
        {
            float flagDown = 0.00f, additional = 0.00f;

            switch (v.Type.ToUpper())
            {
                case "MOTORBIKE":
                    flagDown = 20.00f;
                    additional = 5.00f;
                    break;
                case "SUV":
                    flagDown = 40.00f;
                    additional = 20.00f;
                    break;
                case "SEDAN":
                    flagDown = 30.00f;
                    additional = 15.00f;
                    break;
            }
            hours = (hours == 0) ? 1 : hours;
            return flagDown + (additional * hours);
        }
        void setHistoryList() {
            historyList.Items.Clear();
            foreach (Vehicle v in parkOut)
            {
                historyList.Items.Add("      " + v.plateNo + "\t\t\t" + v.dateTime + "\t " + v.TimeOut);
            }
        }
        private void parkOutConfirm_Click(object sender, EventArgs e)
        {

            string selected = parkOutBoxP.SelectedItem as string;
            int index = parkIn.FindIndex(v => v.plateNo == selected);

            if (index != null && plateNoPOD.Text != "" && typePOD.Text != ""
                && brandPOD.Text != "" && timeInBox.Text != "")
            {
                if (timeOutType.Text == "")
                {
                    MessageBox.Show("Please input the time out of the vehicle!");
                    return;
                }

                DateTime outTime;

                if (DateTime.TryParse(timeOutType.Text, out outTime))
                {
                    Vehicle v = parkIn[index];
                    v.TimeOut = outTime;
                    TimeSpan getDifference = outTime.Subtract(v.dateTime);

                    if (outTime <= v.dateTime)
                    {
                        MessageBox.Show("Invalid input for time of out, lesser than or equal time in.");
                        return;
                    }

                    float fee = getFee(v, Convert.ToInt32(getDifference.Hours));
                    hrsParkedBox.Text = getDifference.Hours.ToString();
                    feeBox.Text = fee.ToString();
                    //MessageBox.Show(Convert.ToString(getDifference.Hours));
                    //MessageBox.Show(Convert.ToString(fee));
                    MessageBox.Show("Vehicle Successfully Parked Out!");

                    parkOut.Add(parkIn[index]);
                    setHistoryList();
                    parkIn.RemoveAt(index);
                    setListBox();

                    plateNoPOD.Clear();
                    typePOD.Clear();
                    brandPOD.Clear();
                    timeInBox.Clear();
                    timeOutType.Clear();
                    hrsParkedBox.Clear();
                    feeBox.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid input for time out.");
                }

            }
        }


        private void parkOutBoxP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = parkOutBoxP.SelectedItem as string;
            int index = parkIn.FindIndex(v => v.plateNo == selectedItem);
            if (selectedItem != null)
            {
                plateNoPOD.Text = parkIn[index].plateNo;
                typePOD.Text = parkIn[index].type;
                brandPOD.Text = parkIn[index].brand;
                timeInBox.Text = Convert.ToString(parkIn[index].dateTime);
            }
        }
        private void parkOutBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void brandCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Day computation for time out
    }
}
