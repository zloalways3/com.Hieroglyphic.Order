using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace _project.Scripts
{
    public class klejerlgjer : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public int egtrhytj { get; set; }
        public int luyujtyjry { get; set; }
        public RectTransform gerherherh { get; private set; }
        public Image ijoiherjphejrh { get; private set; }
        private Vector2 hrherjrrirur;
        private Vector2 heher464;
        private Vector2 trykjrj65;
        private bool hrthrtjr7 = false;
        private float greheh6 = 20f; // Минимальное расстояние для засчитывания свайпа
        private bool jtrjrtjtr = true;

        private void Awake()
        {
            gerherherh = GetComponent<RectTransform>();
            ijoiherjphejrh = GetComponent<Image>();
        }

        public void yjtyj45(Vector2 startPos, Vector2 offsets, Sprite sprite)
        {
            this.hrherjrrirur = startPos;
            this.heher464 = offsets;
            ijoiherjphejrh.sprite = sprite;
        }

        public void opkehrehprjo() => this.jtrjrtjtr = true;
        public void ehjlrerhljkrhjlek() => this.jtrjrtjtr = false;

        public void jihehroiherjierhjio(int x, int y, bool skipAnchored = false)
        {
            egtrhytj = x;
            luyujtyjry = y;
            if (skipAnchored == false)
                gerherherh.anchoredPosition = hrherjrrirur + heher464 * new Vector2(x, y);
        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            if(jtrjrtjtr) return;
            
            hrthrtjr7 = true;
            trykjrj65 = eventData.position;
        }

        public void OnDrag(PointerEventData eventData)
        {
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if(jtrjrtjtr) return;
            
            if (!hrthrtjr7) return;

            hrthrtjr7 = false;
            Vector2 herherherh = eventData.position - trykjrj65;

            if (herherherh.magnitude < greheh6) return;

            // Определяем направление свайпа
            Vector2 yuuytrer = herherherh.normalized;
            Vector2Int erghnbv = Vector2Int.zero;

            if (Mathf.Abs(yuuytrer.x) > Mathf.Abs(yuuytrer.y))
            {
                erghnbv = new Vector2Int(yuuytrer.x > 0 ? 1 : -1, 0);
            }
            else
            {
                erghnbv = new Vector2Int(0, yuuytrer.y < 0 ? 1 : -1);
            }

            // Проверяем и обмениваемся с соседним тайлом
            klejerlgjer neighborKlejerlgjer = FindNeighborTile(erghnbv);
            if (neighborKlejerlgjer != null)
            {
                tyujknbv(neighborKlejerlgjer);
            }
        }

        private klejerlgjer FindNeighborTile(Vector2Int direction)
        {
            Vector2Int rtyujnb = new Vector2Int(egtrhytj + direction.x, luyujtyjry + direction.y);
            foreach (klejerlgjer rtyukjhbv in FindObjectsOfType<klejerlgjer>())
            {
                if (rtyukjhbv.egtrhytj == rtyujnb.x && rtyukjhbv.luyujtyjry == rtyujnb.y)
                {
                    return rtyukjhbv;
                }
            }

            return null;
        }

        private void tyujknbv(klejerlgjer other)
        {
            int rthjhbv = egtrhytj, tempY = luyujtyjry;
            jihehroiherjierhjio(other.egtrhytj, other.luyujtyjry, true);
            other.jihehroiherjierhjio(rthjhbv, tempY, true);

            StartCoroutine(tyujhgfcfghnm(this, new Vector2(egtrhytj, luyujtyjry)));
            StartCoroutine(tyujhgfcfghnm(other, new Vector2(other.egtrhytj, other.luyujtyjry)));
        }

        private IEnumerator tyujhgfcfghnm(klejerlgjer klejerlgjer, Vector2 targetPos)
        {
            float tyukjhgfdcvb = 0;
            Vector2 tyukjhg = klejerlgjer.gerherherh.anchoredPosition;
            var rtyujhgfcvbh = hrherjrrirur + heher464 * targetPos;
            while (tyukjhgfdcvb < 0.2f)
            {
                klejerlgjer.gerherherh.anchoredPosition = Vector2.Lerp(tyukjhg, rtyujhgfcvbh, tyukjhgfdcvb / 0.2f);
                tyukjhgfdcvb += Time.deltaTime;
                yield return null;
            }

            klejerlgjer.gerherherh.anchoredPosition = rtyujhgfcvbh;
        }
    }
}