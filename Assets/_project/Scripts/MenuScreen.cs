using System;
using UnityEngine;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core;
using ZeroSDK.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class MenuScreen : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn policyButton;
        [SerializeField] private rewgrehtrn playButton;
        [SerializeField] private rewgrehtrn optionsButton;
        [SerializeField] private rewgrehtrn exitButton;
        
        public event Action OnPlayButtonEvent
        {
            add => playButton.wgwegwegweg += value;
            remove => playButton.wgwegwegweg += value;
        }
        
        public event Action OnOptionsButtonEvent
        {
            add => optionsButton.wgwegwegweg += value;
            remove => optionsButton.wgwegwegweg += value;
        }
        
        public event Action OnExitButtonEvent
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }
        
        public event Action OnPolicyButtonEvent
        {
            add => policyButton.wgwegwegweg += value;
            remove => policyButton.wgwegwegweg += value;
        }


        protected override void ewregtrhnht() => qewrfegtrfhng.ewregtrh.ewregthrnhg<BackgroundScreen>().rthjhgfghn();
    }
}