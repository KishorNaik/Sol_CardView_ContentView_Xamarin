using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sol_Demo.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class CardViewComponent : ContentView
    {
        public CardViewComponent()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty CardNameProperty = BindableProperty.Create(nameof(CardName), typeof(string), typeof(CardViewComponent), string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardViewComponent), string.Empty);
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardViewComponent), Color.DarkGray);
        public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(CardViewComponent), Color.White);
        public static readonly BindableProperty CardDeleteCommandProperty = BindableProperty.Create(nameof(CardDeleteCommand), typeof(Object), typeof(CardViewComponent), string.Empty);

        public string CardName
        {
            get => (string)GetValue(CardViewComponent.CardNameProperty);
            set => SetValue(CardViewComponent.CardNameProperty, value);
        }

        public string CardDescription
        {
            get => (string)GetValue(CardViewComponent.CardDescriptionProperty);
            set => SetValue(CardViewComponent.CardDescriptionProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)GetValue(CardViewComponent.BorderColorProperty);
            set => SetValue(CardViewComponent.BorderColorProperty, value);
        }

        public Color CardColor
        {
            get => (Color)GetValue(CardViewComponent.CardColorProperty);
            set => SetValue(CardViewComponent.CardColorProperty, value);
        }

        public Object CardDeleteCommand
        {
            get => (Object)GetValue(CardViewComponent.CardDeleteCommandProperty);
            set => SetValue(CardViewComponent.CardDeleteCommandProperty, value);
        }
    }
}