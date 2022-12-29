using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
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

namespace System_INFO
{

    public partial class MainWindow : Window
    {
        string getData(string keyName, string valueName)
        {
            string data = Convert.ToString(Microsoft.Win32.Registry.GetValue(keyName, valueName, null));
            return data;
        }
        public MainWindow()
        {
            InitializeComponent();

            string CPUName = getData("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\SYSTEM\\CentralProcessor\\0", "ProcessorNameString");
            string BaseBoardManufacturer = getData("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardManufacturer");
            string BaseBoardProduct = getData("HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS", "BaseBoardProduct");

            cpuName.Content = "CPU :  " + CPUName;
            cpuName.FontFamily = new FontFamily("맑은 고딕");

            MainBoardManufacturer.Content = "메인보드 제조사 : " + BaseBoardManufacturer;
            MainBoardManufacturer.FontFamily = new FontFamily("맑은 고딕");

            MainBoardProduct.Content= "메인보드 제품명: " + BaseBoardProduct;
            MainBoardProduct.FontFamily = new FontFamily("맑은 고딕");
        }

    }
}
