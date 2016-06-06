using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GitLib;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace GitUI
{
    public class App : Application
    {
        Xamarin.Forms.Label labl, issueTitle, issueUrl, issueBody;
        StackLayout layout;
        public App()
        {
            labl = new Xamarin.Forms.Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to Xamarin Forms!"
            };

            layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,

                Children = {
                        labl
                    }
            };

            MainPage = new ContentPage
            {
                Content = layout
            };
        }

        protected async override void OnStart()
        {
            await Task.Delay(3000);
            labl.Text = "I'm working";
            GitClient gitClient = new GitClient();

            var issuesData = await gitClient.GetIssues("Microsoft", "Typescript");

            labl.Text = "Issues:";
            labl.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Xamarin.Forms.Label));

            ListView listView = new ListView
            {
                ItemsSource = issuesData,

                ItemTemplate = new DataTemplate(() =>
                {
                    var textCell = new TextCell();
                    textCell.SetBinding(TextCell.TextProperty, "title");
                    return textCell;
                }
                )
            };

            listView.ItemTapped += (sender, e) => 
            {
                var issue = (Issue)e.Item;

                ContentPage IssuePage = new ContentPage();
                {
                    layout.Children.Clear();

                    issueTitle = new Xamarin.Forms.Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)),
                        Text = issue.title

                    };

                    issueUrl = new Xamarin.Forms.Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Xamarin.Forms.Label)),
                        Text = issue.url

                    };

                    issueBody = new Xamarin.Forms.Label
                    {
                        FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Xamarin.Forms.Label)),
                        Text = issue.body

                    };

                    layout.Children.Add(issueTitle);
                    layout.Children.Add(issueUrl);
                    layout.Children.Add(issueBody);
                };
            };

            layout.VerticalOptions = LayoutOptions.FillAndExpand;
            layout.HorizontalOptions = LayoutOptions.FillAndExpand;
            layout.Children.Add(listView);
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

//Xamarin.Forms.Label urlLabel = new Xamarin.Forms.Label();
//urlLabel.SetBinding(Xamarin.Forms.Label.TextProperty, "Title");

//return new ViewCell
//{
//    View = new StackLayout
//    {
//        Padding = new Thickness(0, 5),
//        Orientation = StackOrientation.Horizontal,
//        Children =
//        {
//            new StackLayout
//            {
//                VerticalOptions = LayoutOptions.Center,
//                Spacing = 0,
//                Children =
//                {
//                    urlLabel
//                }
//            }
//        }

//    }
//};
