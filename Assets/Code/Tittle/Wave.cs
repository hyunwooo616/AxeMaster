using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wave : MonoBehaviour
{
    public RectTransform targetUI;

    void Start()
    {
       StartCoroutine(go());
    }
    IEnumerator go()
    {
        targetUI.DOLocalMove(new Vector3(-53, 269, 0), 0.1f);
        targetUI.DOLocalMove(new Vector3(-65, 281, 0), 0.1f).SetDelay(0.1f);
        targetUI.DOLocalMove(new Vector3(-7, 292, 0), 0.1f).SetDelay(0.2f);
        targetUI.DOLocalMove(new Vector3(-7, 292, 0), 0.1f).SetDelay(0.3f);
        targetUI.DOLocalMove(new Vector3(-65, 250, 0), 0.1f).SetDelay(0.4f);
        targetUI.DOLocalMove(new Vector3(-65, 354, 0), 0.1f).SetDelay(0.5f);
        targetUI.DOLocalMove(new Vector3(-27, 339, 0), 0.1f).SetDelay(0.6f);
        targetUI.DOLocalMove(new Vector3(-46, 293, 0), 0.1f).SetDelay(0.7f);
        targetUI.DOLocalMove(new Vector3(-46, 293, 0), 0.1f).SetDelay(0.8f);
        targetUI.DOLocalMove(new Vector3(-92, 293, 0), 0.1f).SetDelay(0.9f);

        yield return new WaitForSeconds(1f);
        StartCoroutine(go());
    }
    public void OnbuttonPressed()
    {
        SceneManager.LoadScene("Main");
    }
}
