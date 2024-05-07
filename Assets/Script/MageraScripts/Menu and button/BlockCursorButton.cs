using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BlockCursorButton : MonoBehaviour
{
    private CursorMenager cursorMenager;
    private void Start()
    { 
        cursorMenager = FindObjectOfType<CursorMenager>();
        Button blockCursor = GetComponent<Button>();

        if (blockCursor != null)
        {
            blockCursor.onClick.AddListener(BlockCursor);
        }
        else
        {
            Debug.LogError("Exit button not found!");
        }
    }


    // �����, ���������� ��� ������� ������
    private void BlockCursor()
    {
        cursorMenager.cursorWork = false;
    }
}
