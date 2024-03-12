using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    //public List<Card> player_deck = new List<Card>();
    //public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> discard_pile = new List<Card>();

    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Pp1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pp1()
    {

        Pp2();
    }
    
    void Pp2()
    {

        Ppa();
    }
    
    void Ppa()
    {

        Ap1();
    }

    void Shuffle()
    {
        
    }

    void Ap1()
    {

        Ap2();
    }
    
    void Ap2()
    {

        Apa();
    }
    
    void Apa()
    {

        ;
    }
    



    
}
