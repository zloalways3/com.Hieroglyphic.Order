using System;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class wgwegwgwegweg : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private Toggle music;
        [SerializeField] private Toggle sound;

        public event Action OnExitButton
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }

        protected override void qewretgryht()
        {
            {
                var v = PlayerPrefs.GetFloat("Music", 1);

                music.SetIsOnWithoutNotify(v > 0.5f);
            }

            {
                var v = PlayerPrefs.GetFloat("Effects", 1);
                sound.SetIsOnWithoutNotify(v > 0.5f);
            }

            music.onValueChanged.AddListener(v => wgewgwgwegwegwe.ewregtrh.SetGameMusicVolumeSync(v ? 1 : 0));
            sound.onValueChanged.AddListener(v => { wgewgwgwegwegwe.ewregtrh.SetGameEffectsVolumeSync(v ? 1 : 0); });
        }


        protected override void ewregtrhnht()
        {
            qewrfegtrfhng.ewregtrh.ewregthrnhg<BackgroundScreen>().rthjhgfghn();
        }
    }
}