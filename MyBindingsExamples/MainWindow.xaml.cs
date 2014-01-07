/******************************************************************************/
/*                                                                            */
/*   Program: MyBindingsExamples                                              */
/*   Example for bining in codebehind                                         */
/*                                                                            */
/*   20.12.2013 0.0.0.0 uhwgmxorg Start                                       */
/*                                                                            */
/******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace MyBindingsExamples
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Properties
        /// </summary>
        private double double1;
        public double Double1 { get { return double1; } set { double1 = value; OnPropertyChanged("Double1"); } }
        private bool checkBoxBool1;
        public bool CheckBoxBool1 { get { return checkBoxBool1; } set { checkBoxBool1 = value; OnPropertyChanged("CheckBoxBool1"); } }

        /// <summary>
        /// DependencyProperties
        /// </summary>
        public static DependencyProperty Double2DP = DependencyProperty.Register("Double2", typeof(double), typeof(MainWindow));
        public double Double2 { get { return (double)GetValue(Double2DP); } set { SetValue(Double2DP, value); } }
        public static DependencyProperty CheckBoxBool2DP = DependencyProperty.Register("CheckBoxBool2", typeof(bool), typeof(MainWindow));
        public bool CheckBoxBool2 { get { return (bool)GetValue(CheckBoxBool2DP); } set { SetValue(CheckBoxBool2DP, value); } }

        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // init some vars
            CheckBoxBool2 = true;
            Double2 = 2.5;
            CheckBoxBool1 = false;
            Double1 = 7.5;

            button_1.ToolTip = "Toogle CheckBoxBool1";
            button_2.ToolTip = "Toogle CheckBoxBool2";
            button_3.ToolTip = "...";

            DataContext = this;
        }

        /******************************/
        /*       Button Events        */
        /******************************/
        #region Button Events

        /// <summary>
        /// Button_1_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxBool1 = !CheckBoxBool1;
        }

        /// <summary>
        /// Button_2_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxBool2 = !CheckBoxBool2;
        }

        /// <summary>
        /// Button_3_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            Console.Beep();
        }

        #endregion

        /******************************/
        /*      Menu Events          */
        /******************************/
        #region Menu Events

        #endregion

        /******************************/
        /*      Other Events          */
        /******************************/
        #region Other Events

        #endregion

        /******************************/
        /*      Other Functions       */
        /******************************/
        #region Other Functions

        /// <summary>
        /// OnPropertyChanged
        /// </summary>
        /// <param name="p"></param>
        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }

        #endregion

    }
}
