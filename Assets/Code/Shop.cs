
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public UnityEngine.UI.Image stage;

   
    public AudioSource clickSource;
    public AudioSource cant;
    public DefensePrice defensePrice;
    public UnityEngine.UI.Image shop; 
    public UnityEngine.UI.Button button;
    public UpgradePercent up;
    private void Start()
    {
        shop.gameObject.SetActive(false);
        if(up.upgradeLevel ==2 )
        {
            button.gameObject.SetActive(true);
        }
        else
        {
            button.gameObject.SetActive(false);
        }
    }
    public void ButtonPressed()
    {
        AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.click);
        shop.gameObject.SetActive(!shop.gameObject.activeSelf);
        stage.gameObject.SetActive(false);
    }
    public void Buy1()
    {
        if(MoneyManager.Instance.Money < defensePrice.OnePrice)
        {
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.CantBuy);

        }
        else {
            MoneyManager.Instance.GetDefense(1);

             AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Buy);

            MoneyManager.Instance.UseMoney(defensePrice.OnePrice);
        }

    }
    public void Buy2()
    {
        if (MoneyManager.Instance.Money < defensePrice.FivePrice)
        {
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.CantBuy);


        }
        else
        {
            MoneyManager.Instance.GetDefense(5);

            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Buy);

            MoneyManager.Instance.UseMoney(defensePrice.FivePrice);
        }

    }
    public void Buy3()
    {
        if (MoneyManager.Instance.Money < defensePrice.TenPrice)
        {

            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.CantBuy);

        }
        else
        {
            MoneyManager.Instance.GetDefense(10);
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Buy);


            MoneyManager.Instance.UseMoney(defensePrice.TenPrice);
        }

    }
    public void Buy4()
    {
        if (MoneyManager.Instance.Money < defensePrice.FifteenPrice)
        {
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.CantBuy);


        }
        else
        {
            MoneyManager.Instance.GetDefense(15);
            
            AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Buy);

            MoneyManager.Instance.UseMoney(defensePrice.FifteenPrice);
        }

    }
    public void On()
    {
        button.gameObject.SetActive(true);

    }
    public void Off()
    {
        button.gameObject.SetActive(false);

    }
}
