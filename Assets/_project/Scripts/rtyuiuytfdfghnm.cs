using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core.UIElements;
using Random = UnityEngine.Random;

namespace _project.Scripts
{
    public sealed class rtyuiuytfdfghnm : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private rewgrehtrn settingsButton;
        [SerializeField] private kiujyhtgrfedw gameView;
        [SerializeField] private kiujyhtgrfedw winView;
        [SerializeField] private kiujyhtgrfedw loseView;
        [SerializeField] private TextMeshProUGUI levelText;
        [SerializeField] private TextMeshProUGUI timeText;
        [SerializeField] private rewgrehtrn mixButton;
        [SerializeField] private rewgrehtrn completeButton;
        [SerializeField] private TextMeshProUGUI tipText;
        [SerializeField] private List<klejerlgjer> tiles = new List<klejerlgjer>();
        [SerializeField] private List<Sprite> sprites = new List<Sprite>();
        [SerializeField] private TextMeshProUGUI winLevelText;
        [SerializeField] private Image[] winStars = new Image[3];
        [SerializeField] private rewgrehtrn retryButtonWin;
        [SerializeField] private rewgrehtrn retryButtonLose;
        [SerializeField] private rewgrehtrn nextButton;
        [SerializeField] private rewgrehtrn menuButton;

        private CancellationTokenSource _tokenCancellationTokenSource;
        private ewgwegwegewgw data1;

        private bool rtyuuyfghn;
        private bool rtyujhgv;

