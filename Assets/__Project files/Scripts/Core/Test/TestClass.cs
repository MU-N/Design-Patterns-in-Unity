using DG.Tweening;
using System.Collections;
using UnityEngine;

namespace Nasser.io.DesignPatterns
{
    public class TestClass : MonoBehaviour
    {
        [SerializeField] Transform red;
        [SerializeField]  Transform green;
        [SerializeField]  Transform blue;
        [SerializeField]  Transform yellow;

        WaitForSeconds wiat1Second = new WaitForSeconds(1f);

        private void Start()
        {
            red.DOScale(new Vector3(3, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            green.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            blue.DOScale(new Vector3(1, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            yellow.DOScale(new Vector3(3, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1).OnComplete(() =>
            {
                StartCoroutine(nameof(ScaleUpGreen));

            });
        }
        IEnumerator ScaleUpGreen()
        {

            yield return wiat1Second;
            red.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            green.DOScale(new Vector3(3, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            blue.DOScale(new Vector3(3, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            yellow.DOScale(new Vector3(1, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1).OnComplete(() =>
            {
                StartCoroutine(nameof(ScaleUpYellow));

            });
        }

        IEnumerator ScaleUpYellow()
        {

            yield return wiat1Second;
            red.DOScale(new Vector3(3, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            green.DOScale(new Vector3(1, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            blue.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            yellow.DOScale(new Vector3(3, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1).OnComplete(() =>
            {
                StartCoroutine(nameof(ScaleUpBlue));

            });
        }

        IEnumerator ScaleUpBlue()
        {

            yield return wiat1Second;
            red.DOScale(new Vector3(1, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            green.DOScale(new Vector3(3, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            blue.DOScale(new Vector3(3, 3, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
            yellow.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.InOutSine).SetLoops(1);
        }
    }
}
