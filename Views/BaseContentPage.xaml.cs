using System.Diagnostics;

namespace MauiDemoApp.Views;

public partial class BaseContentPage : ContentPage
{

    /// <summary>
    /// BasePageContent
    /// </summary>
    public IList<View> BasePageContent => BaseContentGrid.Children as IList<View>;

    /// <summary>
    /// BaseContentPage
    /// </summary>
    public BaseContentPage()
	{
        try
        {
            InitializeComponent();
        }
        catch (Exception ex)
        {
            Debug.Write(ex);
        }
	}
}