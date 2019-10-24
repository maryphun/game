using UnityEngine;
using UnityEngine.SceneManagement;  

public class TestSceneManager : MonoBehaviour
{
    //実験
    void Update()
    {
        //スペースキーが押されたらセレクトシーンに画面遷移
         if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Select");    
        }
    }
}