namespace Radio
{
    public partial class MainPage : ContentPage
    {
        private readonly Color[]
           colors = { Colors.Red, Colors.Green, Colors.Yellow, Colors.Orange };
        private int colorIndex = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)

       {

       label.FontSize = e.NewValue;

        }

       private void ButtonClicked(object sender, EventArgs e)
        {
            label1.TextColor = colors[colorIndex];
           colorIndex = (colorIndex + 1) % colors.Length;
        }
         private void TextAligment_Chenged(object sender, CheckedChangedEventArgs e)
        {
            if (!(sender is RadioButton rb) || !rb.IsChecked) return;
            if (rb == Left)
                label1.HorizontalTextAlignment = TextAlignment.Start;
            else if (rb == Center)
                label1.HorizontalTextAlignment = TextAlignment.Center;
            else if (rb == Right)
                label1.HorizontalTextAlignment = TextAlignment.End;

        } 
    }

}
