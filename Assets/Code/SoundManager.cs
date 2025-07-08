using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    private void Awake()
    {
      DontDestroyOnLoad(gameObject);
        //if(Instance == null)
        //{     
        //    Instance = this;
        //    DontDestroyOnLoad(gameObject);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

}
