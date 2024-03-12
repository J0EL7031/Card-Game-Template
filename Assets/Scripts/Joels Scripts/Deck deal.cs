using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deckdeal : MonoBehaviour
{
    public int red;
    public int blue;
    public int green;
    public int grey;
    public int black;
    public int deck;

    public int draw;
    
    // Start is called before the first frame update
    void Start()
    {
        red = 6;
        blue = 6;
        green = 6;
        grey = 10;
        black = 4;

        deck = 32;
    }

    // Update is called once per frame
    void Update()
    {
        deck = red + blue + green + grey + black;
        
        
    }


    void OnMouseDown()
    {
        draw = Random.Range(1, 5);
        
        if(draw == 1)
        {
            
        }
        
        
    }
    
    
    
}
