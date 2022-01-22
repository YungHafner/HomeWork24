using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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

namespace HomeWork24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        
        private Worker selectedWorkers;





        /*private void AddStudent(object sender, RoutedEventArgs e)
        {
            Workers.Add(new Worker
            {
                LastName = "Работник",
                TimeWorking = DateTime.Today
            });
        }

        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            if (SelectedWorkers == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранного студента?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Workers.Remove(SelectedWorkers);
                SelectedWorkers = null;
            }
        }

        public Worker SelectedWorkers
        {
            get => selectedWorkers;
            set
            {
                selectedWorkers = value;
                Signal();
            }
        }*/


        private ObservableCollection<Worker> Workers
        {
            get => Data.Workers;
            set => Data.Workers = value;
        }

       

       

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OpenDate(object sender, RoutedEventArgs e)
        {
            OpenDate win = new OpenDate();
            win.ShowDialog();
        }

        private void ForWorkers(object sender, RoutedEventArgs e)
        {
            ForWorkers wind = new ForWorkers();
            wind.ShowDialog();
        }


        private void TopWorkers(object sender, RoutedEventArgs e)
        {
            TopWorkers Top = new TopWorkers();
            Top.ShowDialog();
        }


       

    }
}
