using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnStage : MonoBehaviour
{
    public bool canChange = true;
    public UnityEngine.UI.Image fadeImage;
    private void Start()
    {
        canChange = true;
      StartCoroutine(Fade(1, 0));
    }
    private IEnumerator Fade(float start, float end)
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
            Color color = fadeImage.color;
            color.a = Mathf.Lerp(start, end, percent);
            fadeImage.color = color;

            yield return null;
        }
    }
    public void ReTurn()
    {
        if (canChange)
        {
            StartCoroutine(Fade(0, 1));
            StartCoroutine(Courtine3());
        }
    }
    IEnumerator Courtine3()
    {
        canChange = false;
        yield return new WaitForSeconds(1);
        canChange = true;
   
        SceneManager.LoadScene("Main");

    }
}
