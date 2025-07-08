using DG.Tweening;
using System.Collections;
using UnityEngine;

public class Miss : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        transform.DOLocalMoveY(1.9f, 0.3f);
        transform.DOLocalMoveY(1.5f, 0.3f).SetDelay(0.3f);
        StartCoroutine(LifeTime());
        
    }
    IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(0.6f);
        gameObject.SetActive(false);
    }
    public void  Rotation()
    {
        transform.localRotation = Quaternion.Euler(0, 180, 0);
    } public void  Rotation2()
    {
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
 
}
