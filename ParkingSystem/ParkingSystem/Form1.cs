namespace ParkingSystem
{
    public partial class Login : Form
    {
        List<Vehicle> parkIn;
        List<Vehicle> parkOut;
        public Login()
        {
            InitializeComponent();
        }
        internal Login(List<Vehicle> parkIn, List<Vehicle> parkOut)
        {
            InitializeComponent();
            this.parkIn = parkIn;
            this.parkOut = parkOut;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main newMain = new Main(parkIn, parkOut);
            newMain.Show();
        }
    }
}
