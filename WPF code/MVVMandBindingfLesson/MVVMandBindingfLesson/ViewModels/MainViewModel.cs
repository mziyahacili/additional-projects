using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MVVMandBindingfLesson.Models;

namespace MVVMandBindingfLesson.ViewModels;
public class MainViewModel
{


    public Person PersonToAdd { get; set; } = new();
    public ObservableCollection<Person> People { get; set; } = new();

    public RelayCommand AddCommand 
    { get => new(
    () =>
    {
        People.Add(PersonToAdd);
    }); }

}