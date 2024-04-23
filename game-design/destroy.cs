void objPerson () {
  if (personalRB.velocity.magnitude < 0.5f) {
    StartCoroutine(TimeAction());
  }

  IEnumerator TimeAction();

  {
    yield return new WaitForSeconds(4);
    Detroy(gameObject);
  }
}