﻿using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using TEditor;

namespace TEditor.Forms.Sample
{
    public class TEditorHtmlView : StackLayout
    {
        //create bindable property, html
        public string Html { get; set; }
        WebView _displayWebView;
        public TEditorHtmlView()
        {
            this.Orientation = StackOrientation.Vertical;
            this.Children.Add(new Button
            {
                Text = "HTML Editor",
                HeightRequest = 100,
                Command = new Command(async (obj) =>
                {
                    await ShowTEditor();
                })
            });
            _displayWebView = new WebView() { HeightRequest = 500 };
            this.Children.Add(_displayWebView);
        }

        async Task ShowTEditor()
        {

            string html = await CrossTEditor.Current.ShowTEditor("<!-- This is an HTML comment --><p>This is a test of the <strong>TEditor</strong> by <a title=\"XAM consulting\" href=\"http://www.xam-consulting.com\">XAM consulting</a></p>");
            if (!string.IsNullOrEmpty(html))
                _displayWebView.Source = new HtmlWebViewSource() { Html = html };

        }
    }
}

