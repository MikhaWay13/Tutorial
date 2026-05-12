using UnityEngine;
using TMPro;

public class Vida : MonoBehaviour
{


    private PlayerController PlayerControllerScript;
   [SerializeField] private TextMeshProUGUI vidatext;
    public int vidas = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        vidatext.text = "Vidas: " + vidas;


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            vidas -= 1;
        }
    }
}
