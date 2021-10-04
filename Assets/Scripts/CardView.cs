using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;
    public Image animalImg;

    public CardModel[] cards;

    private void OnEnable()
    {
        
    }

    public void OpenCardPanel(int number)
    {
        title.text = cards[number].title;
        description.text = cards[number].description;
        exhibit.text = cards[number].exhibit;
        animalImg.sprite = cards[number].animalImage;
        this.gameObject.SetActive(true);
    }
}
