using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    //実験
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        // ログを出力
        //Debug.Log("押された");

        //SampleSceneに移動
        SceneManager.LoadScene("Main");
    }
}
