using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SecondProject.Model;


namespace SecondProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        //Create list of comment and fill with some data id=1. title= good class, Description = have more class like this
        //id=2, title= worst class, Description = no more class like this

        public ListViewPage()
        {
            InitializeComponent();

            //Student st = new Student();
            //Comment comment = new Comment();
            //comment.Id = 1;
            //comment.Title = "good";
            //comment.Description = "Have more class like this";

            //Comment comment2 = new Comment();
            //comment.Id = 2;
            //comment.Title = "worst";
            //comment.Description = "No more class like this";

            //st.comments.Add(comment);
            //st.comments.Add(comment2);
        }

        List<Comment> comments = new List<Comment>
        {
            new Comment
            {
                Id = 1,
                Title = "good",
                Photo = "lili.png",
                Description = "Have more class like this"
            },
            new Comment
            {
                Id = 1,
                Title = "worst",
                Photo = "arash.jpg",
        Description = "No more class like this"
            }
        };

        private void CommentView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = (ListView)sender;
            var selectedItm = (Comment)listView.SelectedItem;
            var id = selectedItm.Id;
            var title = selectedItm.Title;
            var description = selectedItm.Description;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //CommentView.ItemsSource = comments;
            //listView1.ItemsSource = comments;
            ListView2.ItemsSource = comments;
        }

        private void OnDelete_Clicked(object sender, EventArgs e)
        {

        }

        private void OnMore_Clicked(object sender, EventArgs e)
        {
            var more = (MenuItem)sender;
            //DisplayAlert("More Action", more.CommandParameter, "More Context", "OK");
        }
    }
}