using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public int r;

    struct Item
    {

        public string food;
        public int points;
        public Sprite sprite;

        //Constructor
        public Item(string f, int p, Sprite s)
        {
            food = f;
            points = p;
            sprite = s;
        }
    }

    Item info;

    public void createItem(string ItemName, int Point, Sprite sprite)
        {
        info = new Item(ItemName, Point, sprite);
        }

    public void createRandomItem()
    {
        r = Random.Range(0, ItemManager.instance.Food.Length -1);
        info = new Item();
       
        info.sprite = ItemManager.instance.sprites[r];
        info.points = ItemManager.instance.Points[r];
        info.food = ItemManager.instance.Food[r];
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = info.sprite;

    }

}
