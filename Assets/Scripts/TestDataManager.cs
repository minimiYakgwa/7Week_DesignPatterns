using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestDataManager : MonoBehaviour
{
    private void Start()
    {
        DataManager.Instance.Save(); // DataManager�� ã�� �ʿ� ���� �ٷ� �ҷ��� �� ����.
        GameManager.Instance.Game(); // GameManager�� ã�� �ʿ� ���� �ٷ� �ҷ��� �� ����.
    }
    public void NextScene()
    {
        SceneManager.LoadScene("NextScene");
    }
}
