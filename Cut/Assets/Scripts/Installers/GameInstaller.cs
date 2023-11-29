using Zenject;
using UnityEngine;
using System.Threading;

namespace Cut.Infrastracture
{
    public class GameInstaller : MonoInstaller
    {
        [Header("Scriptable objects")]
        [SerializeField] private CombosTemplatesSO _templates;
        [SerializeField] private ButtonsHolderSO _buttonsHolder;
        [SerializeField] private GameConfigSO _gameConfig;

        [Header("View")]
        [SerializeField] private ComboDisplay _comboDisplayer;

        public override void InstallBindings()
        {
            Container.Bind<CombosTemplatesSO>()
                .FromInstance( _templates )
                .AsSingle();

            Container.Bind<IRandomTemplateService>()
                .To<RandomTemplateService>()
                .AsSingle();

            Container.Bind<IListDisplayer>()
                .To<ListConsoleDisplayer>()
                .AsSingle();

            Container.Bind<IComboGenerator>()
                .To<ComboGenerator>()
                .AsSingle();

            Container.Bind<IButtonSideQualifier>()
                .To<ButtonSideQualifier>()
                .AsSingle();

            Container.Bind<ButtonsHolderSO>()
                .FromInstance( _buttonsHolder )
                .AsSingle();

            Container.Bind<IListRandomService>()
                .To<ListRandomService>()
                .AsSingle();

            Container.Bind<IListUniqueService>()
                .To<ListUniqueService>()
                .AsSingle();

            Container.Bind<IComboHolder>()
                .To<ComboHolder>()
                .AsSingle()
                .NonLazy();

            Container.Bind<IComboInspector>()
                .To<ComboInspector>()
                .AsSingle();

            Container.Bind<IComboSwitcher>()
                .To<ComboSwitcher>()
                .AsSingle();
            
            Container.Bind<IComboFinisher>()
                .To<ComboFinisherPrototype>()
                .AsSingle();

            Container.Bind<IComboDisplay>()
                .FromInstance(_comboDisplayer)
                .AsSingle();

            Container.Bind<GameStarter>()
                .To<GameStarter>()
                .AsSingle()
                .NonLazy();

            Container.Bind<SessionStatistics>()
                .To<SessionStatistics>()
                .AsSingle();

            Container.Bind<IComboBreaker>()
                .To<ComboBreakerPrototype>()
                .AsSingle();

            Container.Bind<GameConfigSO>()
                .FromInstance(_gameConfig)
                .AsSingle();

            Container.Bind<IFactory<IPrepTimer>>()
                .To<CustomPrepTimerFactory>()
                .AsSingle();

            Container.BindFactory<UnlimitedPrepTimer, UnlimitedPrepTimer.Factory>();
            Container.BindFactory<FirstTapPrepTimer, FirstTapPrepTimer.Factory>();

            Container.Bind<CancellationTokenSource>()
                .To<CancellationTokenSource>()
                .AsTransient();

            //Tests

            //Container.Bind<FirstTapPrepTimer>().To<FirstTapPrepTimer>().AsSingle().NonLazy();
            //Container.Bind<IComboGeneratorTest>().To<ComboGeneratorTest>().AsSingle().NonLazy();

        }
    }
}

