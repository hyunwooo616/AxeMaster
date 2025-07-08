using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using static Unity.Burst.Intrinsics.X86.Avx;

public class Player : MonoBehaviour
{
    public F f;
    public float _speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    public bool canmove = true;
    public Miss miss;
    public Vector2 moveDir;
    public Axe axe;
    public TextMeshProUGUI tmp;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
   public IEnumerator WatchTree()
    {
        tmp.gameObject.SetActive(true);
      
        yield return new WaitForSeconds(1);
        tmp.gameObject.SetActive(false);
     


    }
    private void OnMove(InputValue value)
    {  if (canmove)
        {

        moveDir = value.Get<Vector2>();
        }
    }
    
    private void Update()
    {
        // 이동
        rb.linearVelocity= moveDir * _speed;

        // 좌우 방향에 따라 로테이션 (x축 기준으로만 판단)
        if (moveDir.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); // 왼쪽
            miss.Rotation();
        }
        else if (moveDir.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // 오른쪽
            miss.Rotation2();
        }

        // 애니메이션 상태 설정
        animator.SetBool("CanMove", moveDir != Vector2.zero);
    }
    public IEnumerator WaitForChop()
    {
        f.canChop = false;// chopping이 끝날 때까지 기다리기 위해 false로 설정
        yield return new WaitForSeconds(0.5f);
        f.canChop = true; // chopping이 끝난 후 다시 true로 설정
    }
}
