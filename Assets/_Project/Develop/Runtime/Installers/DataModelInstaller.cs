using UnityEngine;
using Zenject;
using _Project.Develop.Runtime.Models;

namespace _Project.Develop.Runtime.Installers
{
    public class DataModelInstaller : MonoInstaller
    {
        [SerializeField] private LevelUpDataMok _levelUpDataMok;
        public override void InstallBindings()
        {
            InstallDataModel();
        }

        private void InstallDataModel()
        {
            Container
                .Bind<LevelUpModel>()
                .AsSingle()
                .WithArguments(_levelUpDataMok);
        }
    }
}
