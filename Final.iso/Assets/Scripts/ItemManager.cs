using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject berry;

    public string[] Food = {"Blueberry", "Pear", "Cherry","Banana","Apple",
        "Pomagranate","Strawberry", "Orange","Peach","Coconut","Kiwi","Green Apple","Lemon"};

    public int[] Points = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1 };

    public List<Sprite> sprites = new List<Sprite>();
    List<GameObject> Groceries = new List<GameObject>();

    public static ItemManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
   


}
