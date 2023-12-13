﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppGraphic.ViewModels;

namespace WpfAppGraphic.ViewModels;

public partial class DisplayMainOptionsViewModel : ObservableObject
{
private readonly IServiceProvider _sp;

public DisplayMainOptionsViewModel(IServiceProvider sp)
{
    _sp = sp;
}

[RelayCommand]
private void NavigateToAdd()
{
    var mainViewModel = _sp.GetRequiredService<MainViewModel>();
    mainViewModel.CurrentViewModel = _sp.GetRequiredService<DisplayAddViewModel>();
}
}