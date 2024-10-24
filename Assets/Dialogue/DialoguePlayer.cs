using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class DialoguePlayer : MonoBehaviour
{
    public DialogueAsset _DialogueAsset;
    public TMP_Text _DialogueText;
    public GameObject _DialogueBox;
    public GameObject _Planel;

    private int _dialogueIndex;

    private void Start()
    {
        _Planel.gameObject.SetActive(true);
        _DialogueText.text = _DialogueAsset._Dialogue[0];
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return))
        {
            //_dialogueIndex += 1;
            _dialogueIndex++;

            if (_dialogueIndex < _DialogueAsset._Dialogue.Length)
            {
                _DialogueText.text = _DialogueAsset._Dialogue[_dialogueIndex];
            }
            else
            {
                _DialogueBox.gameObject.SetActive(false);
                _Planel.gameObject.SetActive(false);
            }

        }
        
    }
}