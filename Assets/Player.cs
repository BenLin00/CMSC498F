using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] TextMesh outputText;

    public static int currPoints=0;
    public static int currObjs=0;
    public static int currUniqObj=0;
    public static HashSet<string> types = new HashSet<string>();

    void OnCollisionEnter(Collision other){

    }

    public static void updatePoints(int points, string name) {
        currPoints += points;
        print(currPoints);
        currObjs++;

        if (name.Equals("Cube") || name.Equals("Sphere") || name.Equals("Cylinder")) {
            types.Add(name);
            currUniqObj = types.Count;
        }

        
    }

    // Update is called once per frame
    async void Update()
    {
        outputText.text = "Total Points: " + currPoints 
            +  "\n Total Objects Collected: " 
            + currObjs + "\n Unique Items Collected: " + currUniqObj;
        

        if (currUniqObj == 3) {
            this.gameObject.transform.Find("New Text").gameObject.GetComponent<TextMesh>().text=
            "YOU WIN, bEn lIn";
        }
    }

}

