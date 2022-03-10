﻿using HunterPie.Core.Architecture;
using HunterPie.UI.Overlay.Widgets.Activities.Domain;
using System.Collections.ObjectModel;

namespace HunterPie.UI.Overlay.Widgets.Activities.ViewModel
{
    public class SubmarinesViewModel : Bindable, IActivity
    {
        public ObservableCollection<SubmarineViewModel> Submarines { get; } = new();

        public ActivityType Type => ActivityType.Submarine;
    }
}