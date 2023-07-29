namespace MauiDemoApp;

using MauiDemoApp.Models;
using MauiDemoApp.Views;
using System.Diagnostics;

public partial class MainPage : BaseContentPage
{

    List<StudentModel> studentModels = new List<StudentModel>();

    public MainPage()
    {

        try
        {
            InitializeComponent();
        }
        catch (Exception ex)
        {
            Debug.Write(ex.ToString());
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        studentModels = new List<StudentModel>();
        studentModels.Add(new StudentModel { Id = 1, StudentName = "A" });
        studentModels.Add(new StudentModel { Id = 2, StudentName = "B" });
        studentModels.Add(new StudentModel { Id = 3, StudentName = "C" });
        studentModels.Add(new StudentModel { Id = 4, StudentName = "D" });
        CVStudentData.ItemsSource = studentModels;
    }

    private void CVStudentData_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        try
        {

        }
        catch (Exception)
        {
        }
    }
}

