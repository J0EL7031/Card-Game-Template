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

    public int pPoints;
    public int aiPoints;

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
        pPoints = 0;
        aiPoints = 0;
        
        Pp1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pp1()
    {
        pPoints = +1;
        
        //player_hand + Random.Range()

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
