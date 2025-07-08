using DG.Tweening;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class SlideBar : MonoBehaviour
{
    public GameObject player;
    public bool Succes;
    private Tween moveTween;
    private void Awake()
    {
        player.SetActive(false);
    }
    private void OnEnable()
    {
    
        if (moveTween != null && moveTween.IsActive())
        {
            moveTween.Kill();
        }

        transform.localPosition = new Vector3(0, -0.5f, 0);

        moveTween = transform.DOLocalMoveY(0.37f, 0.67f)
       .SetEase(Ease.Linear)
       .SetLoops(-1, LoopType.Yoyo);

    }
    private void OnDisable()
    {
        if (moveTween != null && moveTween.IsActive())
        {
            moveTween.Kill();
        }


    }
    IEnumerator SuccesTimming()
    {
            Succes = true;
            yield return new WaitForSeconds(0.16f);
           Succes = false;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       StartCoroutine(SuccesTimming());
        
    }
   
}
