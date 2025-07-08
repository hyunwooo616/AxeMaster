using System;
using System.Collections;
using UnityEngine;

public class FadeEffect : MonoBehaviour
{
    public UnityEngine.UI.Image image;
    private void Start()
    {
        StartCoroutine(Fade(1, 0));
    }
    public IEnumerator Fade(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            // fadeTime으로 나누어서 fadeTime 시간 동안
            // percent 값이 0에서 1로 증가하도록 함
            currentTime += Time.deltaTime;
            percent = currentTime / 1;

            // 알파값을 start부터 end까지 fadeTime 시간 동안 변화시킨다
            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);
            image.color = color;

            yield return null;
        }
    }


}
