using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI currentMoney;
    public TextMeshProUGUI current;

    private void Update()
    {
        currentMoney.text = "�� : " + MoneyManage.Instance.Money.ToString();
    }

}
