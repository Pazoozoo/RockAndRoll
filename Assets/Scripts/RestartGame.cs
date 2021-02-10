using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {
    
    public void LoadLevel(int buildIndex) {
        SceneManager.LoadScene(buildIndex);
    }
}
