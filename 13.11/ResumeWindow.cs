using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace _13._11
{
    internal class ResumeWindow : Window
    {
        public ResumeWindow(User user)
        {
            StackPanel stackPanel = new StackPanel();

            TextBlock nameText = new TextBlock
            {
                Text = "Имя: " + user.Name
            };
            stackPanel.Children.Add(nameText);

            TextBlock ageText = new TextBlock
            {
                Text = "Возраст: " + user.Age.ToString()
            };
            stackPanel.Children.Add(ageText);

            this.Content = stackPanel;
        }
    }
}
