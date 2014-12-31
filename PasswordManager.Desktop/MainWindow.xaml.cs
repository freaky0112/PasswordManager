using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordManager.Desktop {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private int state = 0;

        private void Generate_Click(object sender, RoutedEventArgs e) {
            Common.Letters._specialCharacters = tbxSpecial.Text;
            Data data = new Data();
            //LayoutRoot.DataContext = data;
            data.Guid = System.Guid.NewGuid().ToString();
            if (state == Common.State._new) {
                data.GenerateTime = System.DateTime.Now;
            }
            data.ModifyTime = System.DateTime.Now;
            StringBuilder characters = new StringBuilder();
            if ((bool)cbxUpper.IsChecked) {
                characters.Append(Common.Letters._upperLetters);
            }
            if ((bool)cbxLower.IsChecked) {
                characters.Append(Common.Letters._lowerLetters);
            }
            if ((bool)cbxNumber.IsChecked) {
                characters.Append(Common.Letters._number);
            }
            if ((bool)cbxSpecial.IsChecked) {
                characters.Append(Common.Letters._specialCharacters);
            }
            int digits = Int32.Parse(tbxDigits.Text);
            lblPassword.Content = Generate(characters.ToString(), digits);
        }



        private string Generate(string characters, int digits) {
            string keyword = "";
            int length = characters.Length;
            for (int i = 0; i < digits;i++ ) {
                Random rnd = new Random(unchecked((int)(DateTime.Now.Ticks >> i)));
                int a = rnd.Next(length);
                keyword += characters.ToCharArray()[a];
            }
            return keyword;
        }

        private void tbxDigits_KeyDown(object sender, KeyEventArgs e) {
            TextBox txt = sender as TextBox;
            //屏蔽非法按键，只能输入整数
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)) {
                e.Handled = false;
            } else {
                e.Handled = true;
            }
        }
    }
}
