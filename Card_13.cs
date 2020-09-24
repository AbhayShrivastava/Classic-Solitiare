
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;




	public class Card_13: MonoBehaviour
	{

    public bool cardscore = false;                                      //Abhay
     bool cardstock = false;


    public int CardValue;
  

    Animation anim;

    bool dragged = false;                                     //Abhay

   public AudioClip[] Card_Sounds;

 
		[SerializeField]
		private new Collider2D collider;
	

       





		public Collider2D Collider { get { return collider; } }

		public Game_13 Game;
		public CardPile_13 Parent;

	
		
	

	

    public LayoutElement CardLayout;
		
		private Transform draggingHandler;
		private Vector3 draggingStartingPoint;
		private Vector3 draggingOffset;

		private float lastClick;

		public void Start()
        {
        CardLayout = GetComponent<LayoutElement>();
        


            anim = GetComponent<Animation>();

    }

    private void Update()
    {
        if (Game.Gameover == true)
        {
            return;

            

        }

        //Abhay
       /* if (Input.touchCount > 0)                                                                          
          {
              Touch touch = Input.GetTouch(0);
              Vector2 touchpos = Camera.main.ScreenToWorldPoint(touch.position);





                  switch (touch.phase)
                  {

                      case TouchPhase.Began:
                          // Debug.Log("touchstart");



                          if (collider == Physics2D.OverlapPoint(touchpos))
                          {

                              dragged = true;

                              if (touch.tapCount == 1)
                                  if ((Visible == false) && (Parent.Peek() == this))
                                  {
                               GameObject.FindWithTag("TAG_1").GetComponent<AudioSource>().PlayOneShot(Card_Sounds[2]);
                                anim.Play();
                                      Visible = true;
                                      Game.score += new Bettr_Encryption.Encrypt(5);
                                   Game.Score_Encrypt = XOREncryption.encryptDecrypt(Game.Score_Encrypt);
                                   Game.Score_Encrypt = (int.Parse(Game.Score_Encrypt) + 5).ToString();
                                   Game.Score_Encrypt = XOREncryption.encryptDecrypt(Game.Score_Encrypt);
                              }







                          if (touch.tapCount > 1)
                              {
                            if (Parent is WasteCardPile_13)
                            {
                                foreach (FoundationCardPile_13 foundationCardPile in Game.FoundationCardPiles)
                                {
                                    if (foundationCardPile.TryPush(this))
                                    {
                                        GameObject.FindObjectOfType<WasteCardPile_13>().CardTaken = true;



                                        Game.score += new Bettr_Encryption.Encrypt(10);                        //Abhay

                                        //scoreEncryption

                                        Game.Score_Encrypt = XOREncryption.encryptDecrypt(Game.Score_Encrypt);
                                        Game.Score_Encrypt = (int.Parse(Game.Score_Encrypt) + 10).ToString();
                                        Game.Score_Encrypt = XOREncryption.encryptDecrypt(Game.Score_Encrypt);
                                       





                                        break;
                                    }
                                }
                            }
                            if ((Parent is FoundationCardPile_13) == false)
                                  {


                                      foreach (FoundationCardPile_13 foundationCardPile in Game.FoundationCardPiles)
                                      {
                                          if (foundationCardPile.TryPush(this) && cardscore == false && Visible==true)                          //Abhay
                                          {
                                     GameObject.FindWithTag("TAG_1").GetComponent<AudioSource>().PlayOneShot(Card_Sounds[3]);
                                        //  Destroy(this.Collider);                                               //Abhay
                                        Game.score += new Bettr_Encryption.Encrypt(10);                        //Abhay

                                          //scoreEncryption
                    Game.Score_Encrypt = XOREncryption.encryptDecrypt(Game.Score_Encrypt);
                    Game.Score_Encrypt = (int.Parse(Game.Score_Encrypt) + 10).ToString();
                    Game.Score_Encrypt = XOREncryption.encryptDecrypt(Game.Score_Encrypt);
                                         
                                                
                            
                            

                                              break;

                                          }



                                      }

                                  }
                              }



                              draggingStartingPoint = Camera.main.ScreenToWorldPoint(touchpos);

                          }
                          break;


                      case TouchPhase.Moved:
                          //Debug.Log("touchbegan");
                          if (dragged == true)
                          {


                              if (Visible == false)
                                  break;

                              if (Parent is WasteCardPile_13)
                              {
                                  if (Parent.Peek() != this)
                                  {
                                      break;
                                  }
                              }
                              Vector3 newPosition = Camera.main.ScreenToWorldPoint(touch.position);
                              if (draggingHandler == null)
                              {
                                  float dragDelta = ((Vector2)newPosition - (Vector2)draggingStartingPoint).magnitude;
                                  if (dragDelta > 0.1f)
                                  {
                               GameObject.FindWithTag("TAG_1").GetComponent<AudioSource>().PlayOneShot(Card_Sounds[0]);
                                // Debug.Log("[Card] StartDragging");

                                Vector3 initialPosition = transform.position;
                                      draggingOffset = initialPosition - Camera.main.ScreenToWorldPoint(touch.position);

                                      draggingHandler = new GameObject().transform;
                                      draggingHandler.name = "DraggingHandler";
                                      draggingHandler.position = initialPosition;

                                      transform.SetParent(draggingHandler);
                                      if (Parent is TableauCardPile_13)
                                      {
                                          foreach (Card_13 card in ((TableauCardPile_13)Parent).GetChildren(this))
                                              card.transform.SetParent(draggingHandler);
                                      }
                                      if (Parent is FoundationCardPile_13)
                                      {
                                          cardscore = true;
                                      }
                                      if (Parent is WasteCardPile_13)
          {
              cardstock = true;
          }




                                  }
                              }

                              if (draggingHandler != null)
                              {
                                  newPosition += draggingOffset;
                                  newPosition.z = -5;
                                  draggingHandler.position = newPosition;
                              }

                          }
                          break;



                      case TouchPhase.Ended:
                          //Debug.Log("touchended");
                          dragged = false;
                          if (draggingHandler != null)
                          {

                              Drop();


                          }

                          break;








                  }



              }*/






    }//changes end




   

                            public void OnMouseDown()
                                    {
                                        draggingStartingPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                                    }

                                    public void OnMouseDrag()
                                    {
                                       

                                       if (Parent is StockCardPile_13)
                                        {
                                            if (Parent.Peek()!=this)
                                            {
                                                return;
                                            }
                                        }





                                        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                                        if (draggingHandler == null)
                                        {
                                            float dragDelta = ((Vector2)newPosition - (Vector2)draggingStartingPoint).magnitude;
                                            if (dragDelta > 0.1f)
                                                StartDragging();
                                        }

                                        if (draggingHandler != null)
                                        {
                                            newPosition += draggingOffset;
                                            newPosition.z = -5;
                                            draggingHandler.position = newPosition;
                                        }
                                    }

    public void OnMouseUp()
    {








      
        if (draggingHandler != null)
        {

            Drop();


        }
    }
    


               private void StartDragging()
               {
                   // Debug.Log("[Card] StartDragging");

                   Vector3 initialPosition = transform.position;
                   draggingOffset = initialPosition - Camera.main.ScreenToWorldPoint(Input.mousePosition);

                   draggingHandler = new GameObject().transform;
                   draggingHandler.name = "DraggingHandler";
                   draggingHandler.position = initialPosition;

                   transform.SetParent(draggingHandler);
                  

               }

        private void Drop()
		{



        // Debug.Log("[Card] Drop");

      
          
			bool moved = false;
        Bounds bounds = collider.bounds;
        
        
		

			// Disable dragged card colliders to detect the collider under them
			collider.enabled = false;
		

        Collider2D overCollider = Physics2D.OverlapArea(bounds.min,bounds.center);          //Abhay

			if (overCollider != null)
			{
				//Debug.Log("[Card] Drop on " + overCollider.name, overCollider);
				CardPile_13 cardPile = overCollider.GetComponent<CardPile_13>();
				if (cardPile == null)
					cardPile = overCollider.GetComponentInParent<CardPile_13>();
				if (cardPile != null)
					moved = cardPile.TryPush(this);
			}

			collider.enabled = true;
			
      
          if(moved==true)
        {
            Game.carddropped = true;
        }
            
    

            
            

           
        
        if (moved == false)
            {


            
                transform.SetParent(Parent.transform, false);
				
                
                Parent.ResetDepth();
            }
            

			Destroy(draggingHandler.gameObject);
		}

	
    }

    
  



    

