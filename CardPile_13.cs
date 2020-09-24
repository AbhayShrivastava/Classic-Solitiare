using System.Collections.Generic;
using System.Linq;
using UnityEngine;



	public class CardPile_13 : MonoBehaviour
	{
		protected Stack<Card_13> Cards = new Stack<Card_13>();

		public Card_13 Peek()
		{
			return Cards.FirstOrDefault();
		}

   
       
       

		public void Push(Card_13 card)
		{
		// Debug.Log("[CardPile] Push " + card + " to " + this, this);
			if (card.Parent == null)
				DoPush(card);
			else
			{
				IEnumerable<Card_13> poppedCardList = card.Parent.Pop(card);
				foreach (Card_13 poppedCard in poppedCardList.Reverse())
					DoPush(poppedCard);
			}
		}

		protected virtual void DoPush(Card_13 card)
		{
			Vector3 cardPosition = Vector3.zero;
			Card_13 topCard = Cards.FirstOrDefault();
			if (topCard != null)
				cardPosition = topCard.transform.localPosition;
			cardPosition.z -= 0.1f;
			card.transform.localPosition = cardPosition;

			card.transform.SetParent(transform, false);
			card.Parent = this;
			Cards.Push(card);
		}

		public IEnumerable<Card_13> Pop(Card_13 card)
		{
			List<Card_13> poppedCards = new List<Card_13>();
			while (Cards.Peek() != card)
				poppedCards.Add(Cards.Pop());
			poppedCards.Add(Cards.Pop());
			return poppedCards;
		}

		public virtual bool TryPush(Card_13 card)
		{
			return false;
		}

		public void ResetDepth()
		{
			float z = -0.1f * Cards.Count;
			foreach (Card_13 card in Cards)
			{
				Vector3 cardPosition = card.transform.localPosition;
				cardPosition.z = z;
				card.transform.localPosition = cardPosition;
				z += 0.1f;
			}
		}
	}

