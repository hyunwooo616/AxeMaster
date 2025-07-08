using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENding : MonoBehaviour
{
    public UnityEngine.UI.Image fadeImage;
    private bool canChange = true;

    private IEnumerator Fade(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            // fadeTime���� ����� fadeTime �ð� ����
            // percent ���� 0���� 1�� �����ϵ��� ��
            currentTime += Time.deltaTime;
            percent = currentTime / 1;

            // ���İ��� start���� end���� fadeTime �ð� ���� ��ȭ��Ų��
            Color color = fadeImage.color;
            color.a = Mathf.Lerp(start, end, percent);
            fadeImage.color = color;

            yield return null;
        }
    }
    public void OnbuttonClick()
    {
        if (canChange)
        {
            
          StartCoroutine(Fade(0, 1));
            StartCoroutine(Courtine());
        }


    }
        IEnumerator Courtine()
    {
        canChange = false;
        yield return new WaitForSeconds(1);
        canChange = true;
        SceneManager.LoadScene("Ending");

    }
}
