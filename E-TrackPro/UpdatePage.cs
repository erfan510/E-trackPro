using DataHandlingLibrary;
using DataHandlingLibrary.UserNamespace;
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
    public partial class UpdatePage : Form
    {
        public UpdatePage()
        {
            InitializeComponent();
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                // check if input value if is null or empty
                if (!string.IsNullOrEmpty(IdTextBox.Text))
                {
                    // clear the panle 
                    UserPanelViewer.Controls.Clear();

                    // This code takes the input value and converts it to an integer
                    string inputId = IdTextBox.Text;
                    int intId = Convert.ToInt16(inputId);


                    Responses responses = new Responses();

                    // bring the user by specific id 
                    User user = responses.SerchaUserById(intId);

                    // Adding it to Panel using the ListUserCell
                    UserPanelViewer.Controls.Add(
                        new ListUserCell(
                            id: user.Id,
                            userPicture: user.Image,
                            userName: user.Username,
                            firstName: user.FirstName,
                            lastName: user.LastName,
                            age: user.Age,
                            gender: user.Gender

                            )
                        );



                }


            }
            catch
            {
                MessageBox.Show("Invalid value");
            }




        }
    }
}
