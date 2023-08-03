using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Vector2 pointerDownPosition;
    private Vector2 pointerUpPosition;

    private const float minSwipeDistance = 50f;

    public GameManager gameManager;

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDownPosition = eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pointerUpPosition = eventData.position;
        DetectSwipe();
    }

    private void DetectSwipe()
    {
        float swipeDistance = Vector2.Distance(pointerDownPosition, pointerUpPosition);

        if (swipeDistance < minSwipeDistance)
        {
            // Swipe distance too short, ignore
            return;
        }

        Vector2 swipeDirection = pointerUpPosition - pointerDownPosition;
        gameManager.ReportSwipe(swipeDirection.normalized);
    }
}