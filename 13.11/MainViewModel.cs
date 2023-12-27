using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _13._11
{
    internal class MainViewModel
    {
        public ICommand AddCommand { get; }
        public ICommand ClearCommand { get; }
        public ICommand ViewCommand { get; }

        public User User { get; } // Add properties for Name, Age, etc.
        public ObservableCollection<User> Users { get; }
        public User SelectedUser { get; set; }

        public MainViewModel()
        {
            AddCommand = new RelayCommand(AddUser);
            ClearCommand = new RelayCommand(ClearForm);
            ViewCommand = new RelayCommand(ViewResume);
            User = new User();
            Users = new ObservableCollection<User>();
        }

        private void AddUser()
        {
            User newUser = new User()
            {
                Name = User.Name,
                Age = User.Age,
            };
            Users.Add(newUser);
            using (StreamWriter writer = new StreamWriter("users.txt", true))
            {
                writer.WriteLine($"{newUser.Name},{newUser.Age}");
            }
        }

            private void ClearForm()
        {
            User.Name = string.Empty;
            User.Age = 0;
        }

        private void ViewResume()
        {
            ResumeWindow resumeWindow = new ResumeWindow(SelectedUser);
            resumeWindow.Show();
        }
    }
}
