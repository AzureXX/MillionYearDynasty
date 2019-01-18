using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    #region Singleton
    public static Player instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else if (instance != this)
            Destroy(gameObject);

    }
    #endregion

    public int Health { get => _health; set => _health = value; }
    public int Hunger { get => _hunger; set => _hunger = value; }
    public int Energy { get => _energy; set => _energy = value; }
    public int Thirst { get => _thirst; set => _thirst = value; }
    public int Aggression { get => _aggression; set => _aggression = value; }
    public int MovementPoints { get => _movementPoints; set => _movementPoints = value; }

    public int DexterityExp { get => _dexterityExp; set => _dexterityExp = value; }
    public int EnduranceExp { get => _enduranceExp; set => _enduranceExp = value; }
    public int IntellectExp { get => _intellectExp; set => _intellectExp = value; }
    public int StrengthExp { get => _strengthExp; set => _strengthExp = value; }

    [Header("Attributes")]
    [SerializeField] int _health = 100;
    [SerializeField] int _hunger = 100;
    [SerializeField] int _energy = 100;
    [SerializeField] int _thirst = 100;
    [SerializeField] int _aggression = 100;
    [SerializeField] int _movementPoints = 100;
    [Header("Stats")]
    [SerializeField] int _dexterityExp = 0;
    [SerializeField] int _enduranceExp = 0;
    [SerializeField] int _intellectExp = 0;
    [SerializeField] int _strengthExp = 0;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(instance.transform.position.x, instance.transform.position.y, -10f);
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            FindObjectOfType<PlayerActions>().GoSouth();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            FindObjectOfType<PlayerActions>().GoNorth();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            FindObjectOfType<PlayerActions>().GoEast();
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            FindObjectOfType<PlayerActions>().GoWest();
        }
    }

    private void OnMouseDown()
    {
        Debug.Log(instance.Health);
        Debug.Log(instance.transform.position);
    }
}
