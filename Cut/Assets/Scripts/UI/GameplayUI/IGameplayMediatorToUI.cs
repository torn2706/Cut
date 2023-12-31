﻿using System.Collections.Generic;

namespace UI.GameplayUI
{
    public interface IGameplayMediatorToUI
    {
        public void UpdateComboDisplay(List<string> updatedCombo, int lastFinishedNumber);
        public void UpdateBrokenCombosNumber(int statisticsNumber);
        public void UpdateFinishedCombosNumber(int statisticsNumber);
        public void DisplayTimer(float remainingTime, float fullTime);
        public void DisplayFullTimer();
    }
}