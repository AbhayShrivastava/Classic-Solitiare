using System;
using System.Linq;
using UnityEngine;


public class FoundationCardPile_13 : CardPile_13
{
    
    


    private void Update()
    {
        if(Cards.Count>1)
        {
            CheckMerge();
        }

    }

    public  void  CheckMerge()
    {


        Card_13 secondcard = Cards.ElementAt(Cards.Count - 1);
        if (Cards.Peek().CardValue==secondcard.CardValue)
        {

            if (Cards != null)
            {
                Destroy(Cards.Peek().gameObject);
                Destroy(secondcard.gameObject);
                Instantiate(Game_13.instance.cardPrefab[2], secondcard.transform.position, Quaternion.identity, transform);
            }          
            
            
        }



  
    }



  

    public override bool TryPush(Card_13 card)
    {
        if (card.Parent.Peek() != card)
        {

            return false;
        }
     

        Push(card);
        return true;
       

       
    }

    protected override void DoPush(Card_13 card)
    {
        base.DoPush(card);
     
    }
}
