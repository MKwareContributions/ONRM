//    Oversimplified Number Randomizing Machine - number randomizer
//    Copyright (C) 2022 MKware
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Affero General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Affero General Public License for more details.
//
//    You should have received a copy of the GNU Affero General Public License
//    along with this program. If not, see <https://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace ONRMv2
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            fromField.KeyDown += new KeyEventHandler(EnsureNumbers);
            toField.KeyDown += new KeyEventHandler(EnsureNumbers);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fromStr = fromField.Text;
            string toStr = toField.Text;
            int fromInt = System.Convert.ToInt32(fromStr);
            int toInt = System.Convert.ToInt32(toStr);
            int answerInt = RandomRange(fromInt, toInt);
            answerField.Content = answerInt;

        }
        void EnsureNumbers(object sender, KeyEventArgs e)
        {
            if (((e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Back || e.Key == Key.Tab))

                e.Handled = false;

            else
            {
                e.Handled = true;

            }
        }
        private readonly Random _random = new Random();
        public int RandomRange(int min, int max)
        {
            return _random.Next(min, max);
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            answerField.Content = null;
        }
    }
}
