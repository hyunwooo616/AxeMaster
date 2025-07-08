using UnityEngine;

public class PlayerSound : MonoBehaviour
{
   public AudioSource audioSource;
    public AudioClip clip;
    Player player;
    private void Awake()
    {
        player = GetComponentInParent<Player>();
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0;
    }
    private void Update()
    {
        if(player.moveDir != new Vector2(0,0))
        {
            audioSource.volume = 0.3f;

        }
        else
        {
            audioSource.volume = 0;
        }
    }
}
