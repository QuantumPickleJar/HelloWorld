using Xamarin.Forms;
namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    { 
        public HelloWorldPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            string strGreet = "Hello World!";
            string strBye = "Goodbye World!";

            //DEBUG lblHello.Text = lblHello.Text.CompareTo(strGreet);

            //if the text already displayed is strGreet, 
            //swap text property to strBye...


            if (lblHello.Text.CompareTo(strGreet) == 0)
            {
                lblHello.Text = strBye;
            }

            //... and vice versa
            else if (lblHello.Text.CompareTo(strBye) == 0)
            {
                lblHello.Text = strGreet;
            }
            else lblHello.Text = "Somehow, something managed to go wrong.";



        }
    }
}
