using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject _statusPanel;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            OnStatusTable();
        }
        if(Input.GetKeyUp(KeyCode.Tab))
        {
            OffStatusTable();
        }
    }

    void OnStatusTable()
    {
        _statusPanel.SetActive(true);
        StatusPanel.Show();
    }

    void OffStatusTable()
    {
        _statusPanel.SetActive(false);
    }
}
