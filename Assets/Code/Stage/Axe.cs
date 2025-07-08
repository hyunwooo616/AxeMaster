using UnityEngine;
using UnityEngine.InputSystem;
using DG.Tweening;
public class Axe : MonoBehaviour
{
    public Sprite[] sprite;
    public SpriteRenderer sRender;
    public SpriteRenderer sRender2;
    private void Awake()
    {
        gameObject.SetActive(false);
        sRender.sprite = sprite[WeaponManage.Instance.currentWeapom-2];
        sRender2.sprite = sprite[WeaponManage.Instance.currentWeapom - 2];
    }

    public void ChopAxe()
    {
        transform.DOLocalRotate(new Vector3(0, 0, -65), 0.2f).SetEase(Ease.InBack);
        transform.DOLocalRotate(new Vector3(0, 0, 10.5f), 0.3f).SetDelay(0.2f);

    }
}
