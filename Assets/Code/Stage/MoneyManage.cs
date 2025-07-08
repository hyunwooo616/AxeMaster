using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class MoneyManage : MonoBehaviour
{
    
    public static MoneyManage Instance;
    public int Money;
    public int Defense;
    public void SceneChange()
    {
        Money = MoneyManager.Instance.Money;
        Defense = MoneyManager.Instance.defenseCard;
    }


    private void Awake()
    {
    
        
     
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        

    }

}
