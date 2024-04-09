using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    TextMeshProUGUI tX_Reply;

    string url = "https://api.exchangerate-api.com/v4/latest/USD";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetJsonFromUrl(url, RecievedJson));
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            SubmitMessage();
        }
    }

    IEnumerator GetJsonFromUrl(string url, System.Action<string> callback)
    {

        string JsonText;
        UnityWebRequest www = UnityWebRequest.Get(url);
        www.SetRequestHeader("Content-Type", "application/json");

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            JsonText = www.error;
        }
        else
        {
            JsonText = www.downloadHandler.text;
        }

        callback(JsonText);
        www.Dispose();

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="JsonTextRecieved"></param>
 
    JsonReciever receiver = new JsonReciever();

    public void RecievedJson(string JsonTextRecieved)
    {
        JsonTextRecieved = JsonTextRecieved.Remove(2182);
        JsonTextRecieved = JsonTextRecieved.Remove(0, 237);
        Debug.Log(JsonTextRecieved);
        receiver = JsonUtility.FromJson<JsonReciever>(JsonTextRecieved);
        print(ChooseNumber().value);
        print(ChooseNumber().currencyName);
    }

    valuepair ChooseNumber()
    {
        int x = Random.Range(0, 10);

        switch (x)
        {
            case 1:
                
                return new valuepair("USD", receiver.USD);

            case 2:
                return new valuepair("AED", receiver.AED);
                
            case 3:
                return new valuepair("AFN", receiver.AFN);
                
            case 4:
                return new valuepair("ALL", receiver.ALL);
                
            case 5:
                return new valuepair("AMD", receiver.AMD);
                
            case 6:
                return new valuepair("ANG", receiver.ANG);
                
            case 7:
                return new valuepair("AOA", receiver.AOA);
               
            case 8:
                return new valuepair("ARS", receiver.ARS);
               
            case 9:
                return new valuepair("AUD", receiver.AUD);
                
            case 10:
                return new valuepair("AWG", receiver.AWG);
            default:
                return new valuepair("USD", receiver.USD);
                
        }
    }

    struct valuepair
    {
        public string currencyName;
        public float value;
        public valuepair(string cn, float v)
        {
            currencyName = cn;
            value = v;
        }
    }

    public void compare()
    {

    }

    public void SubmitMessage()
    {
        
    }

}
