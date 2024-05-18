using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskBoard : MonoBehaviour
{
    public Text taskTextPrefab;
    public Transform taskListPanel;

    // ����� ��� ���������� ������� �� �����
    public void AddTaskToBoard(Task task)
    {
        Text newTaskText = Instantiate(taskTextPrefab, taskListPanel);
        newTaskText.text = task.taskName + " - " + task.status;
    }

    // ����� ��� ���������� ������� ������� �� �����
    public void UpdateTaskStatusOnBoard(Task task)
    {
        foreach (Transform taskTextTransform in taskListPanel)
        {
            Text taskText = taskTextTransform.GetComponent<Text>();
            if (taskText.text.Contains(task.taskName))
            {
                taskText.text = task.taskName + " - " + task.status;
            }
        }
    }
}
