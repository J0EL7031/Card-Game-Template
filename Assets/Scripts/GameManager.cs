using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Card cardN;
    
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    //public List<Card> player_deck = new List<Card>();
    //public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> player_play = new List<Card>();
    public List<Card> ai_play = new List<Card>();
    public List<Card> discard_pile = new List<Card>();

    public int pPoints;
    public int aiPoints;

    public string cardTag;
    //public int handSize;
    public float offset;
    public Transform _canvas;
    public int em;

    public bool playing;
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
        playing = true;
        Pp1();
       
        
        //cardC.em;
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pp1()
    {
        //pPoints = +1;
        
        //player_hand + Random.Range()

        
         
        Deal(3);
    }

    void Deal(int handSize)
    {
        for (int i = 0; i < handSize; i++)
        {
            int cardNumber = Random.Range(0, deck.Count);
            Card card = Instantiate(deck[cardNumber], new Vector3(0 + offset, 200, 0),
                Quaternion.identity);
            player_hand.Add(card);
            card.transform.SetParent(_canvas);
            deck.RemoveAt(cardNumber);
            offset += 150;

        }
        
        for (int i = 0; i < handSize - 1; i++)
        {
            int cardNumber = Random.Range(0, deck.Count);
            Card card = deck[cardNumber];
            //new Vector3(0 + offset, 500, -5),Quaternion.identity;
            
            ai_hand.Add(card);
           // card.transform.SetParent(_canvas);
            deck.RemoveAt(cardNumber);
            //offset += 150;
            
            //card.GetComponent<Renderer>().enabled = true;
            //card.sprite = null;

        }
        
        //Pp2();
       // if (cardC = 0)
        {
            int cardNumber = Random.Range(0, deck.Count);
            Card card = deck[cardNumber];
            //new Vector3(0 + offset, 500, -5),Quaternion.identity;

            ai_hand.Add(card);
            // card.transform.SetParent(_canvas);
            deck.RemoveAt(cardNumber);
            //offset += 150;

            //card.GetComponent<Renderer>().enabled = true;
            //card.sprite = null;
        }

        Update();
        {
           // if (cardN = 1)
            {
                
            }
        }
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
