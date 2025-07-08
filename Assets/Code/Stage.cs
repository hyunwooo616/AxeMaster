using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour
{
    public ButtonPre buttonPre;
    public AudioSource audioSource;
    public AudioClip click;
    public UnityEngine.UI.Image fadeImage;
    public UnityEngine.UI.Image stage;
    public UnityEngine.UI.Image shop;
    public UnityEngine.UI.Button button;
    bool canFade;
   public bool canChange = true;
    private void Start()
    {
      
        canChange = true;
       
        stage.gameObject.SetActive(false);
        StartCoroutine(Fade(1, 0));

    }
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
  
    public void ButtonPressed()
    {

        AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.click);
        shop.gameObject.SetActive(false);

        stage.gameObject.SetActive(!stage.gameObject.activeSelf);
    }
    public void Stage1()
    {

        if (canChange)
        {
            WeaponManage.Instance.SetWeapon();
            MoneyManage.Instance.SceneChange();
            AudioManager.Instance.ButtonPress();
            StartCoroutine(Fade(0, 1));
            StartCoroutine(Courtine2());
        }
        

    }
    public void Stage2()
    {
        if (canChange)
        {
            WeaponManage.Instance.SetWeapon();
            MoneyManage.Instance.SceneChange();
            AudioManager.Instance.ButtonPress();
            StartCoroutine(Fade(0, 1));
            StartCoroutine(Courtine());
        }

    }
    IEnumerator Courtine()
    {
        canChange = false;
        yield return new WaitForSeconds(1);
        canChange = true;
        SceneManager.LoadScene("Stage2");
    }
    IEnumerator Courtine2()
    {
        canChange = false;
        yield return new WaitForSeconds(1);
        canChange = true;
        SceneManager.LoadScene("Stage1");
    }
   

    }
