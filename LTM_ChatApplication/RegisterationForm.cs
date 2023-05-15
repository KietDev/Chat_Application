using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace LTM_ChatApplication
{
    public partial class RegisterationForm : Form
    {
        public RegisterationForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "OW9ry0nAgG5IqWqpFPU3e37W6Z75C9i3IdDy5QZ7",
            BasePath = "https://chatapplication-95820-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        private void RegisterationForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("No Internet of Connection Problem");
            }

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) || string.IsNullOrWhiteSpace(PasswordTbox.Text) || string.IsNullOrWhiteSpace(ConfirmPasswordTbox.Text) || string.IsNullOrWhiteSpace(FullNameTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion
            Myuser user = new Myuser()
            {
                Username = UsernameTbox.Text,
                Password = PasswordTbox.Text,
                ConfirmPassword = ConfirmPasswordTbox.Text,
                FullName = FullNameTbox.Text
            };
            SetResponse set = client.Set(@"Users/" + UsernameTbox.Text, user);

            MessageBox.Show("Successfull registered!");
        }
    }
}
