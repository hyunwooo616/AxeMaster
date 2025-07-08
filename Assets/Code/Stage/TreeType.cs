using UnityEngine;
using UnityEngine.U2D.Animation;

public class TreeType : MonoBehaviour
{
    public SpriteRenderer sRender;
    public Sprite[] sprite;
    int treeType;
    [SerializeField] private int indexer;
    public GameObject[] treePrefab;
    SpriteLibrary spriteLibrary;

    void Start()
    {
        for (int i = 0; i < treePrefab.Length; i++)
           {
            treeType = Random.Range(0, 2);
            treePrefab[i].GetComponent<SpriteRenderer>().sprite = sprite[treeType];
            if(indexer == 1)
            {
                if (treeType == 0)
                    treePrefab[i].tag = ("Level2");
                else if (treeType == 1)
                {
                    treePrefab[i].tag = ("Level1");
                }
            }
            else
            {
                if (treeType == 0)
                    treePrefab[i].tag = ("Level3");
                else if (treeType == 1)
                {
                    treePrefab[i].tag = ("Level4");
                }
            }
           
        }
        }
    }
