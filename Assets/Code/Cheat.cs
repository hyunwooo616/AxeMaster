using UnityEngine;
using UnityEngine.InputSystem;

public class Cheat : MonoBehaviour
{
    private void Update()
    {
        if(Keyboard.current.pKey.isPressed)
        {
            MoneyManager.Instance.GetMoney(100000);
            MoneyManager.Instance.GetDefense(2);
        }
    }
}
