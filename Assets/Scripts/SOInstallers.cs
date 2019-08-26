using UnityEngine;
using Zenject;

namespace MG.ZENJECT
{
[CreateAssetMenu(fileName = "SOInstallers",menuName = "Create SO Installers")]
    public class SOInstallers : ScriptableObjectInstaller
    {
        [SerializeField] private GameConfig gameConfig;

        //[SerializeField]
        //private GameObject block;
        public override void InstallBindings()
        {
            Container.BindInstance(gameConfig);
            // Container.BindInstance(block);
        }
    }
}