using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class userSelect : MonoBehaviour {
    string URL = "http://localhost/mydb/userSelect.php";
    public string[] cardsData;
   
    // Use this for initialization
    IEnumerator Start()
    {
        WWW cards = new WWW(URL);
        yield return cards;

        string cardsDataString = cards.text;
        cardsData = cardsDataString.Split(';');
       
        for (int i=0;i<10;i++)
         {
           string s = cardsData[i];
           string[] str = s.Split('?');
            //Debug.Log(s + "\n");
            for (int j = 0; j < 3; j++)
           {
                string a = str[0];
           
            }
           //Debug.Log("\n");
       }
        for (int i = 0; i < 10; i++)
        {
            string s = cardsData[i];
            Debug.Log(s + "\n");
        }
        
    }
    
        // Update is called once per frame
        void Update() {

        }
    }
