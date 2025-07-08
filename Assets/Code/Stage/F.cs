using DG.Tweening;
using System.Collections;
using TMPro;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class F : MonoBehaviour
{
    public AudioClip ad;
    public CinemachineImpulseSource impulseSource;
    public ParticleSystem leafParticle;
    public float healthBarValue;
    public SlideBar slideBar;
    public TextMeshPro Exit;
    public GameObject ExitBox;
    public bool canf = true;    
    public TreeHealthHPSO HPSO;
    public AudioClip AudioClip;
    public AudioClip Succes;
    public AudioClip Fail;
    public AudioClip FailWatch;
    public bool nowChop = false;
    [SerializeField] private Player player;
    [SerializeField] private PlayerBox pb;
    int succes;
    public int TreeHealth = 5;
    float speed;

    SpriteRenderer spriteRenderer;
    public GameObject miss;
    public Axe axe;
    public TextMeshProUGUI tmp;
   public bool canChop = true;
    public AxeDamageSO axeDamageSO;
    public GameObject succesBar;
    private void Awake()
    {
        Exit.gameObject.SetActive(false);
        ExitBox.gameObject.SetActive(false);
        tmp.gameObject.SetActive(false);

    }
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        speed = player._speed;
    }
    void Update()
    {
      

        if (  succesBar.transform.localPosition.x != 0)
        {
            succesBar.transform.localPosition = new Vector3(0, succesBar.transform.localPosition.y, 0);


        }


        if (!nowChop)
        {
            if (pb.treetype == 1)
            {
                TreeHealth = HPSO.Level1Health;

            }
            else if (pb.treetype == 2)
            {
                TreeHealth = HPSO.Level2Health;



            }
            else if (pb.treetype == 3)
            {
                TreeHealth = HPSO.Level3Health;

            }
            else if (pb.treetype == 4)
            {
                TreeHealth = HPSO.Level4Health;
            }
        }
     
            
        
        if(nowChop)
        {
            var main = leafParticle.main;
            if (pb.treetype == 1)
            {
                main.startColor = Color.white;
                float normalizedValue = (float)TreeHealth / HPSO.Level1Health;  // 0 ~ 1 사이의 값
                float finalValue = normalizedValue * 1.261f;
                if (finalValue < 0)
                {
                    finalValue = 0; // 최소 크기 제한
                }
                pb.HealthBarBIG.gameObject.transform.localScale = new Vector3(finalValue, 0.1447008f, 0.8376951f);


            }
            else if (pb.treetype == 2)
            {
                main.startColor = new Color(200f / 255f, 134f / 255f, 3f / 255f); 
                float normalizedValue = (float)TreeHealth / HPSO.Level2Health;  // 0 ~ 1 사이의 값
                float finalValue = normalizedValue * 1.261f;
                if(finalValue < 0)
                {
                    finalValue = 0;
                }
                pb.HealthBarBIG.gameObject.transform.localScale = new Vector3(finalValue, 0.1447008f, 0.8376951f);

            }
            else if (pb.treetype == 3)
            {
                main.startColor = new Color(1f, 0.5f, 0f);
                float normalizedValue = (float)TreeHealth / HPSO.Level3Health;  // 0 ~ 1 사이의 값
                float finalValue = normalizedValue * 1.261f;
                if (finalValue < 0)
                {
                    finalValue = 0; // 최소 크기 제한
                }
                pb.HealthBarBIG.gameObject.transform.localScale = new Vector3(finalValue, 0.1447008f, 0.8376951f);

            }
            else if (pb.treetype == 4)
            {
                main.startColor = Color.red;

                float normalizedValue = (float)TreeHealth / HPSO.Level4Health;  // 0 ~ 1 사이의 값
                float finalValue = normalizedValue * 1.261f;
                if (finalValue < 0)
                {
                    finalValue = 0; // 최소 크기 제한
                }
                pb.HealthBarBIG.gameObject.transform.localScale = new Vector3(finalValue, 0.1447008f, 0.8376951f);

            }

            if (Keyboard.current.tabKey.wasPressedThisFrame)
            {

                Out();
            }
        }
   
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            if (!nowChop)
            {
                
                FirstTouch();
            }
            else if (nowChop)
            {
              
                if(canChop)
                {
                 
                    Chopping();
                    axe.ChopAxe();
                    if (gameObject.activeInHierarchy)
                    {
                      
                    player.StartCoroutine(player.WaitForChop()); 
                    }
                }
            }

        }
    }

    private void Chopping()
    {
        
       
        if (slideBar.Succes)
        {
                 AudioManager.Instance.audioSource.PlayOneShot(Succes);
        impulseSource.GenerateImpulse();

            pb.go.transform.DOLocalRotate(new Vector3(0, 0, -2), 0.1f).SetEase(Ease.InBack);
          pb.go.transform.DOLocalRotate(new Vector3(0, 0, 2), 0.1f).SetDelay(0.1f).SetEase(Ease.InBack);
          pb.go.transform.DOLocalRotate(new Vector3(0, 0, 0), 0.1f).SetDelay(0.2f).SetEase(Ease.InBack);
          leafParticle.Play();
            Attack();
            int x = Random.Range(0, 8);
            if (x == 0)
            {
              succesBar.transform.localPosition = new Vector3(0,-0.06f,0);
            }
            else if (x == 1)
            {
                succesBar.transform.localPosition = new Vector3(0, 0.1f, 0);
            }
            else if (x == 2)
            {
                succesBar.transform.localPosition = new Vector3(0, 0.2f, 0);
            }
            else if(x == 3)
            {
                succesBar.transform.localPosition = new Vector3(0, -0.1f, 0);
            }
            else if (x == 4)
            {
                succesBar.transform.localPosition = new Vector3(0, -0.2f, 0);
            }
            else if (x == 5)
            {
                succesBar.transform.localPosition = new Vector3(0, -0.15f, 0);
            }
            else if(x == 6)
                {
                succesBar.transform.localPosition = new Vector3(0, 0.15f, 0);

            }
            else if (x == 7)
            {
                succesBar.transform.localPosition = new Vector3(0, 0.03f, 0);
            }

        }
        else
        {
            miss.gameObject.SetActive(true);
                 AudioManager.Instance.audioSource.PlayOneShot(Fail);
           
        }
        if (TreeHealth <= 0)
        {
                 AudioManager.Instance.audioSource.PlayOneShot(ad);
            StartCoroutine(enumerator());
        }
    }

    private void Attack()
    {
        switch(WeaponManage.Instance.currentWeapom)
        {
            case 2:
                TreeHealth -= axeDamageSO.damage1;
                break;
            case 3:
                TreeHealth -= axeDamageSO.damage2;
                break;
            case 4:
                TreeHealth -= axeDamageSO.damage3;
                break;
            case 5:
                TreeHealth -= axeDamageSO.damage4;
                break;
            case 6:
                TreeHealth -= axeDamageSO.damage5;
                break;
            case 7:
                TreeHealth -= axeDamageSO.damage6;
                break;
            case 8:
                TreeHealth -= axeDamageSO.damage7;
                break;
            case 9:
                TreeHealth -= axeDamageSO.damage8;
                break;
            case 10:
                TreeHealth -= axeDamageSO.damage9;
                break;
            case 11:
                TreeHealth -= axeDamageSO.damage10;
                break;
            case 12:
                TreeHealth -= axeDamageSO.damage11;
                break;
            case 13:
                TreeHealth -= axeDamageSO.damage12;
                break;
            case 14:
                TreeHealth -= axeDamageSO.damage13;
                break;
            case 15:
                TreeHealth -= axeDamageSO.damage14;
                break;
            case 16:
                TreeHealth -= axeDamageSO.damage15;
                break;
            case 17:
                TreeHealth -= axeDamageSO.damage16;
                break;
            case 18:
                TreeHealth -= axeDamageSO.damage17;
                break;
            case 19:
                TreeHealth -= axeDamageSO.damage18;
                break;
            case 20:
                TreeHealth -= axeDamageSO.damage19;
                break;
            case 21:
                TreeHealth -= axeDamageSO.damage20;
                break;
            case 22:
                TreeHealth -= axeDamageSO.damage21;
                break;
            case 23:
                TreeHealth -= axeDamageSO.damage22;
                break;
            case 24:
                TreeHealth -= axeDamageSO.damage23;
                break;
            case 25:
                TreeHealth -= axeDamageSO.damage24;
                break;
            case 26:
                TreeHealth -= axeDamageSO.damage25;
                break;

        }
    }

    IEnumerator enumerator()
    {

        yield return new WaitForSeconds(0.01f);
        pb.HealthBar.gameObject.SetActive(false);
        pb.HealthBarBIG.gameObject.SetActive(false);
        pb.HealthBar.transform.SetParent(gameObject.transform);
        pb.HealthBarBIG.transform.SetParent(gameObject.transform);
        spriteRenderer.enabled = true;
        player.canmove = true;
        player._speed = speed;
        nowChop = false;
        canChop= true;
        axe.gameObject.SetActive(false);
        gameObject.SetActive(false);
        Exit.gameObject.SetActive(false);   
        ExitBox.gameObject.SetActive(false);
        pb.leaf.transform.SetParent(gameObject.transform);
        Destroy(pb.go);
        if(pb.go.tag == "Level1")
        {
            MoneyManage.Instance.Money= MoneyManage.Instance.Money + 3000;
        }
        else if (pb.go.tag == "Level2")
        {
            MoneyManage.Instance.Money = MoneyManage.Instance.Money + 20000;
        }
        else if (pb.go.tag == "Level3")
        {
            MoneyManage.Instance.Money = MoneyManage.Instance.Money + 100000;
        }
        else if (pb.go.tag == "Level4")
        {
            MoneyManage.Instance.Money = MoneyManage.Instance.Money + 500000;
        }
    }
    private void Out()
    {
        axe.gameObject.SetActive(false);
        spriteRenderer.enabled = true;
        gameObject.SetActive(false);
        player.canmove = true;
        player._speed = speed;
        nowChop = false;

        Exit.gameObject.SetActive(false);
        ExitBox.gameObject.SetActive(false);
        pb.HealthBar.gameObject.SetActive(false);
        pb.HealthBarBIG.gameObject.SetActive(false);

    }

    private void FirstTouch()
    {
        
        if (pb.canF)
        {
            player.moveDir = Vector2.zero;
            axe.gameObject.SetActive(true);
                 AudioManager.Instance.audioSource.PlayOneShot(AudioClip);
            nowChop = true;
            spriteRenderer.enabled = false;
            player._speed = 0;
            player.canmove = false;
            if (player.transform.rotation == Quaternion.Euler(0, -180, 0))
            {
                Exit.transform.Rotate(0,180,0);
                Exit.transform.localPosition = new Vector3(-3.5f, -1.8f, 0);
            }
            else
            {
                Exit.transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
                Exit.gameObject.SetActive(true);
            ExitBox.gameObject.SetActive(true);

        }
      else
        {
        AudioManager.Instance.audioSource.PlayOneShot(FailWatch); 
            player.StartCoroutine(player.WatchTree());
        }
           
    
    }

}
        
