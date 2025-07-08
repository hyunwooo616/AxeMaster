using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SM : MonoBehaviour
{
    public FadeEffect fadeEffect;
    public AudioSource audioSource;
    public void ButtonPress()
    {
        audioSource.Play();
        fadeEffect.StartCoroutine(fadeEffect.Fade(0, 1));
        StartCoroutine(Courtine());
    }
    IEnumerator Courtine()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Main");
    }
}
