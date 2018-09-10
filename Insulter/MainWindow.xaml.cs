using MahApps.Metro.Controls;
using System;
using System.Windows;
using System.Windows.Input;
using Insulter.Class;

namespace Insulter {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow {

        private double ScreenHeight = SystemParameters.PrimaryScreenHeight;
        private double ScreenWidth = SystemParameters.PrimaryScreenWidth;

        private Random random = new Random();

        public MainWindow() {
            InitializeComponent();
            Loader.Load();
            InsultBox.Text = Loader.GetInsult;
        }

        private void MetroWindow_MouseEnter(object sender, MouseEventArgs e) {
            Left = random.Next(Convert.ToInt32(ScreenWidth) - Convert.ToInt32(Width));
            Top = random.Next(Convert.ToInt32(ScreenHeight) - Convert.ToInt32(Height));
            InsultBox.Text = Loader.GetInsult;
        }
    }
}
