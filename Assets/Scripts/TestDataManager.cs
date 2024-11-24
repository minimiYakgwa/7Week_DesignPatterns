using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestDataManager : MonoBehaviour
{
    private void Start()
    {
        DataManager.Instance.Save(); // DataManager를 찾을 필요 없이 바로 불러올 수 있음.
        GameManager.Instance.Game(); // GameManager를 찾을 필요 없이 바로 불러올 수 있음.
    }
    public void NextScene()
    {
        SceneManager.LoadScene("NextScene");
    }
}
