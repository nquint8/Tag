using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public InputAction PlayerInput;


    private void Start()
    {
        PlayerInput.Enable();
    }
    public void LoadNextScene(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex + 1);
    }

    void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    void Update()
    {
       object InputInfo =PlayerInput.ReadValueAsObject();
        if (InputInfo != null && SceneManager.GetActiveScene().buildIndex !=0)
        {
            LoadMenu();
        }
    }

}
