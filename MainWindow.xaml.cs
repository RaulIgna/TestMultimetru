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

using Agilent_34411A_LIB;

namespace TestMultimetru
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Create dmm
        DMM34410A dmm;
        private string ResourceId = "4614";
        private int AutoZeroId = 0;
        private int SelectRange = 0;
        private int NPLC = 0;
        private bool InputImpedance = false;
        private bool NullState = false;
        private double NullValue = 0;
        private bool Run = true;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        public void Open()
        {
            Agilent_34465A_LIB.Open(dmm);
        }

        public void Close()
        {
            Agilent_34465A_LIB.Close(dmm);
        }

        private void ResourceName_OnInitialized(object sender, EventArgs e)
        {
            ResourceName.Text = "4614";
        }

        private void ResourceName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (ResourceNameTip == null) return;
            if(ResourceName.Text.Length <= 0) return;
            if (!int.TryParse(ResourceName.Text,out int number))
            {
                ResourceName.Text = ResourceName.Text.Remove(ResourceName.Text.Length - 1);
                ResourceNameTip.Visibility = Visibility.Visible;
            }
            else
            {
                if (ResourceNameTip.Visibility != Visibility.Hidden) // TODO: Check if this if is actually necessary (Don't think so)
                {
                    ResourceNameTip.Visibility = Visibility.Hidden;
                }   
            }
            if (ResourceName.Text.Length > 4)
            {
                ResourceName.Text = ResourceName.Text.Remove(ResourceName.Text.Length - 1);
            }

            ResourceName.CaretIndex = ResourceName.Text.Length;
            ResourceId = ResourceName.Text;
        }

        private void SelectedNPLC_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NPLC = SelectedNPLC.SelectedIndex;
        }

        private void SelectedIndex_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectRange = SelectedRange.SelectedIndex;
        }

        private void AutoRange_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AutoZeroId = SelectedAutoRange.SelectedIndex;
        }

        private void InputAutoImpedance_OnChecked(object sender, RoutedEventArgs e)
        {
            if (InputAutoImpedance.IsChecked != null) InputImpedance = InputAutoImpedance.IsChecked.Value;

        }

        private void InputNullState_OnChecked(object sender, RoutedEventArgs e)
        {
            if (InputNullState.IsChecked != null) NullState = InputNullState.IsChecked.Value;
        }

        private void InputNullValue_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (NullValueTip == null) return;
            if (InputNullValue.Text.Length == 0) return;
            if (!double.TryParse(InputNullValue.Text, out double result))
            {
                InputNullValue.Text = InputNullValue.Text.Remove(InputNullValue.Text.Length - 1);
                NullValueTip.Visibility = Visibility.Visible;
                
            }
            else
            {
                NullValueTip.Visibility = Visibility.Hidden;
            }
            
            InputNullValue.CaretIndex = InputNullValue.Text.Length;
            NullValue = result;
        }
        
        private void Send_OnClick(object sender, RoutedEventArgs e)
        {
            // Set the ID to the ResourceId and create the driver
            dmm = new DMM34410A(ResourceId);
            
            dmm.DMM_SelectAutoRange(AutoZeroId);
            dmm.DMM_SelectRange(SelectRange);
            dmm.DMM_SelectNPLC(NPLC);
            dmm.InputImpedance = InputImpedance;
            dmm.NullState = NullState;
            dmm.NullValue = NullValue;
            dmm.Run = Run;

            var error = Agilent_34465A_LIB.Open(dmm);
            //if (error.OK)
            //{
                MessageBox.Show(error.Str_Error);
            //}
        }

        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Agilent_34465A_LIB.Close(dmm);
            }
            catch
            {
                MessageBox.Show("Cannot close!");
            }
        }
    }
}
