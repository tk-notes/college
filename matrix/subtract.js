const subtract = (m1, m2) => {
  if (m1.length !== m2.length || m1[0].length != m2[0].length) {
    throw new Error("Matrices should have the same order");
  }

  let matrix = [];

  for (let i = 0; i < m1.length; i++) {
    let row = [];

    for (let j = 0; j < m1[i].length; j++) {
      row.push(m1[i][j] - m2[i][j]);
    }

    matrix.push(row);
  }

  return matrix;
};

console.log(
  subtract(
    [
      [1, 2, 3],
      [4, 2, 1],
    ],
    [
      [5, 3, 7],
      [-2, 3, 1],
      [-2, 3, 1],
    ]
  )
);
