using OWML.ModHelper;
using OWML.Common;
using UnityEngine;

namespace VanillaMainMenu
{
    public class VanillaMainMenu : ModBehaviour
    {
        private void Update()
        {
            if (LoadManager.GetCurrentScene() != OWScene.TitleScreen) return;
            
            if (_EOTELogoSubtitle == null)
            {
               _EOTELogoSubtitle = GameObject.Find("TitleMenu/TitleCanvas/TitleLayoutGroup/Logo_EchoesOfTheEye");
                //ModHelper.Console.WriteLine($"Checking for logo...", MessageType.Info);
            }
            else if(_EOTELogoSubtitle.activeInHierarchy)
            {
                _EOTELogoSubtitle.SetActive(false);
                //ModHelper.Console.WriteLine($"Logo disabled!", MessageType.Success);
            }
        }

        private static GameObject _EOTELogoSubtitle;
    }
}
