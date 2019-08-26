using Zenject;

namespace MG.ZENJECT
{
    public class SceneInstall : MonoInstaller
    {
       [Inject] private GameConfig gameConfig;
        public override void InstallBindings()
        {
         

        }
    }
}
