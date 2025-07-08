using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioSource backGround;
    public static AudioManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        

    }
    public void ButtonPress()
    {

        audioSource.Play();


    }
    public AudioClip click;
    public AudioClip Crazy;
    public AudioClip start;
    public AudioClip Buy;
    public AudioClip CantBuy;
    public AudioClip Succes;
    public AudioClip[] Fail;
    public AudioClip use;
   


}
