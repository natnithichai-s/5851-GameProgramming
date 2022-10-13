using UnityEngine;

public class SaveManager : MonoBehaviour
{
    [SerializeField] private Transform objectTransform;
    
    private Vector2 objectPosition;
    private int _coins;
      
    private void Start()
    {
        if (PlayerPrefs.HasKey("Coins"))
        {
            _coins = PlayerPrefs.GetInt("Coins");
        }
        
        if (PlayerPrefs.HasKey("xPosition"))
        {
            var xPos = PlayerPrefs.GetFloat("xPosition");
            var yPos = PlayerPrefs.GetFloat("yPosition");

            var objectPosition = new Vector2(xPos, yPos);

            objectTransform.position = objectPosition;
        }
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _coins++;
            Debug.Log(_coins);
        }
        
        else if (Input.GetKeyDown(KeyCode.S)) // Save
        {
            PlayerPrefs.SetInt("Coins", _coins);

            PlayerPrefs.Save();
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("xPosition", objectTransform.position.x);
        PlayerPrefs.SetFloat("yPosition", objectTransform.position.y);

        PlayerPrefs.Save();
    }
}
