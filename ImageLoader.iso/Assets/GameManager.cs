using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using SimpleJSON;
using UnityEngine.UI;
using UnityEngine.Networking;


public class GameManager : MonoBehaviour
{
    JsonLoader JSONLoader;

    [SerializeField]
    TextMeshProUGUI tx_Name;

    [SerializeField]
    Image image;

    private void Awake()
    {
        JSONLoader = GetComponent<JsonLoader>();

        JSONLoader.jsonRefreshed += JSONReceiver;
    }
    private void OnDestroy()
    {
        JSONLoader.jsonRefreshed -= JSONReceiver;
    }

    void JSONReceiver(JSONNode json)
    {
        tx_Name.text = json[0]["name"];
        string imageURL = json[0]["image"];
        StartCoroutine(DownloadImage(imageURL));
    }

    IEnumerator DownloadImage(string imageURL)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(imageURL);
        yield return request.SendWebRequest();

        if(request.result != UnityWebRequest.Result.ConnectionError)
        {
            Texture2D texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            print(texture);
            print(image);
            image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0, 0));
        }


    }

}
