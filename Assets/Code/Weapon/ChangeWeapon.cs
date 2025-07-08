using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{

    public UpgradePercent upgradePercent;
    public GameObject axe;
   public  SpriteRenderer sRender;
    public Sprite[] sprite;
    public int ul;
    public static ChangeWeapon Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // 중복된 인스턴스 제거
            return;
        }
        Instance = this;

        sRender = axe.GetComponent<SpriteRenderer>();
    }
    public void DDD(int a)
    {
        upgradePercent.Up(a);

    }
   

    private void Update()
    {
        ul = upgradePercent.upgradeLevel;
        if (ul == 30)
        {
            sRender.sprite = sprite[25];
        }
        else
        {
            sRender.sprite = sprite[ul - 2];
        }
        
    }
}
