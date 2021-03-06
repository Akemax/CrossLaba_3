using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace App3
{
    public class Page : ContentPage
    {
        public Page()
        {
            Entry Entry1 = new Entry
            {
                Placeholder = "Write",
                TextColor = Color.Brown
            };

            Button Button1 = new Button()
            {
                Text = "Tap"
            };

            Label Label1 = new Label()
            {
                Text = "Hello"
            };

            Button1.Clicked += (sender, args) => Label1.Text = Entry1.Text;

            Content = new StackLayout
            {
                Children = { Entry1, Button1, Label1 }
            };
        }
    }
}
