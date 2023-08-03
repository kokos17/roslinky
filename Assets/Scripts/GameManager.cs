using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void ReportSwipe(Vector2 swipeDirection)
    {
        string directionText = GetSwipeDirectionText(swipeDirection);
        Debug.Log("Напрямок: " + swipeDirection.x + ", " + swipeDirection.y + ", " + directionText);
    }

    private string GetSwipeDirectionText(Vector2 swipeDirection)
    {
        if (Mathf.Abs(swipeDirection.x) > Mathf.Abs(swipeDirection.y))
        {
            // Horizontal swipe
            return swipeDirection.x > 0 ? "Вправо" : "Вліво";
        }
        else
        {
            // Vertical swipe
            return swipeDirection.y > 0 ? "Вверх" : "Вниз";
        }
    }
}