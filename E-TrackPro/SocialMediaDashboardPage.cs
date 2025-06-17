using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHandlingLibrary;
using DataHandlingLibrary.UserNamespace;
using DataHandlingLibrary.PostNamespace;
using System.Collections.ObjectModel;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace E_TrackPro
{
    public partial class SocialMediaDashboardPage : Form
    {

        ObservableCollection<Post> _posts;
        ObservableCollection<User> _Users;


        // a constructor that can pass the post and user data to it 
        public SocialMediaDashboardPage(ObservableCollection<Post> postResppons, ObservableCollection<User> userResppons)
        {
            InitializeComponent();
            //assign to collection
            _posts = postResppons;
            _Users = userResppons;
        }

        private void SocialMediaDashboardPage_Load(object sender, EventArgs e)
        {
            PopUpListPost();
        }

        private void PopUpListPost()
        {

            for (int i = 0; i < _posts.Count; i++)
            {
                ListPostViewePanel.Controls.Add(ConvertPostToListPostComentCell(_posts[i], _Users[i]));
            }


        }


        private ListPostComentCell ConvertPostToListPostComentCell(Post post, User user)
        {
            return new ListPostComentCell(
                id: post.Id,
                title: post.Title,
                body: post.Body,
                userId: post.UserId,
                tags: post.Tags,
                userName: user.Username,
                userPicture: user.Image,
                age: user.Age

                );
        }



    }
}
