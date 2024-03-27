

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLogic : MonoBehaviour
{
    public List<GameObject> squares = new List<GameObject>();
    public GameObject selectedGameObject1, selectedGameObject2;

    public GameObject emptyobject;
    private bool alreadySelected = false;

    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector2 rayOrigin = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Mouse hit: " + hit.collider.gameObject.name);
                GameObject hitObject = hit.collider.gameObject;

               
                if (squares.Contains(hitObject))
                {                
                        selectedGameObject1 = hitObject;
                        alreadySelected = true;

                       float distance = Vector2.Distance(selectedGameObject1.transform.position, emptyobject.transform.position);

                    //    Debug.Log("Distance: " + distance);


                    if (distance < 6f)
                    {
                        Vector3 tempPosition = selectedGameObject1.transform.position;
                        selectedGameObject1.transform.position = emptyobject.transform.position;
                        emptyobject.transform.position = tempPosition;
                    }
                }

 
            }
        }
    }
}
