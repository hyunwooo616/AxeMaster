using UnityEngine;

public class WeaponManage : MonoBehaviour
{
    public int currentWeapom = 2;
    public static WeaponManage Instance { get; private set; }


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
    
    public void SetWeapon()
    {

        currentWeapom = ChangeWeapon.Instance.ul;
        if(currentWeapom == 30)
        {
            currentWeapom = 2;
        }
    }

}
