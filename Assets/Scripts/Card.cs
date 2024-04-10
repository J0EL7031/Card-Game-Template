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
        

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();

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
                click = data.data;
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
        gm.player_play.Add(gameObject.GetComponent<Card>());
        gm.player_hand.Remove(gameObject.GetComponent<Card>());
        
        
        Debug.Log(gameObject.name);
        cardN = playerCard;
        
        int cardNumber = Random.Range(0, gm.player_play.Count);
        Card card = Instantiate(gm.player_play[cardNumber], new Vector3(200, 500, 0),
            Quaternion.identity);
        //gm.player_hand.Add(card);
       card.transform.SetParent(gm._canvas);
        //deck.RemoveAt(cardNumber);
        
        gameObject.SetActive(false);
        
        
    }
}
