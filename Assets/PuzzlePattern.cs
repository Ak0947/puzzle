using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuzzlePattern : MonoBehaviour
{
    public List<TMP_Text> texts = new List<TMP_Text>();

    public List<GameObject> targetsquares = new List<GameObject>();

    public GameObject panel;
    public TMP_Text textUI;

    public List<Vector3> newpos = new List<Vector3>();  
    private bool valid = false;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < targetsquares.Count; i++)
        {
            Debug.Log(targetsquares[i].transform.position);
            newpos.Add(targetsquares[i].transform.position);

        }

       panel.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
 

        if (texts.Count == targetsquares.Count)
        {
       
            valid = true;

         
            for (int i = 0; i < texts.Count; i++)
            {
        
                Transform parent = texts[i].transform.parent;

           
                if (parent != null)
                {
                   
                    if (parent.position != newpos[i])
                    {
            
                        valid = false;
                        break;
                    }
                }
   
            }

          
            if (valid)
            {
                Debug.Log("Pattern is valid!");
                panel.SetActive(true);
                textUI.text = "You won";
       
            }



        }
    }
}
 //5.5 //3.31