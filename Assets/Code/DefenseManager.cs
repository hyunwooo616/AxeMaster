using System.Xml.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86.Avx;

public class DefenseManager : MonoBehaviour
{
    UpgradePercent upg;
    SpriteRenderer sRender;

    UnityEngine.Camera cam;
    private void Awake()
    {
        upg = GetComponent<UpgradePercent>();
    }
    private void Update()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            if (upg.upgradeLevel == 30)
            {
                BB();
            }
        }
    }
    public void ButtonPressed()
    {
        BB();
    }
    public void BB()
    {
        upg.Defense = true;
        upg.defenseButton.gameObject.SetActive(false);
        upg.FailComment.gameObject.SetActive(false);
        upg.NeedDefense.gameObject.SetActive(false);
        int cl = upg.currentLevel;
        upg.upgradeLevel = upg.currentLevel;
        
        if (upg.currentLevel == 2)
        {

            upg.tmp.text = $"+3 {upg.namef.weaponName1}"; ;
            upg.upgradePercent.text = $"{upg.Per.level2Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney2;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense1);
        }
        else if (upg.currentLevel == 3)
        {
            upg.upgradePercent.text = $"{upg.Per.level3Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney3;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense2);
        }
        else if (upg.currentLevel == 4)
        {
            upg.upgradePercent.text = $"{upg.Per.level4Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney4;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense3);
        }
        else if (upg.currentLevel == 5)
        {
           
            upg.upgradePercent.text = $"{upg.Per.level5Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney5;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense4);
        }
        else if (upg.currentLevel == 6)
        {
            upg.upgradePercent.text = $"{upg.Per.level6Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney6;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense5);
        }
        else if (upg.currentLevel == 7)
        {
            upg.upgradePercent.text = $"{upg.Per.level7Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney7;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense6);
        }
        else if (upg.currentLevel == 8)
        {
            upg.upgradePercent.text = $"{upg.Per.level8Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney8;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense7);
        }
        else if (upg.currentLevel == 9)
        {
            upg.upgradePercent.text = $"{upg.Per.level9Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney9;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense8);
        }
        else if (upg.currentLevel == 10)
        {
            upg.upgradePercent.text = $"{upg.Per.level10Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney10;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense9);
        }
        else if (upg.currentLevel == 11)
        {
            upg.upgradePercent.text = $"{upg.Per.level11Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney11;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense10);
        }
        else if (upg.currentLevel == 12)
        {
            upg.upgradePercent.text = $"{upg.Per.level12Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney12;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense11);
        }
        else if (upg.currentLevel == 13)
        {
            upg.upgradePercent.text = $"{upg.Per.level13Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney13;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense12);
        }
        else if (upg.currentLevel == 14)
        {
            upg.upgradePercent.text = $"{upg.Per.level14Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney14;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense13);
        }
        else if (upg.currentLevel == 15)
        {
            upg.upgradePercent.text = $"{upg.Per.level15Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney15;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense14);
        }
        else if (upg.currentLevel == 16)
        {
            upg.upgradePercent.text = $"{upg.Per.level16Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney16;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense15);
        }
        else if (upg.currentLevel == 17)
        {
            upg.upgradePercent.text = $"{upg.Per.level17Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney17;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense16);
        }
        else if (upg.currentLevel == 18)
        {
            upg.upgradePercent.text = $"{upg.Per.level18Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney18;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense17);
        }
        else if (upg.currentLevel == 19)
        {
            upg.upgradePercent.text = $"{upg.Per.level19Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney19;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense18);
        }
        else if (upg.currentLevel == 20)
        {
            upg.upgradePercent.text = $"{upg.Per.level20Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney20;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense19);
        }
        else if (upg.currentLevel == 21)
        {
            upg.upgradePercent.text = $"{upg.Per.level21Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney21;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense20);
        }
        else if (upg.currentLevel == 22)
        {
            upg.upgradePercent.text = $"{upg.Per.level22Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney22;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense21);
        }
        else if (upg.currentLevel == 23)
        {
            upg.upgradePercent.text = $"{upg.Per.level23Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney23;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense22);
        }
        else if (upg.currentLevel == 24)
        {
            upg.upgradePercent.text = $"{upg.Per.level24Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney24;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense23);
        }
        else if (upg.currentLevel == 25)
        {
            upg.upgradePercent.text = $"{upg.Per.level25Per}%";
            upg.cost.text = "비용 : " + upg.so.needMoney25;
            MoneyManager.Instance.UseDefense(upg.ds.needDefense24);
        }

    }
}
