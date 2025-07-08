using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UpgradePercent : MonoBehaviour
{
    public AudioSource ff;
    public Shop shop;
    public UnityEngine.UI.Image stage;
    public UnityEngine.UI.Image Shop;
    public TextMeshProUGUI NeedDefense;
    public TextMeshProUGUI NeedDe;
    public TextMeshProUGUI NO;
    public MoneyManager moneyManager;
    public UnityEngine.UI.Button defenseButton;
    public UnityEngine.UI.Button ending;
    public TextMeshProUGUI FailComment;
    public TextMeshProUGUI tmp;
    public TextMeshProUGUI cost;
    public DefenseSO ds;
    public WeaponLvSO Per;
    public NeedMoneySO so;
    public WeaponNameSO namef;
    public int upgradeLevel ;
    public int UpgradeLevel ;
    public TextMeshProUGUI upgradePercent;
    public int randomnumber;
    public bool upgradeSu = true;
    public bool CanUpgrade;
    public bool Defense = false;
    public int currentLevel =2 ;
    public UnityEngine.UI.Button defenseButton2;
    public void Up(int a)
    {
        UpgradeLevel = a;
        
    }
    private void Awake()
    {
        ending.gameObject.SetActive(false);
        ff = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var pointer = new PointerEventData(EventSystem.current);
            ExecuteEvents.Execute(defenseButton.gameObject, pointer, ExecuteEvents.pointerDownHandler);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
                var pointer = new PointerEventData(EventSystem.current);
                ExecuteEvents.Execute(defenseButton.gameObject, pointer, ExecuteEvents.pointerUpHandler);
            
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            if (!Shop.gameObject.activeSelf&& !stage.gameObject.activeSelf)
            {
               
                randomnumber = UnityEngine.Random.Range(1, 101);
                per();
            }
        }
  
     
    }
    private void Start()
    {
        upgradeLevel = WeaponManage.Instance.currentWeapom;


        defenseButton.gameObject.SetActive(false);
        FailComment.gameObject.SetActive(false);
        NeedDefense.gameObject.SetActive(false);
        NO.gameObject.SetActive(false);
        switch (upgradeLevel)
        {
            case 2:
                upgradePercent.text = $"{Per.level2Per}%";
                tmp.text = $"+1 {namef.weaponName1}";
                cost.text = "비용 : " + so.needMoney2;
                NeedDe.text = "복구 비용 : " + ds.needDefense1;
                break;
            case 3:
                upgradePercent.text = $"{Per.level3Per}%";
                tmp.text = $"+2 {namef.weaponName2}";
                cost.text = "비용 : " + so.needMoney3;
                NeedDe.text = "복구 비용 : " + ds.needDefense2;
                break;
            case 4:
                upgradePercent.text = $"{Per.level4Per}%";
                tmp.text = $"+3 {namef.weaponName2}";
                cost.text = "비용 : " + so.needMoney4;
                NeedDe.text = "복구 비용 : " + ds.needDefense3;

                break;
            case 5:
                upgradePercent.text = $"{Per.level5Per}%";
                tmp.text = $"+4 {namef.weaponName4}";
                cost.text = "비용 : " + so.needMoney5;
                NeedDe.text = "복구 비용 : " + ds.needDefense4;

                break;
            case 6:
                upgradePercent.text = $"{Per.level6Per}%";
                tmp.text = $"+5 {namef.weaponName5}";
                cost.text = "비용 : " + so.needMoney6;
                NeedDe.text = "복구 비용 : " + ds.needDefense5;

                break;
            case 7:
                upgradePercent.text = $"{Per.level7Per}%";
                tmp.text = $"+6 {namef.weaponName6}";
                cost.text = "비용 : " + so.needMoney7;
                NeedDe.text = "복구 비용 : " + ds.needDefense6;
                break;
            case 8:
                upgradePercent.text = $"{Per.level8Per}%";
                tmp.text = $"+7 {namef.weaponName7}";
                cost.text = "비용 : " + so.needMoney8;
                NeedDe.text = "복구 비용 : " + ds.needDefense7;
                break;
            case 9:
                upgradePercent.text = $"{Per.level9Per}%";
                tmp.text = $"+8 {namef.weaponName8}";
                cost.text = "비용 : " + so.needMoney9;
                NeedDe.text = "복구 비용 : " + ds.needDefense8;
                break;
            case 10:
                upgradePercent.text = $"{Per.level10Per}%";
                tmp.text = $"+9 {namef.weaponName9}";
                cost.text = "비용 : " + so.needMoney10;
                NeedDe.text = "복구 비용 : " + ds.needDefense9;
                break;
            case 11:
                upgradePercent.text = $"{Per.level11Per}%";
                tmp.text = $"+10 {namef.weaponName10}";
                cost.text = "비용 : " + so.needMoney11;
                NeedDe.text = "복구 비용 : " + ds.needDefense10;
                break;
            case 12:
                upgradePercent.text = $"{Per.level12Per}%";
                tmp.text = $"+11 {namef.weaponName11}";

                cost.text = "비용 : " + so.needMoney12;
                NeedDe.text = "복구 비용 : " + ds.needDefense11;
                break;
            case 13:
                upgradePercent.text = $"{Per.level13Per}%";
                tmp.text = $"+12 {namef.weaponName12}";

                cost.text = "비용 : " + so.needMoney13;
                NeedDe.text = "복구 비용 : " + ds.needDefense12;
                break;
            case 14:
                upgradePercent.text = $"{Per.level14Per}%";
                tmp.text = $"+13 {namef.weaponName13}";

                NeedDe.text = "복구 비용 : " + ds.needDefense13;
                cost.text = "비용 : " + so.needMoney14;
                break;
            case 15:
                upgradePercent.text = $"{Per.level15Per}%";
                tmp.text = $"+14 {namef.weaponName14}";

                NeedDe.text = "복구 비용 : " + ds.needDefense14;
                cost.text = "비용 : " + so.needMoney15;
                break;
            case 16:
                upgradePercent.text = $"{Per.level16Per}%";
                tmp.text = $"+15 {namef.weaponName15}";

                NeedDe.text = "복구 비용 : " + ds.needDefense15;
                cost.text = "비용 : " + so.needMoney16;
                break;
            case 17:
                upgradePercent.text = $"{Per.level17Per}%";
                tmp.text = $"+16 {namef.weaponName16}";

                NeedDe.text = "복구 비용 : " + ds.needDefense16;
                cost.text = "비용 : " + so.needMoney17;
                break;
            case 18:
                upgradePercent.text = $"{Per.level18Per}%";
                tmp.text = $"+17 {namef.weaponName17}";

                NeedDe.text = "복구 비용 : " + ds.needDefense17;
                cost.text = "비용 : " + so.needMoney18;
                break;
            case 19:
                upgradePercent.text = $"{Per.level19Per}%";
                tmp.text = $"+18 {namef.weaponName18}";

                NeedDe.text = "복구 비용 : " + ds.needDefense18;
                cost.text = "비용 : " + so.needMoney19;
                break;
            case 20:
                upgradePercent.text = $"{Per.level20Per}%";
                tmp.text = $"+19 {namef.weaponName19}";


                NeedDe.text = "복구 비용 : " + ds.needDefense19;
                cost.text = "비용 : " + so.needMoney20;
                break;
            case 21:
                upgradePercent.text = $"{Per.level21Per}%";
                tmp.text = $"+20 {namef.weaponName20}";

                NeedDe.text = "복구 비용 : " + ds.needDefense20;
                cost.text = "비용 : " + so.needMoney21;
                break;
            case 22:
                upgradePercent.text = $"{Per.level22Per}%";
                tmp.text = $"+21 {namef.weaponName21}";

                NeedDe.text = "복구 비용 : " + ds.needDefense21;
                cost.text = "비용 : " + so.needMoney22;
                break;
            case 23:
                upgradePercent.text = $"{Per.level23Per}%";
                tmp.text = $"+22 {namef.weaponName22}";

                NeedDe.text = "복구 비용 : " + ds.needDefense22;
                cost.text = "비용 : " + so.needMoney23;
                break;
            case 24:
                upgradePercent.text = $"{Per.level24Per}%";
                tmp.text = $"+23 {namef.weaponName23}";

                NeedDe.text = "복구 비용 : " + ds.needDefense23;
                cost.text = "비용 : " + so.needMoney24;
                break;
            case 25:
                upgradePercent.text = $"{Per.level25Per}%";
                tmp.text = $"+24 {namef.weaponName24}";

                NeedDe.text = "복구 비용 : " + ds.needDefense24;
                cost.text = "비용 : " + so.needMoney25;
                ending.gameObject.SetActive(true);

                break;
            case 26:




                NeedDe.text = "복구 비용 : " + ds.needDefense25;

                upgradePercent.text = $"MAX";

                tmp.text = $"+25 {namef.weaponName25}";

                cost.text = "MAX";

                break;

        }
    }
    
    public void ButtonPressed()
    {
        
        randomnumber = UnityEngine.Random.Range(1, 101);
            per();

    }

    public void per()
    {

        switch (upgradeLevel)
        {
            case 2:
                MoneyManager.Instance.CheckMoney(so.needMoney2);
                if (upgradeSu)
                {
                    currentLevel = 2;
                    MoneyManager.Instance.UseMoney(so.needMoney2);
                    if (randomnumber <= Per.level2Per)
                    {

                        AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);
                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level3Per}%";
                        tmp.text = $"+2 {namef.weaponName2}";
                        
                        cost.text = "비용 : " + so.needMoney3;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense2;

                        shop.Off();

                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense1; 
                        Fail();
                        //StartCoroutine(MonsterLeftFadeOutCo());
                        //NO.gameObject.SetActive(true);

                    }
                }
                break;

            case 3:
                MoneyManager.Instance.CheckMoney(so.needMoney3);
                if (upgradeSu)
                {
                    currentLevel = 3;
                    MoneyManager.Instance.UseMoney(so.needMoney3);
                    if (randomnumber <= Per.level3Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level4Per}%";
                        tmp.text = $"+3 {namef.weaponName3}";
                        cost.text = "비용 : " + so.needMoney4;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense3;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense2;
                        Fail();
                    }
                }
                break;

            case 4:
                MoneyManager.Instance.CheckMoney(so.needMoney4);
                if (upgradeSu)
                {
                    currentLevel = 4;
                    MoneyManager.Instance.UseMoney(so.needMoney4);
                    if (randomnumber <= Per.level4Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level5Per}%";
                        tmp.text = $"+4 {namef.weaponName4}";

                        cost.text = "비용 : " + so.needMoney5;
                        NeedDe.text = "복구 비용 : " + ds.needDefense4;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense3;
                        Fail();
                    }
                }
                break;
                
            case 5:
                MoneyManager.Instance.CheckMoney(so.needMoney5);
                if (upgradeSu)
                {

                    currentLevel = 5;
                    MoneyManager.Instance.UseMoney(so.needMoney5);
                    if (randomnumber <= Per.level5Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level6Per}%";
                        tmp.text = $"+5 {namef.weaponName5}";

                        cost.text = "비용 : " + so.needMoney6;
                        NeedDe.text = "복구 비용 : " + ds.needDefense5;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense4;
                        Fail();
                    }
                }
                break;

            case 6:
                MoneyManager.Instance.CheckMoney(so.needMoney6);
                if (upgradeSu)
                {

                    currentLevel = 6;
                    MoneyManager.Instance.UseMoney(so.needMoney6);
                    if (randomnumber <= Per.level6Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level7Per}%";
                        tmp.text = $"+6 {namef.weaponName6}";

                        cost.text = "비용 : " + so.needMoney7;
                        NeedDe.text = "복구 비용 : " + ds.needDefense6;
                    }
                    else
                    {

                        NeedDefense.text = "복구 비용 : " + ds.needDefense5;
                        Fail();
                    }
                }
                break;

            case 7:
                MoneyManager.Instance.CheckMoney(so.needMoney7);
                if (upgradeSu)
                {

                    currentLevel = 7;
                    MoneyManager.Instance.UseMoney(so.needMoney7);
                    if (randomnumber <= Per.level7Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level8Per}%";
                        tmp.text = $"+7 {namef.weaponName7}";

                        cost.text = "비용 : " + so.needMoney8;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense7;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense6;
                        Fail();
                    }
                }
                break;

            case 8:
                MoneyManager.Instance.CheckMoney(so.needMoney8);
                if (upgradeSu)
                {

                    currentLevel = 8;
                    MoneyManager.Instance.UseMoney(so.needMoney8);
                    if (randomnumber <= Per.level8Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level9Per}%";
                        tmp.text = $"+8 {namef.weaponName8}";

                        cost.text = "비용 : " + so.needMoney9;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense8;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense7;
                        Fail();
                    }
                }
                break;

            case 9:
                MoneyManager.Instance.CheckMoney(so.needMoney9);
                if (upgradeSu)
                {

                    currentLevel = 9;
                    MoneyManager.Instance.UseMoney(so.needMoney9);
                    if (randomnumber <= Per.level9Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level10Per}%";
                        tmp.text = $"+9 {namef.weaponName9}";

                        cost.text = "비용 : " + so.needMoney10;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense9;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense8;
                        Fail();
                    }
                }
                break;

            case 10:
                MoneyManager.Instance.CheckMoney(so.needMoney10);
                if (upgradeSu)
                {

                    currentLevel = 10;
                    MoneyManager.Instance.UseMoney(so.needMoney10);
                    if (randomnumber <= Per.level10Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level11Per}%";
                        tmp.text = $"+10 {namef.weaponName10}";

                        cost.text = "비용 : " + so.needMoney11;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense10;
                    }
                    else
                    {

                        NeedDefense.text = "복구 비용 : " + ds.needDefense9;
                        Fail();
                    }
                }
                break;
            case 11:
                MoneyManager.Instance.CheckMoney(so.needMoney11);
                if (upgradeSu)
                {
                    currentLevel = 11;
                    MoneyManager.Instance.UseMoney(so.needMoney11);
                    if (randomnumber <= Per.level11Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level12Per}%";
                        tmp.text = $"+11 {namef.weaponName11}";

                        cost.text = "비용 : " + so.needMoney12;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense11;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense10;
                        Fail();
                    }
                }
                break;

            case 12:
                
                MoneyManager.Instance.CheckMoney(so.needMoney12);
                if (upgradeSu)
                {
                    currentLevel = 12;
                    MoneyManager.Instance.UseMoney(so.needMoney12);
                    if (randomnumber <= Per.level12Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level13Per}%";
                        tmp.text = $"+12 {namef.weaponName12}";

                        cost.text = "비용 : " + so.needMoney13;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense12;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense11;
                        Fail();
                    }
                }
                break;

            case 13:
                MoneyManager.Instance.CheckMoney(so.needMoney13);
                if (upgradeSu)
                {
                    currentLevel = 13;
                    MoneyManager.Instance.UseMoney(so.needMoney13);
                    if (randomnumber <= Per.level13Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level14Per}%";
                        tmp.text = $"+13 {namef.weaponName13}";

                        cost.text = "비용 : " + so.needMoney14;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense13;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense12;
                        Fail();
                    }
                }
                break;

            case 14:
                MoneyManager.Instance.CheckMoney(so.needMoney14);
                if (upgradeSu)
                {
                    currentLevel = 14;
                    MoneyManager.Instance.UseMoney(so.needMoney14);
                    if (randomnumber <= Per.level14Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level15Per}%";
                        tmp.text = $"+14 {namef.weaponName14}";

                        cost.text = "비용 : " + so.needMoney15;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense14;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense13;
                        Fail();
                    }
                }
                break;

            case 15:
                MoneyManager.Instance.CheckMoney(so.needMoney15);
                if (upgradeSu)
                {
                    currentLevel = 15;
                    MoneyManager.Instance.UseMoney(so.needMoney15);
                    if (randomnumber <= Per.level15Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level16Per}%";
                        tmp.text = $"+15 {namef.weaponName15}";

                        cost.text = "비용 : " + so.needMoney16;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense15;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense14;
                        Fail();
                    }
                }
                break;

            case 16:
                MoneyManager.Instance.CheckMoney(so.needMoney16);
                if (upgradeSu)
                {
                    currentLevel = 16;
                    MoneyManager.Instance.UseMoney(so.needMoney16);
                    if (randomnumber <= Per.level16Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level17Per}%";
                        tmp.text = $"+16 {namef.weaponName16}";

                        cost.text = "비용 : " + so.needMoney17;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense16;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense15;

                        Fail();
                    }
                }
                break;

            case 17:
                MoneyManager.Instance.CheckMoney(so.needMoney17);
                if (upgradeSu)
                {
                    currentLevel = 17;
                    MoneyManager.Instance.UseMoney(so.needMoney17);
                    if (randomnumber <= Per.level17Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level18Per}%";
                        tmp.text = $"+17 {namef.weaponName17}";

                        cost.text = "비용 : " + so.needMoney18;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense17;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense16;
                        Fail();
                    }
                }
                break;

            case 18:
                MoneyManager.Instance.CheckMoney(so.needMoney18);
                if (upgradeSu)
                {
                    currentLevel = 18;
                    MoneyManager.Instance.UseMoney(so.needMoney18);
                    if (randomnumber <= Per.level18Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level19Per}%";
                        tmp.text = $"+18 {namef.weaponName18}";

                        cost.text = "비용 : " + so.needMoney19;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense18;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense17;
                        Fail();
                    }
                }
                break;

            case 19:
                MoneyManager.Instance.CheckMoney(so.needMoney19);
                if (upgradeSu)
                {
                    currentLevel = 19;
                    MoneyManager.Instance.UseMoney(so.needMoney19);
                    if (randomnumber <= Per.level19Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level20Per}%";
                        tmp.text = $"+19 {namef.weaponName19}";

                        cost.text = "비용 : " + so.needMoney20;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense19;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense18;
                        Fail();
                    }
                }
                break;

            case 20:
                MoneyManager.Instance.CheckMoney(so.needMoney20);
                if (upgradeSu)
                {
                    currentLevel = 20;
                    MoneyManager.Instance.UseMoney(so.needMoney20);
                    if (randomnumber <= Per.level20Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level21Per}%";
                        tmp.text = $"+20 {namef.weaponName20}";

                        cost.text = "비용 : " + so.needMoney21;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense20;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense19;
                        Fail();

                    }
                }
                break;

            case 21:
                MoneyManager.Instance.CheckMoney(so.needMoney21);
                if (upgradeSu)
                {
                    currentLevel = 21;
                    MoneyManager.Instance.UseMoney(so.needMoney21);
                    if (randomnumber <= Per.level21Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level22Per}%";
                        tmp.text = $"+21 {namef.weaponName21}";

                        cost.text = "비용  : " + so.needMoney22;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense21;

                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense20;
                        Fail();

                    }
                }
                break;

            case 22:
                MoneyManager.Instance.CheckMoney(so.needMoney22);
                if (upgradeSu)
                {
                    currentLevel = 22;
                    MoneyManager.Instance.UseMoney(so.needMoney22);
                    if (randomnumber <= Per.level22Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level23Per}%";
                        tmp.text = $"+22 {namef.weaponName22}";

                        cost.text = "비용 : " + so.needMoney23;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense22;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense21;
                        Fail();
                    }
                }
                break;

            case 23:
                MoneyManager.Instance.CheckMoney(so.needMoney23);
                if (upgradeSu)
                {
                    currentLevel = 23;
                    MoneyManager.Instance.UseMoney(so.needMoney23);
                    if (randomnumber <= Per.level23Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level24Per}%";
                        tmp.text = $"+23 {namef.weaponName23}";

                        cost.text = "비용 : " + so.needMoney24;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense23;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense22;
                        Fail();

                    }
                }
                break;

            case 24:
                MoneyManager.Instance.CheckMoney(so.needMoney24);
                if (upgradeSu)
                {
                    currentLevel = 24;
                    MoneyManager.Instance.UseMoney(so.needMoney24);
                    if (randomnumber <= Per.level24Per)
                    {
                         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Succes);

                        upgradeSu = true;
                        ++upgradeLevel;
                        upgradePercent.text = $"{Per.level25Per}%";
                        tmp.text = $"24 {namef.weaponName24}";

                        cost.text = "비용 : " + so.needMoney25;
                        NeedDe.text = "복구 비용 : "+ ds.needDefense24;
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense23;
                        Fail();

                    }
                }
                break;

            case 25:
                MoneyManager.Instance.CheckMoney(so.needMoney25);
                if (upgradeSu)
                {
                    currentLevel = 25;
                    MoneyManager.Instance.UseMoney(so.needMoney25);
                    if (randomnumber <= Per.level25Per)
                    {
                        AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Crazy);
                        upgradeSu = true;
                        ++upgradeLevel;
                        // 다음 레벨 없으므로 여기서 업데이트 끝내거나 다른 로직 필요할 수 있음
                        upgradePercent.text = "MAX";
                        tmp.text = "25";
                        tmp.text = $"+25 {namef.weaponName25}";
                        NeedDe.text = "MAX LEVEL";
                        ending.gameObject.SetActive(true);
                    }
                    else
                    {
                        NeedDefense.text = "복구 비용 : " + ds.needDefense24;
                        Fail();

                    }
                }
                break;
            case 30:
                upgradeLevel = 2;
                upgradePercent.text = $"{Per.level2Per}%";
                tmp.text = $"+1 {namef.weaponName1}";
                cost.text = "비용 : " + so.needMoney2;
                NeedDe.text = "복구 비용 : " + ds.needDefense1;

                defenseButton.gameObject.SetActive(false);
                FailComment.gameObject.SetActive(false);
                NeedDefense.gameObject.SetActive(false);
                NO.gameObject.SetActive(false);
                shop.On();
                break;


        }












    }

    private void Fail()
    {
        int random = UnityEngine.Random.Range(0, AudioManager.Instance.Fail.Length);
         AudioManager.Instance.audioSource.PlayOneShot(AudioManager.Instance.Fail[random]);
        upgradeLevel = 30;
        defenseButton.gameObject.SetActive(true);
        FailComment.gameObject.SetActive(true);
        NeedDefense.gameObject.SetActive(true);
    }

 
}