        public event Action rtyuhgfg
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }

        public event Action rtyujhgfvbnm
        {
            add => menuButton.wgwegwegweg += value;
            remove => menuButton.wgwegwegweg += value;
        }

        public event Action ertyuiuyfdfghjk
        {
            add => settingsButton.wgwegwegweg += value;
            remove => settingsButton.wgwegwegweg += value;
        }

        public event Action ertyuiufdfghm
        {
            add => nextButton.wgwegwegweg += value;
            remove => nextButton.wgwegwegweg += value;
        }

        public event Action kdfghjklkjhgfghjk
        {
            add => retryButtonWin.wgwegwegweg += value;
            remove => retryButtonWin.wgwegwegweg += value;
        }

        public event Action rtyuytfghjm
        {
            add => retryButtonLose.wgwegwegweg += value;
            remove => retryButtonLose.wgwegwegweg += value;
        }


        public event Action<ewgwegwegewgw> rghgfgnhgghn;


        private void Start()
        {
            mixButton.wgwegwegweg += () => rtyuuyfghn = true;
            completeButton.wgwegwegweg += () => rtyujhgv = true;
        }

        public async void rhjhgfghnhrgh(ewgwegwegewgw data)
        {
            data1 = data;
            _tokenCancellationTokenSource?.Cancel();
            _tokenCancellationTokenSource = new CancellationTokenSource();

            rtyuuyfghn = false;
            rtyujhgv = false;


            foreach (var hhghnhgghn in tiles)
            {
                hhghnhgghn.opkehrehprjo();
            }

            winView.qewregtrhnt();
            loseView.qewregtrhnt();
            gameView.wqeregtrhytng();

            mixButton.wqeregtrhytng();
            completeButton.qewregtrhnt();


            var tghgrgh = rtghjhgfdfghj();
            var ghjmjhgghjkjuyt = 0;
            foreach (var pair in tghgrgh)
            {
                var pos = pair.Value;
                var tile = tiles[ghjmjhgghjkjuyt++];
                tile.yjtyj45(new Vector2(-298, 116), new Vector2(198, -234), pair.Key);
                tile.jihehroiherjierhjio(pos.x, pos.y);
            }

            tipText.text = "Remember the order";
            timeText.text = "TIME 0:30";
            levelText.text = $"LEVEL {data.Id}";

            await UniTask.WaitUntil(() => rtyuuyfghn)
                .AttachExternalCancellation(_tokenCancellationTokenSource.Token)
                .SuppressCancellationThrow();
            rtyuuyfghn = false;
            Debug.Log("Mix");

            tipText.text = "Repeat the order";


            foreach (var rtyukjhgfd in tiles)
            {
                rtyukjhgfd.ehjlrerhljkrhjlek();
            }

            var rtyukjhg = rtghjhgfdfghj();
            var index2 = 0;
            foreach (var pair in rtyukjhg)
            {
                var pos = pair.Value;
                var tile = tiles[index2++];
                tile.jihehroiherjierhjio(pos.x, pos.y);
            }

            completeButton.wqeregtrhytng();
            mixButton.qewregtrhnt();


            var time = 30f;

            while (_tokenCancellationTokenSource.IsCancellationRequested == false)
            {
                await UniTask.Yield();

                time -= Time.deltaTime;
                timeText.text = $"TIME 0:{(int) time:00}";

                if (rtyujhgv)
                {
                    rtyujhgv = false;
                    break;
                }

                if (time <= 0)
                {
                    break;
                }
            }

            completeButton.qewregtrhnt();


            int tjhgfghjk = 8;

            foreach (var hjhgfghj in tghgrgh)
            {
                foreach (var hmnghnm in tiles)
                {
                    if (hmnghnm.ijoiherjphejrh.sprite == hjhgfghj.Key)
                    {
                        if (hmnghnm.egtrhytj != hjhgfghj.Value.x || hmnghnm.luyujtyjry != hjhgfghj.Value.y) tjhgfghjk--;
                    }
                }
            }

            var rtyhjhfghj = 0;
            switch (tjhgfghjk)
            {
                case 5:
                    rtyhjhfghj = 1;
                    break;

                case 6:
                case 7:
                    rtyhjhfghj = 2;
                    break;

                case 8:
                    rtyhjhfghj = 3;
                    break;

                default:
                    rtyhjhfghj = 0;
                    break;
            }

            winLevelText.text = $"Level {data.Id}";
            rthjhgfdfghnjm(rtyhjhfghj);
        }


        private void rthjhgfdfghnjm(int score)
        {
            if (score > 0)
            {
                if (_tokenCancellationTokenSource.IsCancellationRequested)
                    return;
                _tokenCancellationTokenSource.Cancel();

                for (int i = 0; i < 3; i++)
                {
                    winStars[i].color = i < score ? Color.white : Color.clear;
                }

                rghgfgnhgghn?.Invoke(data1);
                winView.wqeregtrhytng();
                gameView.qewregtrhnt();


                Debug.Log("Victory!");
                return;
            }

            if (_tokenCancellationTokenSource.IsCancellationRequested)
                return;
            _tokenCancellationTokenSource.Cancel();

            loseView.wqeregtrhytng();
            gameView.qewregtrhnt();

            Debug.Log("Game Over!");

            gameView.qewregtrhnt();
        }

        private Dictionary<Sprite, Vector2Int> rtghjhgfdfghj()
        {
            var rthjhgfghjnm = new Dictionary<Sprite, Vector2Int>();
            List<Vector2Int> rthjhgfdfghnm = new List<Vector2Int>();

            for (int x = 0; x <= 3; x++)
            for (int y = 0; y <= 1; y++)
                rthjhgfdfghnm.Add(new Vector2Int(x, y));

            ghmnhghhttyhj(rthjhgfdfghnm);

            for (int i = 0; i < sprites.Count; i++)
                rthjhgfghjnm[sprites[i]] = rthjhgfdfghnm[i];

            return rthjhgfghjnm;
        }

        private static void ghmnhghhttyhj(List<Vector2Int> rtghhtgh)
        {
            for (int i = rtghhtgh.Count - 1; i > 0; i--)
            {
                int rthjhgrtgh = Random.Range(0, i + 1);
                (rtghhtgh[i], rtghhtgh[rthjhgrtgh]) = (rtghhtgh[rthjhgrtgh], rtghhtgh[i]);
            }
        }

        public void tyhjhtrthj()
        {
            _tokenCancellationTokenSource?.Cancel();
        }
    }
}