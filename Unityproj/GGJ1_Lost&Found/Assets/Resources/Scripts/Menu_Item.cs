using UnityEngine;
using UnityEngine.UI;

public class Menu_Item : MonoBehaviour {
    // Start is called before the first frame update
    [SerializeField] private Button PrevButton;
    [SerializeField] private Button NextButton;

    private int currentItem;

private void Awake() {
    SelectMenuItem(0);
}


    private void SelectMenuItem (int _index) {

PrevButton.interactable=(_index!=0);
NextButton.interactable=(_index!=transform.childCount-1);
        for (int i = 0; i < transform.childCount; i++) {
            transform.GetChild (i).gameObject.SetActive (i == _index);
        }

    }

    public void ChangeItem (int _change) {
        currentItem += _change;
        SelectMenuItem (currentItem);

    }
    
}