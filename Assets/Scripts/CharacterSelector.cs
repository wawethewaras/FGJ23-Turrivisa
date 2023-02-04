using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : MonoBehaviour
{
    public List<int> selectFrom = new List<int>();

    public List<Sprite> characters = new List<Sprite>();
    private int currentIndex = 0;

    public Image image;
    public int selectedCharacter;

    public void ChangeCharacterForward() {
        currentIndex++;
        if(currentIndex >= characters.Count){
            currentIndex = 0;
        }
        image.sprite = characters[currentIndex];
    }
        public void ChangeCharacterBackward() {
        currentIndex--;
        if(currentIndex < 0){
            currentIndex = characters.Count- 1;
        }
        image.sprite = characters[currentIndex];
    }

    public void SelectCharacter()
    {
        selectedCharacter = currentIndex;
    }
}
