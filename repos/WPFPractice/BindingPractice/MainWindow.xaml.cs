using BindingPractice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace BindingPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TraineeInfo trainee = new TraineeInfo
            {
                Name = "",
                ClientCompanyName = "",
                MobileNumber = "",
                Address = "",
                Photo = ""
            };
            this.DataContext = trainee;

            //List<TraineeInfo> train = new List<TraineeInfo>
            //{
            //    new TraineeInfo
            //    {
            //        Name = "Paras Jain",
            //        ClientCompanyName = "Atmecs",
            //        MobileNumber = "1234567890",
            //        Address = "Durga Pg Kundalahalli",
            //        Photo = "Images/parasddd.jpg",
            //    },

            //        new TraineeInfo
            //        {
            //            Name = "Pratham vashisht",
            //            ClientCompanyName = "Atmecs",
            //            MobileNumber = "8956231470",
            //            Address = "Durga Pg Kundalahalli",
            //            Photo = "Images/rdj.jpg",
            //         },

            //         new TraineeInfo
            //        {
            //            Name = "Siddharth Tayade",
            //            ClientCompanyName = "Atmecs",
            //            MobileNumber = "1234567890",
            //            Address = "Durga Pg Kundalahalli",
            //            Photo = "Images/ch.jpg",
            //         },

            //          new TraineeInfo
            //        {
            //            Name = "Shashank Singh",
            //            ClientCompanyName = "Atmecs",
            //            MobileNumber = "1234567890",
            //            Address = "Durga Pg Kundalahalli",
            //            Photo = "Images/ss.jpg",
            //         },
            //    };
            //this.DataContext = train;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TraineeInfo t1 = (TraineeInfo)this.DataContext;
            t1.Name = "Paras Jain";
            t1.ClientCompanyName = "Atmecs";
            t1.MobileNumber = "1234567890";
            t1.Address = "Durga Pg Kundalahalli";
            t1.Photo = "Images/parasddd.jpg";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TraineeInfo t1 = (TraineeInfo)this.DataContext;
            t1.Name = "Pratham Vashisht";
            t1.ClientCompanyName = "Atmecs";
            t1.MobileNumber = "8956231478";
            t1.Address = "Durga Pg Kundalahalli";
            t1.Photo = "Images/rdj.jpg";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TraineeInfo t1 = (TraineeInfo)this.DataContext;
            t1.Name = "Siddharth Tayada";
            t1.ClientCompanyName = "Atmecs";
            t1.MobileNumber = "5656234512";
            t1.Address = "Durga Pg Kundalahalli";
            t1.Photo = "Images/ch.jpg";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TraineeInfo t1 = (TraineeInfo)this.DataContext;
            t1.Name = "Shashank Singh";
            t1.ClientCompanyName = "Atmecs";
            t1.MobileNumber = "9865321478";
            t1.Address = "Zolo elements Kundalahalli";
            t1.Photo = "Images/ss.jpg";
        }


    }
}