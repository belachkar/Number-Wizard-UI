using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
  [SerializeField] int max;
  [SerializeField] int min;
  [SerializeField] TextMeshProUGUI guessText;
  int guess;

  // Use this for initialization
  void Start() {
    StartGame();
  }

  void StartGame() {
    NextGuess();
  }

  public void OnPressHigher() {
    if (min < max) {
      min = guess + 1;
    } else {

    }
    NextGuess();
  }

  public void OnPressLower() {
    if (min < max) {
      max = guess - 1;
    } else {
      max = min;
    }
    NextGuess();
  }

  void NextGuess() {
    guess = Random.Range(min, max + 1);
    guessText.text = guess.ToString();
  }
}
