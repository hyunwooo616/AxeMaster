using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Esc : MonoBehaviour
{
    public AudioClip audioClip;
    public Image fadeImage;

    public static Esc Instance;
    private void Awake()
    {
        fadeImage.gameObject.SetActive(false);
    }
    void Update()
    {
        if(Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            
            fadeImage.gameObject.SetActive(!fadeImage.gameObject.activeSelf);
        }
    }
    public void ButtonPress()
    {
       StartCoroutine(EscStart());
       
    }
    IEnumerator EscStart()
    {
        AudioManager.Instance.audioSource.PlayOneShot(audioClip);
        yield return new WaitForSeconds(0.5f);
        Debug.Log("out");   
        Application.Quit();
    }
}
