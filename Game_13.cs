
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class Game_13 : MonoBehaviour
{
    public Button SubmitScore;

    public bool Gameover = false;

    public static Game_13 instance;
   

    public GameObject GameOverActive;
    /// <summary>
    /// ScoreEncryption
    /// </summary>
    public string Score_Encrypt;



   
    // score moves Timer

    public Text ScoreText;
    public Text Timer;



    public Bettr_Encryption.Encrypt score;

    Bettr_Encryption.Encrypt time;







   

    [SerializeField]
    private GameObject foundationPilePrefab;

    public  GameObject[] cardPrefab;

    [SerializeField]
    private StockCardPile_13 stock;

    [SerializeField]
    private Transform foundation;

    public bool carddropped;


  



    private List<FoundationCardPile_13> foundationCardPiles = new List<FoundationCardPile_13>();
    public IEnumerable<FoundationCardPile_13> FoundationCardPiles { get { return foundationCardPiles; } }


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    public void Start()
    {

        Physics2D.gravity = new Vector2(0, -9.81f);
        Application.targetFrameRate = 60;
        score = new Bettr_Encryption.Encrypt(0);
        Score_Encrypt = "0";
        Score_Encrypt = XOREncryption.encryptDecrypt(Score_Encrypt);



      

     

        for (int foundationPileIndex = 0; foundationPileIndex < 4; foundationPileIndex++)
            CreateFoundationPile();


        Create(2);





    }

    public void Update()
    {
        //CheckGameover();


        //score


        ScoreText.text = "" + score;
        
        if(carddropped)
        {

          Create(1);
            carddropped = false;
        }

     





    }


    void Create(int n)

    {

        for (int i = 0; i < n; i++)
        {
            Stack<Card_13> cardStack = new Stack<Card_13>(CreateDeck());

            foreach (Card_13 card in cardStack)
            {
                stock.Push(card);


            }



        }


    }
    

   

    private List<Card_13> CreateDeck()
    {
        List<Card_13> cardDeck = new List<Card_13>();
       
           
                cardDeck.Add(CreateCard());
               

        
            
        

      
        return cardDeck;
    }

    private Card_13 CreateCard()
    {
        Card_13 card = Instantiate(cardPrefab[Random.Range(0, cardPrefab.Length - 1)].GetComponent<Card_13>());
        card.transform.SetParent(transform);
        card.Game = this;
        return card;
    }

    private FoundationCardPile_13 CreateFoundationPile()
    {
        FoundationCardPile_13 foundationPile = Instantiate(foundationPilePrefab).GetComponent<FoundationCardPile_13>();

        // foundationPile.Completed += CheckVictory;
        foundationPile.transform.SetParent(foundation);
        foundationCardPiles.Add(foundationPile);
        return foundationPile;
    }

   
   


























    public void GameOver()                                                                                //End game button
    {

        Gameover = true;
        GameOverActive.SetActive(true);

    }

    public void GameOverOnTimer()                                                                        //gameover on timer
    {
        GameOver();


    }



} 
    
    
    
    
    
    
    
    
    
    
    
    
    
    
   












        







    










