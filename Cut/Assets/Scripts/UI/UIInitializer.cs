using Zenject;

namespace Assets.Scripts.UI
{
    public class UIInitializer : IUIInitializer
    {
        private GameConfigSO _gameConfigSO;
        private GameMediator _gameMediator;
        [Inject]
        public UIInitializer(GameConfigSO gameConfigSO, GameMediator gameMediator) 
        {
            _gameConfigSO = gameConfigSO;
            _gameMediator = gameMediator;
        }

        public void InitializeUI()
        {
            switch (_gameConfigSO.StartMode)
            {
                case StartMode.GameSettingsWindow:
                    _gameMediator.SwitchToMetagameUI();
                    break;
                case StartMode.Gameplay:
                    _gameMediator.SwitchToGameplayUI();
                    break;
                default :
                    _gameMediator.SwitchToGameplayUI();
                    break;
            }
        }
    }
}
