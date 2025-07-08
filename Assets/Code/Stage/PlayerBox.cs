using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerBox : MonoBehaviour
{
    public GameObject leaf;

    float healthBarValue;
    public GameObject HealthBar;
    public GameObject HealthBarBIG;
    public GameObject go;
    public bool canF = true;
    public int treetype;
    public F f;
    public Transform playerTransform;
    [SerializeField] private float detectRadius = 3f;
    [SerializeField] private LayerMask obstacleLayer;
    public GameObject fKey;
    private HashSet<Collider2D> previousHits = new HashSet<Collider2D>();
    private void Start()
    {
        fKey.gameObject.SetActive(false);
        HealthBar.SetActive(false);
        HealthBarBIG.SetActive(false);
    }
        
    private void Update()
    {
        if(fKey.activeSelf == true)
        {
            if (playerTransform.rotation == Quaternion.Euler(0, 180, 0))
            {
                fKey.transform.rotation = Quaternion.Euler(0, 0, 0);

            }
            else
            {
                fKey.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
      
        DetectObstaclesAroundPlayer();
       if (HealthBarBIG != null)
        {

        HealthBarBIG.transform.localScale = new Vector3(healthBarValue, 0.1447008f , 0.8376951f);
        }


    }



    void DetectObstaclesAroundPlayer()
    {
        Vector2 origin = transform.position;
        Collider2D[] currentHits = Physics2D.OverlapCircleAll(origin, detectRadius, obstacleLayer);

        HashSet<Collider2D> currentHitSet = new HashSet<Collider2D>(currentHits);
        bool foundNewObject = false;
        // ▶ 새로 들어온 오브젝트
        foreach (Collider2D col in currentHitSet)
        {
            if(f.nowChop)
            {

            Health(col);
            }

            go = col.gameObject;
            
            if (col.gameObject.transform.position.x < gameObject.transform.position.x && gameObject.transform.rotation == Quaternion.Euler(0, 0, 0))
            {
                canF = false;
            }
            else if (col.gameObject.transform.position.x > gameObject.transform.position.x && gameObject.transform.rotation == Quaternion.Euler(0, -180, 0))
            {
                canF = false;
            }
            else
            {
                canF = true;
            }
            if (!previousHits.Contains(col))
            {
                foundNewObject = true;
                fKey.gameObject.SetActive(true);
                if (col.tag == "Level1")
                {
                    treetype = 1;
                }
                else if (col.tag == "Level2")
                {
                    treetype = 2;
                }
                else if (col.tag == "Level3")
                {
                    treetype = 3;
                }
                else if (col.tag == "Level4")
                {
                    treetype = 4;

                }
            }

            fKey.SetActive(foundNewObject || currentHitSet.Count > 0);

            // ▶ 이전 감지 상태 업데이트
            previousHits = currentHitSet;

            // 디버그 선
            foreach (Collider2D hit in currentHits)
            {
                Debug.DrawLine(origin, hit.transform.position, Color.red);
            }

        }
        // ▶ 나간 오브젝트
        foreach (Collider2D col in previousHits)
        {
            if (!currentHitSet.Contains(col))
            {
                fKey.gameObject.SetActive(false);
            }
        }

    }

    private void Health(Collider2D col)
    {
        leaf.transform.SetParent(col.gameObject.transform);
        HealthBar.transform.SetParent(col.gameObject.transform);
        HealthBarBIG.transform.SetParent(col.gameObject.transform);
        leaf.transform.localPosition = new Vector3(-0.38f, 9.45f, 0);
        HealthBar.transform.localPosition = new Vector3(-0.0800170898f, -2.36397696f, 0);
        HealthBarBIG.transform.localPosition = new Vector3(-3.23687744f, -2.36080313f, 0);
        HealthBar.SetActive(true);
        HealthBarBIG.SetActive(true);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, detectRadius);
    }



}