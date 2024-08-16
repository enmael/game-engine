using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Text[] buttonText;
    [SerializeField] string[] buttTextNaame;
    // Start is called before the first frame update

    private void Awake()
    {

    }
    void Start()
    {
        for (int i = 0; i < buttonText.Length; i++)
        {
            buttonText[i].text = buttTextNaame[i];
        }
        //buttTextNaame[0] = "New Game1";
        //buttonText.text = buttTextNaame[0];
        //buttonText.text = buttTextNaame[1];
        //buttonText.text = buttTextNaame[2];


    }

    public void NewGame()
    {
        Debug.Log("NewGame");
    }

    public void Continue()
    {
        Debug.Log("Continue");
    }

    public void Exit()
    {
        Debug.Log("Exit");
    }
}
