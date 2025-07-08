using System.Collections;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public AudioSource audioma;


    public Stage stage;
    public Shop shop;
    public int defenseCard;
    public TextMeshProUGUI tmp;
    public TextMeshProUGUI NO;
    public TextMeshProUGUI NoMoney;
    public TextMeshProUGUI cost;
    public TextMeshProUGUI upgradePercent;
    public ChangeWeapon changeWeapon;

    public int Money{ get;private  set; }
    public TextMeshProUGUI currentMoney;
    private UpgradePercent ug;
    public TextMeshProUGUI defenseCardCount;
    public static MoneyManager Instance;
    bool canUP = true;
    private void Awake()
    {
        NoMoney.gameObject.SetActive(false);
        audioma = GetComponent<AudioSource>();
        ug = GetComponent<UpgradePercent>();
        // �̱��� �ν��Ͻ� ����
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // �ߺ��� �ν��Ͻ� ����
            return;
        }

        Instance = this;
    }
    private void Start()
    {
        defenseCard = MoneyManage.Instance.Defense;
        Money = MoneyManage.Instance.Money;
        currentMoney.text = "�� : " + Money;
        defenseCardCount.text = "������ : " + defenseCard;
    }

    public void GetMoney(int amount)
    {
        int x = amount + Money;
        Money = x;
        currentMoney.text = "�� : " + x.ToString()+"��";
    }
    public void CheckMoney(int amount)
    {
        if (amount > Money)
        {
            if (canUP) 
            {
                StartCoroutine(Courtine());

            }
            ug.upgradeSu = false;
        }
        else
        {
            
            ug.upgradeSu = true;

        }

    }
    IEnumerator Courtine()
    {
        NoMoney.gameObject.SetActive(true);
        canUP = false;
         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.CantBuy);  
        yield return new WaitForSeconds(1.5f);
        canUP = true;
        NoMoney.gameObject.SetActive(false);
    }
    public void UseMoney(int amount)
    {

        ug.upgradeSu = true;
        int x = Money - amount;
        Money = x;
        currentMoney.text = "�� : " + x.ToString()+"��";


    }
    IEnumerator MonsterLeftFadeOutCo()   //���̵�ƿ�
    {
        NO.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        NO.gameObject.SetActive(false);

    }
    public void UseDefense(int amount)
    {
        int y = defenseCard;
        int x = defenseCard - amount;
        if (x < 0)
        {
             AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.CantBuy);

            //audioma.PlayOneShot(AudioManager.Instance.use);
            StartCoroutine(MonsterLeftFadeOutCo());
            ug.upgradeLevel = 2;
            defenseCard = y;
            shop.On();
          
            defenseCardCount.text = "������ : " + defenseCard;
            upgradePercent.text = $"{100}%";
            tmp.text = "+1 ���� ������ ����   ";
            cost.text = "��� : " + 1000;
            changeWeapon.sRender.sprite = changeWeapon.sprite[0];
        }
        else
        {
             AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.use);

            defenseCard = x;
            defenseCardCount.text = "������ : " + x.ToString();
        }
    }
    public void GetDefense(int amount)
    {
        int x = amount + defenseCard;
        defenseCard = x;
        defenseCardCount.text = "������ : " + x.ToString();
    }
}


