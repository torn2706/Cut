﻿using System;
using System.Collections.Generic;

namespace ComboSwitchingFeature
{
    public interface IComboInspector
    {
        public bool IsComboWrong(List<int> currentCombo);
        public bool IsComboFinished(List<int> currentCombo);
        public bool IsExpectedComboAvailable();
        public void SetExpectedCombo(List<int> newCombo);
    }
}