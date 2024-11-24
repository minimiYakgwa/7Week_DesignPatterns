using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager instance = null; // static��Ұ� �����ϸ� �޸� �Ҵ緮�� �����ϹǷ� ������ �ؾ���.

    public static DataManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void Save()
    {
        Debug.Log("������.....");
    }
}
