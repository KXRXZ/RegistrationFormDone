namespace RegistrationFormDone.Pages;

public partial class RegistrationForm2 : ContentPage
{
    Label label; // Declare the Label variable.

    public RegistrationForm2()
	{
		InitializeComponent();
	}
    private void OnSubmitClicked(object sender, EventArgs e)
    {
        bool course1Selected = Course1CheckBox.IsChecked;
        bool course2Selected = Course2CheckBox.IsChecked;
        bool course3Selected = Course3CheckBox.IsChecked;
        bool course4Selected = Course4CheckBox.IsChecked;
        bool course5Selected = Course5CheckBox.IsChecked;
        bool course6Selected = Course6CheckBox.IsChecked;

        coursePicker.SelectedIndexChanged += (sender, args) =>
        {
            int selectedIndex = coursePicker.SelectedIndex;
            string selectedCourse = (string)coursePicker.SelectedItem;

            // You can now use the selected index and course as needed.
            // Example: Display it in a label
            label.Text = $"Selected Course: {selectedCourse}";
        };


    }


}



