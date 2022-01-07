using OWML.ModHelper;
using OWML.Common;
using UnityEngine;

namespace RemoveDLCSubtitle
{
    public class RemoveDLCSubtitle : ModBehaviour
    {
        private void Awake()
        {
            
        }

        private void Start()
        {
            ModHelper.Console.WriteLine($"My mod {nameof(RemoveDLCSubtitle)} is loaded!", MessageType.Success);
            
            LoadManager.OnCompleteSceneLoad += (scene, loadScene) =>
            {
                //I will be amazed if this just works
                if (loadScene != OWScene.TitleScreen) return;
                GameObject.Find("TitleMenu/TitleCanvas/TitleLayoutGroup/Logo_EchoesOfTheEye").SetActive(false);
            };
        }
    }
}
