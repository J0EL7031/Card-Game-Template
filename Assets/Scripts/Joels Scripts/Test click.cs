using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testclick : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
   

    } 
    
    

    
    
 private void OnMouseDown()
        {
            // Perform actions when the object is clicked
            Debug.Log("Object clicked: " + gameObject.name);

            // You can add more actions here, such as changing color, activating/deactivating, etc.

            print("done did");

            transform.position = transform.position + new Vector3(5, 5, 0);
        }
}
