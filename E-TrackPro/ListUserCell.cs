using DataHandlingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_TrackPro
{
    public partial class ListUserCell : UserControl
    {
        private int _id;
        private string _userPicture;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private int _age;
        private string _gender;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        // Public properties with corresponding names
        public string UserPicture
        {
            get { return _userPicture; }
            set { _userPicture = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; UserNameLabel.Text = value; }
        }



        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; FirstNameLabel.Text = FirstName; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; LastNameLable.Text = LastName; }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; AgeLabel.Text = value.ToString(); }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; GenderLabel.Text = value; }
        }



        public ListUserCell(int id, string userPicture, string userName, string firstName, string lastName, int age, string gender)
        {
            InitializeComponent();
            Id = id;
            UserPicture = userPicture;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

        private void ListUserCell_Load(object sender, EventArgs e)
        {
            UserPictureBox.ImageLocation = _userPicture;
        }

        /// <summary>
        /// Handles the click event of the SaveButton.
        /// save the changes that made by the user 
        /// </summary>
        private async void SaveButton_Click(object sender, EventArgs e)
        {
            Responses responses = new Responses();

            //Specifies which data to include in the result set
            List<string> newValueList = new List<string>() {
                UserNameLabel.Text , AgeLabel.Text,
                GenderLabel.Text , FirstNameLabel.Text ,
                LastNameLable.Text

            }; 

             var (success, message) = await responses.PatchUserById(_id, newValueList);
            if (success)
            {
                MessageBox.Show("The user Changed successfully ");
            }
            else
            {
                MessageBox.Show(message);
            }




        }
    }
}
