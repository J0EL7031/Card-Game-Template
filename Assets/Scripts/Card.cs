using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Card : MonoBehaviour, IPointerClickHandler
{
    public GameManager gm;
    public Card_data data;
    
    public string card_name;
    public string description;
    public int cost;
    public int health;
    public int damage;
    public Sprite sprite;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI damageText;
    public Image spriteImage;
    public int click;
    public int cardN;
    
    public int playerCard;

    public bool playing;
    
    public float WP;

    public int attack;
    
    public int CompareAttack(Card otherCard)
    {
        if (attack > otherCard.attack)
        {
            return 1; // This card has higher attack
        }
        else if (attack < otherCard.attack)
        {
            return -1; // Other card has higher attack
        }
        else
        {
            return 0; // Both cards have equal attack
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();

        //StartCoroutine(WaitAndPrint(3.0f));
        
        

    }

    // Update is called once per frame
    void Update()
    {
        card_name = data.card_name;
                description = data.description;
                health = data.health;
                cost = data.cost;
                damage = data.damage;
                sprite = data.sprite;
                //click = data.data;
                nameText.text = card_name;
                descriptionText.text = description;
                healthText.text = health.ToString();
                costText.text = cost.ToString();
                damageText.text = damage.ToString();
                spriteImage.sprite = sprite;
                //cardN = data.cardN;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (gm.playing)
        {
            
            
            gm.player_play.Add(gameObject.GetComponent<Card>());
            gm.player_hand.Remove(gameObject.GetComponent<Card>());


            Debug.Log(gameObject.name);
            cardN = playerCard;

            int cardNumber = Random.Range(0, gm.player_play.Count);
            Card card = Instantiate(gm.player_play[cardNumber], new Vector3(300, 500, 0),
                Quaternion.identity);
            //gm.player_hand.Add(card);
            card.transform.SetParent(gm._canvas);
            //deck.RemoveAt(cardNumber);

            gameObject.SetActive(false);

            int cardNumberC = Random.Range(0, gm.ai_hand.Count);
            Card cardC = Instantiate(gm.ai_hand[cardNumberC], new Vector3(-100, 500, 0),
                Quaternion.identity);
            gm.ai_play.Add(cardC);
            cardC.transform.SetParent(gm._canvas);
            gm.ai_hand.RemoveAt(cardNumberC);
            //offset += 150;
            
            gm.playing = false;
            
            //IEnumerator WP(float waitTime)
            {
            //    yield return new WaitForSeconds(waitTime);
            //    Debug.Log("WaitAndPrint " + Time.time);
            }

            Card card1 = new Card();
            card1.attack = 10;

            Card card2 = new Card();
            card2.attack = 8;

            int comparisonResult = card1.CompareAttack(card2);

            if (comparisonResult > 0)
            {
                Debug.Log("Card 1 has higher attack!");
            }
            else if (comparisonResult < 0)
            {
                Debug.Log("Card 2 has higher attack!");
            }
            else
            {
                Debug.Log("Both cards have equal attack!");
            }
        }
    }
}
