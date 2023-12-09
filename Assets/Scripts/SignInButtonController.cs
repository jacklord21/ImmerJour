using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignInButtonController : MonoBehaviour
{
    private Button signInButton;
    
    // Start is called before the first frame update
    void Start()
    {
        signInButton = GetComponent<Button>();
        signInButton.onClick.AddListener(onSignInButtonCLick);
    }
    
    void onSignInButtonCLick()
    {
        SceneManager.LoadScene("HomeScene");
    }
}