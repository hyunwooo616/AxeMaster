using DG.Tweening;
using System.Collections;
using UnityEngine;

public class Tittle : MonoBehaviour
{
    public RectTransform targetUI;
    public AudioClip soundEffect; // 사운드 효과
    public GameObject gameobject;
    void Start()
    {
        StartCoroutine(go());
        targetUI.DOLocalMoveX(0, 0.15f).SetDelay(0.7f);
    }
    IEnumerator go()
    {
        yield return new WaitForSeconds(1.47f);
        gameobject.SetActive(true);
    }
}
