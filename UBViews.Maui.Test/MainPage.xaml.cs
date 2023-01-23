using UBViews.LexParser;

namespace UBViews.Maui;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void OnParseQueryClicked(object sender, EventArgs e)
    {
        string queryInput1 = "mind and ship";
        string queryInput2 = "~rejuvenated";
        var queryEngine = new LexParService();
        var queryResult = queryEngine.ParseQuery(queryInput1);
    }
}