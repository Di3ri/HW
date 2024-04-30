using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public static ItemSpawner instance;

    [SerializeField]
    Vector3 LeftTopBoundary= new Vector3(-9.92000008f, -0.462512612f, 7.98999977f);
    [SerializeField]
    Vector3 RightBottomBoundary= new Vector3(9.92000008f, -0.462512612f, -12.0699997f);
    
    [SerializeField]
    LayerMask PlayerBody;

    //positions
    List<Transform> spawnpoints= new List<Transform>();

    //sprite
    [SerializeField]
    List<Sprite> sprites = new List<Sprite>();

    //prefab
    public GameObject berry;

    float duration=5;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        StartCoroutine(SpawnRoutine());
    }


    //spawner
    IEnumerator SpawnRoutine()
    {
        yield return new WaitForSeconds(duration);
        
        float xpos = Random.Range(LeftTopBoundary.x, RightBottomBoundary.x);
        float zpos = Random.Range(LeftTopBoundary.z, RightBottomBoundary.z);
        GameObject newBerry = Instantiate(berry, new Vector3(xpos,0,zpos), Quaternion.identity);
        newBerry.GetComponent<ItemScript>().createRandomItem();
        Debug.Log(xpos + " " + zpos);
        StartCoroutine(SpawnRoutine());
    }


}

