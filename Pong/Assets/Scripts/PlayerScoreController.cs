using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScoreController : MonoBehaviour
{
    public GameLogic gameLogic;

    private void OnEnable()
    {
        VisualElement root = gameObject.GetComponent<UIDocument>().rootVisualElement;
        root.Q<>
    }
}
