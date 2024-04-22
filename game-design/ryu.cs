using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagens : MonoBehaviour {
  private int moedas = 1000;
  private int Ryu = 5100;

  void Start() {
    if (moedas == Ryu) {
      print("Parabéns! Comece a jogar com Ryu");
    } else if (moedas > Ryu) {
      print("Parabéns! Comprou o Ryu e pode comprar o Blanca também.");
    } else {
      print("Você está sem grana");
    }
  }

  void Update() {}
}