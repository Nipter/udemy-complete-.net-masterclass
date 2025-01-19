using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace _64_WPFTasks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            MyButton.Content = "Loading...";
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                //string html = webClient.GetStringAsync("https://google.com").Result;
                Thread.Sleep(2000);

                MyButton.Dispatcher.Invoke(new Action(() =>
                {
                    MyButton.Content = "Done";
                }));
               
            });

        }        
        private async void MyButton2_Click(object sender, RoutedEventArgs e)
        {
            MyButton2.Content = "Loading...";
            await Task.Run(async () =>
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient webClient = new HttpClient();
                //string html = webClient.GetStringAsync("https://google.com").Result;
                Thread.Sleep(3000);
               
            });
            MyButton2.Content = "Done";

        }
    }
}
