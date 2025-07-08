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
        // �̵�
        rb.linearVelocity= moveDir * _speed;

        // �¿� ���⿡ ���� �����̼� (x�� �������θ� �Ǵ�)
        if (moveDir.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0); // ����
            miss.Rotation();
        }
        else if (moveDir.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0); // ������
            miss.Rotation2();
        }

        // �ִϸ��̼� ���� ����
        animator.SetBool("CanMove", moveDir != Vector2.zero);
    }
    public IEnumerator WaitForChop()
    {
        f.canChop = false;// chopping�� ���� ������ ��ٸ��� ���� false�� ����
        yield return new WaitForSeconds(0.5f);
        f.canChop = true; // chopping�� ���� �� �ٽ� true�� ����
    }
}
