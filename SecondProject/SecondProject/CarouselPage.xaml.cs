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
    public partial class CarouselPage : ContentPage
    {
        public CarouselPage()
        {
            InitializeComponent();
        }

        //Add a search bar to search a comment by their title

        List<Comment> comments = new List<Comment>
        {
            new Comment
            {
                Id = 1,
                Title = "good",
                Photo = "lili",
                Description = "Have more class like this"
            },
            new Comment
            {
                Id = 1,
                Title = "worst",
                Photo = "arash",
                Description = "No more class like this"
            },
            new Comment
            {
                Id = 1,
                Title = "great",
                Photo = "lili",
                Description = "Great class this"
            },
        };


        protected override void OnAppearing()
        {
            base.OnAppearing();
            carousel.ItemsSource = comments;
        }

        private void carousel_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            var currentItm = (Comment)e.CurrentItem;
            var previousItm = (Comment)e.PreviousItem;
        }

        void searchBarComment_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            //if (string.IsNullOrEmpty(e.NewTextValue))
            //{
            //    commentsList.ItemSource = comments;
            //} else
            //{
            //    commentsList.ItemSource = comments.Where(c => c.Title.StartsWith(e.NewTextValue));
            //}
           

        }
    }
}