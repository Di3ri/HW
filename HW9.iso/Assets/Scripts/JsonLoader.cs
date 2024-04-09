using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.Networking;

public class JsonLoader : MonoBehaviour
{
    [SerializeField]
    string url = "https://cdn.jsdelivr.net/npm/country-flag-emoji-json@2.0.0/dist/index.json";

    public delegate void JSONRefreshed(JSONNode Json);
    public JSONRefreshed jsonRefreshed;

    public JSONNode currentJSON;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RefreshJSON());
    }

    IEnumerator RefreshJSON()
    {
        WWW www = new WWW(url);
    

        yield return www;
        
        if (www.error == null)
        {
            currentJSON = JSON.Parse(www.text);
            jsonRefreshed?.Invoke(currentJSON);
            print(www.text);
        } 
        else
        {
            Debug.Log("ERROR: " + www.error);
        }

        StopCoroutine(RefreshJSON());
    }
}
